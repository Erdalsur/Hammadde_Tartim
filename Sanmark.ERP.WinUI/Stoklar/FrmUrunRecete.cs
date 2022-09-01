using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Sanmark.ERP.WinUI.BaseForms;
using Sanmark.Erp.Entities.Concrete.Stok;
using DevExpress.XtraEditors.Repository;
using Sanmark.Core.Utilities.Win.Infrastructure;
using DevExpress.XtraGrid;
using Sanmark.ERP.WinUI.Core.Grid;
using Sanmark.Core.Utilities;
using System.Reflection;

namespace Sanmark.ERP.WinUI.Stoklar
{
    public partial class FrmUrunRecete : XPopupForm
    {
        bool _durum = false;
        RepositoryItemGridLookUpEdit gleDepolar, gleBirimler, gleMakinalar, gleStoklar;
        StokKarti anaStokKarti, itemStock;
        UrunRecete urunRecete;
        UrunReceteDetay receteDetay;
        public FrmUrunRecete()
        {
            InitializeComponent();
            urunRecete = new UrunRecete();
            urunRecete.UrunReceteDetay = new BindingList<UrunReceteDetay>();
        }
        public FrmUrunRecete(int receteId, bool durum = false)
        {
            InitializeComponent();
            urunRecete = DataSession.UrunReceteService.GetById(receteId);
            urunRecete.UrunReceteDetay = new BindingList<UrunReceteDetay>(urunRecete.UrunReceteDetay.ToList());
            anaStokKarti = DataSession.StokKartService.GetAll(f => f.Id == urunRecete.StokId).SingleOrDefault();
            //urunRecete.UrunReceteDetay = new BindingList<UrunReceteDetay>();
            txtAciklama.EditValue = urunRecete.Aciklama;
            txtKod.EditValue = urunRecete.ReceteKodu;
            txtMiktar.EditValue = urunRecete.Miktar;
            txtStokAd.EditValue = anaStokKarti.Ad;
            txtStokKod.EditValue = anaStokKarti.Kod;
            gleBirim.EditValue = urunRecete.BirimId;
            gleDepo.EditValue = urunRecete.DepoId;
            gleMakina.EditValue = urunRecete.MakinaId;
            this.Text += String.Format(" - {0} Kodlu Reçete", urunRecete.ReceteKodu);
            _durum = durum;
        }

        private void FrmUrunRecete_Load(object sender, EventArgs e)
        {


            gcHareket.DataSource = urunRecete.UrunReceteDetay; //new BindingList<UrunReceteDetay>(urunRecete.UrunReceteDetay.ToList());
            //gcHareket.DataMember = "UrunReceteDetay";
            //InitGridView(gvHareket);
            GleDoldur();
            if (_durum)
            {
                bbiKaydet.Enabled =
                btnItemEkle.Enabled =
                colSil.OptionsColumn.AllowEdit =
                txtItemStokKod.Properties.Buttons.FirstOrDefault().Enabled =
                txtStokKod.Properties.Buttons.FirstOrDefault().Enabled =
                txtStokKod.Enabled =
                    txtKod.Enabled =
                    txtMiktar.Enabled =
                    txtAciklama.Enabled =
                    gleDepo.Enabled =
                    gleBirim.Enabled =
                    gleMakina.Enabled =
                    txtItemStokKod.Enabled =
                    txtItemMiktar.Enabled =
                    gleItemBirim.Enabled =
                    gleItemDepo.Enabled = false;
            }
            gvHareket.AddSummaryKilo("Miktar");
        }



        private void GleDoldur()
        {
            gleDepolar = GetCustomGLE(DataSession.DepoService.GetAll(f => f.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleDepo.Properties.Assign(gleDepolar);
            gleItemDepo.Properties.Assign(gleDepolar);
            gleBirimler = GetCustomGLE(DataSession.StokBirimService.GetAll(f => f.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleBirim.Properties.Assign(gleBirimler);
            gleItemBirim.Properties.Assign(gleBirimler);
            gleMakinalar = GetCustomGLE(DataSession.UretimService.GetMakinalar(f => f.SirketId == AppSession.Sirket.Id && f.DonemId == AppSession.Donem.Id), "MakinaAdi", "Id");
            gleStoklar = GetCustomGLE(DataSession.StokKartService.GetAll(f => f.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleMakina.Properties.Assign(gleMakinalar);
            gvHareket.Columns["StokKartiId"].ColumnEdit = gleStoklar;
            gvHareket.Columns["StokBirimId"].ColumnEdit = gleBirimler;
            gvHareket.Columns["DepoId"].ColumnEdit = gleDepolar;
            gleDepo.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.Depo_VarsayilanDepo);
            gleItemDepo.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.Depo_VarsayilanDepo);
        }

        private void gvHareket_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            receteDetay = new UrunReceteDetay();
            receteDetay.UrunRecete = urunRecete;
            urunRecete.UrunReceteDetay.Add(receteDetay);

        }

        private void gvHareket_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void txtItemStokKod_Validated(object sender, EventArgs e)
        {
            itemStock = DataSession.StokKartService.GetAll(f => f.Kod == txtItemStokKod.Text).SingleOrDefault();
            if (itemStock != null)
            {
                txtItemStokKod.Text = itemStock.Kod;
                lblStokAdi.Text = "Stok Adı : " + itemStock.Ad;
                gleItemBirim.EditValue = itemStock.StokBirimId;

            }
        }

        private void btnItemEkle_Click(object sender, EventArgs e)
        {
            //itemStock = DataSession.StokKartService.GetAll(f => f.Kod == txtStokKod.Text).SingleOrDefault();
            if (itemStock != null)
            {
                var detayim = new UrunReceteDetay();

                detayim.DepoId = Convert.ToInt32(gleItemDepo.EditValue);
                detayim.StokBirimId = Convert.ToInt32(gleItemBirim.EditValue);
                detayim.StokKartiId = itemStock.Id;
                //detayim.UrunRecete = urunRecete;
                detayim.UrunReceteId = urunRecete.Id;
                detayim.Miktar = Convert.ToDecimal(txtItemMiktar.EditValue);
                detayim.KayitTarihi = DateTime.Now;
                detayim.KayitUserId = AppSession.CurrentUser.Id;
                //detayim.StokKarti = itemStock;
                urunRecete.UrunReceteDetay.Add((UrunReceteDetay)detayim);
                //gvHareket.RefreshData();
            }
        }

        private void btnItemSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Kaydı Silmek İstediğinize Emin misiniz", "Silme", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gvHareket.DeleteSelectedRows();
            }
        }

        private void bbiKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gvHareket.EndEditing();

            if (urunRecete.UrunReceteDetay.Count() == 0)
            {
                AppSession.MainForm.ShowErrorMessage("Boş reçete kayıt edilemez.");
                return;
            }
            DynamicTryCatch.TryCatch(() =>
            {
                urunRecete.IsActive = true;
                urunRecete.ReceteKodu = txtKod.Text;
                urunRecete.StokId = anaStokKarti.Id;
                urunRecete.DepoId = Convert.ToInt32(gleDepo.EditValue);
                urunRecete.Miktar = Convert.ToDecimal(txtMiktar.EditValue);
                urunRecete.BirimId = Convert.ToInt32(gleBirim.EditValue);
                urunRecete.MakinaId = Convert.ToInt32(gleMakina.EditValue);
                urunRecete.Aciklama = txtAciklama.Text;
                if (urunRecete.Id > 0)
                {
                    //Güncelleme
                    if (XtraMessageBox.Show(String.Format("{0} Kodlu Reçetede Revizyon Kayıt Edilsin mi?", txtKod.Text), "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                }
                DataSession.UrunReceteService.Add(urunRecete);

                this.DialogResult = DialogResult.OK;
            }, MethodBase.GetCurrentMethod().Name);



        }

        private void txtItemStokKod_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmStokSec stokSec = new FrmStokSec();
            stokSec.ShowDialog();
            if (stokSec.secildi)
            {
                itemStock = stokSec.secilen.First();
                txtItemStokKod.Text = itemStock.Kod;
                lblStokAdi.Text = "Stok Adı : " + itemStock.Ad;
                gleItemBirim.EditValue = itemStock.StokBirimId;

            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            if (gvHareket.IsNewItemRow(gvHareket.FocusedRowHandle))
            {
                gvHareket.AddNewRow();
            }
            FrmStokSec stokSec = new FrmStokSec();
            stokSec.ShowDialog();
            if (stokSec.secildi)
            {
                var secilenStok = stokSec.secilen.First();
                var handle = gvHareket.GetSelectedRows()[0];
                gvHareket.SetRowCellValue(handle, gvHareket.Columns["StokBirimId"], secilenStok.StokBirimId.ToString());
                gvHareket.SetRowCellValue(handle, gvHareket.Columns["StokKartiId"], secilenStok.Id.ToString());
                if (handle < 0)
                {
                    receteDetay.StokBirimId = secilenStok.StokBirimId;
                    receteDetay.StokKartiId = secilenStok.Id;
                }

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
    }
}