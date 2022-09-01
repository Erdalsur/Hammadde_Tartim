using DevExpress.XtraEditors.Repository;
using Sanmark.Core.Utilities;
using Sanmark.Core.Utilities.Tipler;
using Sanmark.Erp.Entities;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Entities.Concrete.Uretim;
using Sanmark.ERP.WinUI.BaseForms;
using Sanmark.ERP.WinUI.Stoklar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanmark.ERP.WinUI.Uretim
{
    public partial class FrmIsEmri : XPopupForm
    {
        CodeTool codeTool;
        RepositoryItemGridLookUpEdit gleBirimler;
        StokKarti anaStokKarti;
        IsEmri isEmri;
        bool ilkKayit = true;
        public FrmIsEmri()
        {
            InitializeComponent();
            isEmri = new IsEmri();
            codeTool = new CodeTool(this, CodeTool.Table.IsEmri, DataSession.KodService);
            codeTool.BarButtonOlustur();
        }
        public FrmIsEmri(int IsEmriId) : this()
        {
            isEmri = DataSession.IsEmirService.GetById(IsEmriId);
            anaStokKarti = DataSession.StokKartService.GetById(isEmri.StokKartiId);
            txtStokKod.Text = anaStokKarti.Kod;
            txtKod.Text = isEmri.IsEmriKodu;
            txtAciklama.Text = isEmri.Aciklama;
            txtPartiNo.Text = isEmri.PartiNo;
            dateBaslamaTarihi.EditValue = isEmri.PlanlananBaslangicTarihi;
            dateBitisTarihi.EditValue = isEmri.PlananBitisTarihi;
            txtMiktar.Text = isEmri.Miktar.ToString();
            txtStokAd.Text = anaStokKarti.Ad;
            gleBirim.EditValue = isEmri.BirimId;
            ilkKayit =
            btnKod.Visible = false;
            if (isEmri.GenelDurumu == (int)Status.Tamam)
            {
                //Üretim Tamamlanmış 
                bbiKaydet.Enabled = false;
            }
        }

        private void FrmIsEmri_Load(object sender, EventArgs e)
        {
            gleBirimler = GetCustomGLE(DataSession.StokBirimService.GetAll(f => f.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleBirim.Properties.Assign(gleBirimler);
        }

        private void bbiKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (anaStokKarti == null)
            {
                AppSession.MainForm.ShowErrorMessage("Geçerli bir stok kartı seçin!");
                return;
            }
            var durum = DataSession.UrunReceteService.GetAll(f => f.StokId == anaStokKarti.Id).Count() > 0 ? true : false;
            if (!durum)
            {
                AppSession.MainForm.ShowErrorMessage("Seçilen ürüne ait reçete yok! Önce ürün reçetesini oluşturun.");
                return;
            }
            DynamicTryCatch.TryCatch(() =>
                {
                    isEmri.IsEmriKodu = txtKod.Text;
                    isEmri.Aciklama = txtAciklama.Text;
                    isEmri.PartiNo = txtPartiNo.Text;
                    isEmri.StokKartiId = anaStokKarti.Id;
                    isEmri.Miktar = Convert.ToDecimal(txtMiktar.Text);
                    isEmri.BirimId = intParse(gleBirim.EditValue);
                    isEmri.PlanlananBaslangicTarihi = Convert.ToDateTime(dateBaslamaTarihi.EditValue);
                    isEmri.PlananBitisTarihi = Convert.ToDateTime(dateBitisTarihi.EditValue);

                }, MethodBase.GetCurrentMethod().Name);

            if (ilkKayit)
            {
                DataSession.IsEmirService.IsEmri_Add(isEmri);
                codeTool.KodArttirma();
            }
            else
            {
                DataSession.IsEmirService.Update(isEmri);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void txtStokKod_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmStokSec stokSec = new FrmStokSec();
            stokSec.ShowDialog();
            if (stokSec.secildi)
            {
                anaStokKarti = stokSec.secilen.First();
                txtStokAd.Text = anaStokKarti.Ad;
                txtStokKod.Text = anaStokKarti.Kod;
                gleBirim.EditValue = anaStokKarti.StokBirimId;
            }
        }

        private void txtStokKod_Validated(object sender, EventArgs e)
        {
            anaStokKarti = DataSession.StokKartService.GetAll(f => f.Kod == txtStokKod.Text).SingleOrDefault();
            if (anaStokKarti != null)
            {
                txtStokAd.Text = anaStokKarti.Ad;
                txtStokKod.Text = anaStokKarti.Kod;
                gleBirim.EditValue = anaStokKarti.StokBirimId;
            }
        }

        private void bbiIhtiyacListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (anaStokKarti != null)
            {
                var recete = DataSession.UrunReceteService.GetAll(f => f.StokId == anaStokKarti.Id);
                if (recete.Count > 0)
                {
                    FrmIsEmriIhtiyacListesi frm = new FrmIsEmriIhtiyacListesi(anaStokKarti.Id, intParse(gleBirim.EditValue), Convert.ToDecimal(txtMiktar.Text));
                    frm.ShowDialog();
                }
                else
                    AppSession.MainForm.ShowErrorMessage("Ürüne ait reçete tanımlı değil");

            }

        }
    }
}
