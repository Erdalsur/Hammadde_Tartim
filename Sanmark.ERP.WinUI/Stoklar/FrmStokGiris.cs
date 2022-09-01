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
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors.Repository;
using Sanmark.Core.Utilities.Tipler;
using Sanmark.Erp.Entities.Concrete.Depolar;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Core.Utilities.Win.Infrastructure;
using Sanmark.ERP.WinUI.Core.Grid;
using Sanmark.Erp.Entities.Concrete.Cari;

namespace Sanmark.ERP.WinUI.Stoklar
{
    public partial class FrmStokGiris : XPopupForm
    {
        public int Id = -1;
        Fis fis;
        BindingList<StokHareket> stokHarekets;
        RepositoryItemGridLookUpEdit gleDepolar, gleFirmalar, gleHammaddeDurumlari, gleStoklar,gleBirimler, gleAnalizSertifika;
        StokGirisCikis _stokGirisCikis;
        public FrmStokGiris(StokGirisCikis stokGirisCikis)
        {
            InitializeComponent();
            SplashScreenManager.ShowForm(typeof(FrmWait));
            _stokGirisCikis = stokGirisCikis;
            if (stokGirisCikis==StokGirisCikis.Cikis)
            {
                lblDepo.Text = "Çıkış Depo";
                lblFirma.Text = "Çıkılan Firma";
                lblTarih.Text = "Çıkış Tarihi";
                this.Text = "Stok Depo Çıkışı";
            }
            fis = new Fis();
            fis.Tarih = DateTime.Now;
            stokHarekets = new BindingList<StokHareket>();
            txtAciklama.DataBindings.Add("EditValue", fis, "Aciklama");
            dateTarih.DataBindings.Add("EditValue", fis, "Tarih");
            //gleDepo.DataBindings.Add("EditValue", fis, "Tarih");
            //txtKod.DataBindings.Add("Text", fis, "FisKodu");
            txtKod.DataBindings.Add("EditValue", fis, "BelgeNo");
            //gleFirma.DataBindings.Add("EditValue", fis, "CariId");
            txtTeslimEden.DataBindings.Add("Text", fis, "TeslimEden");
            gleHammadeDurum.EditValue = 0;
            fis.FisTuru = ((int)stokGirisCikis).ToString();
            fis.StokHareket = stokHarekets;
        }
        public FrmStokGiris(StokGirisCikis stokGirisCikis,int fisId)
        {
            InitializeComponent();
            SplashScreenManager.ShowForm(typeof(FrmWait));
            _stokGirisCikis = stokGirisCikis;
            if (stokGirisCikis == StokGirisCikis.Cikis)
            {
                lblDepo.Text = "Çıkış Depo";
                lblFirma.Text = "Çıkılan Firma";
                lblTarih.Text = "Çıkış Tarihi";
                this.Text = "Stok Depo Çıkışı";
            }
            fis = DataSession.StokHareketService.GetByIdFis(fisId);
            fis.StokHareket = new BindingList<StokHareket>(DataSession.StokHareketService.GetAll(f => f.FisId == fisId));
            txtAciklama.DataBindings.Add("EditValue", fis, "Aciklama");
            gleFirma.EditValue = fis.CariId;
            if (fis.StokHareket.FirstOrDefault().HareketTuru != ((int)HareketTuru.GirisFisi).ToString())
            {
                panelControl3.Visible=
                bbiKaydet.Enabled = false;

            }
            dateTarih.DataBindings.Add("EditValue", fis, "Tarih");
            //gleDepo.DataBindings.Add("EditValue", fis, "Tarih");
            //txtKod.DataBindings.Add("Text", fis, "FisKodu");
            txtKod.DataBindings.Add("EditValue", fis, "BelgeNo");
            //gleFirma.DataBindings.Add("EditValue", fis, "CariId");
            txtTeslimEden.DataBindings.Add("Text", fis, "TeslimEden");
            gleHammadeDurum.EditValue = 0;
            fis.FisTuru = ((int)stokGirisCikis).ToString();
                
        }

        private void FrmStokGiris_Load(object sender, EventArgs e)
        {
            gleDepo.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.Depo_VarsayilanDepo);
            GleOlustur();
            gcHareket.DataSource = fis.StokHareket;
            //InitGridView(gvHareket);
            var analizSertifikaTip = (List<EnumListesi>)typeof(AnalizSerifikası).ToList2();
            gleAnalizSertifika = GetGLEEnum(analizSertifikaTip, "Ad");
            gvHareket.Columns["AnalizSertifikasiGeldimi"].ColumnEdit = gleAnalizSertifika;

        }

        private void gvHareket_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {

        }

        private void bbiKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gvHareket.EndEditing();
            fis.CariId = Convert.ToInt32(gleFirma.EditValue);
            fis.TeslimEden = txtTeslimEden.Text;            
            fis.StokHareket.ToList().ForEach(c => c.FisNo = fis.FisKodu);
            fis.StokHareket.ToList().ForEach(c => c.DepoId = Convert.ToInt32(gleDepo.EditValue));
            fis.StokHareket.ToList().ForEach(c => c.SirketId = AppSession.Sirket.Id);
            fis.StokHareket.ToList().ForEach(c => c.DonemId = AppSession.Donem.Id);
            fis.StokHareket.ToList().ForEach(c => c.HareketTuru = ((int)HareketTuru.GirisFisi).ToString());
            fis.DonemId = AppSession.Donem.Id;
            fis.SirketId = AppSession.Sirket.Id;
            fis.IskontoTutar =
                fis.ToplamTutar = 0;
                fis.PlasiyerId = 0;
            fis.IskontoOrani = 0;
            
            //Console.WriteLine(fis.FisKodu);
            if (fis.StokHareket.Count() == 0)
            {
                AppSession.MainForm.ShowErrorMessage("Fis Boş Kayıt Edilemez");
                return;
            }
            if (fis.Id > 0)
                DataSession.StokHareketService.UpdateFis(fis);
            else
                DataSession.StokHareketService.AddFis(fis);
            this.DialogResult = DialogResult.OK;
        }

        private void GleOlustur()
        {
            List<Firma> firmalarimiz;
            if (_stokGirisCikis == StokGirisCikis.Giris)
                firmalarimiz = DataSession.FirmaService.GetAll(f => f.SirketId == AppSession.Sirket.Id && f.FirmaTip == (Int16)(FirmaTipi.Satici) || f.FirmaTip == (Int16)(FirmaTipi.SaticiveMusteri));
            else
                firmalarimiz = DataSession.FirmaService.GetAll(f => f.SirketId == AppSession.Sirket.Id && f.FirmaTip == (Int16)(FirmaTipi.Musteri) || f.FirmaTip == (Int16)(FirmaTipi.SaticiveMusteri));
            gleFirmalar = GetCustomGLE(firmalarimiz, "Ad", "Id");
            gleDepolar = GetCustomGLE(DataSession.DepoService.GetAll(f => f.SirketId == AppSession.Sirket.Id), "Kod", "Id");
            gleStoklar = GetCustomGLE(DataSession.StokKartService.GetAll(f => f.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleBirimler = GetCustomGLE(DataSession.StokBirimService.GetAll(f => f.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleHammaddeDurumlari = GetGLEEnum((List<EnumListesi>)typeof(HammaddeDurum).ToList2(), "Ad");
            gleDepo.Properties.Assign(gleDepolar);
            gleFirma.Properties.Assign(gleFirmalar);
            gleHammadeDurum.Properties.Assign(gleHammaddeDurumlari);
            gleFirma.Properties.View.Columns["SirketId"].Visible =
                gleFirma.Properties.View.Columns["FirmaTip"].Visible =
                gleFirma.Properties.View.Columns["FirmaKartTip"].Visible =
                gleFirma.Properties.View.Columns["VergiDairesi"].Visible =
                gleFirma.Properties.View.Columns["VergiNo"].Visible =
                gleFirma.Properties.View.Columns["KayitTarihi"].Visible =
                gleFirma.Properties.View.Columns["DegistirmeTarihi"].Visible =
                gleFirma.Properties.View.Columns["KayitUserId"].Visible =
                gleFirma.Properties.View.Columns["DegistirmeUserId"].Visible = false;
            
            gvHareket.Columns["StokId"].ColumnEdit = gleStoklar;
            gvHareket.Columns["BirimId"].ColumnEdit = gleBirimler;
        }

        private void txtStokKodu_Barkodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var _stok = DataSession.StokKartService.GetAll(f => f.Kod == txtStokKodu_Barkodu.Text || f.Barkod == txtStokKodu_Barkodu.Text).SingleOrDefault();
                if (_stok != null)
                    fis.StokHareket.Add((StokHareket)StokSec(_stok));
            }
            else
            {
                MessageBox.Show("Aradığınız Ürün Bulunamadı.");
            }
        }

        private void repoSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Kaydı Silmek İstediğinize Emin misiniz", "Silme", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gvHareket.DeleteSelectedRows();
            }
        }

        private void btnStokSec_Click(object sender, EventArgs e)
        {
            FrmStokSec stokSec = new FrmStokSec();
            stokSec.ShowDialog();
            if (stokSec.secildi)
                fis.StokHareket.Add((StokHareket)StokSec(stokSec.secilen.First()));
        }

        private void FrmStokGiris_Shown(object sender, EventArgs e)
        {
            SplashScreenManager.CloseForm();
        }

        private object StokSec(StokKarti entity)
        {
            StokHareket stokHareket = new StokHareket();
            stokHareket.StokId = entity.Id;
            stokHareket.DepoId = Convert.ToInt32(gleDepo.EditValue);
            stokHareket.DonemId = AppSession.Donem.Id;
            stokHareket.BirimId = entity.StokBirimId;
            stokHareket.KayitTarihi = DateTime.Now;
            stokHareket.KayitUserId = AppSession.CurrentUser.Id;
            stokHareket.GirisCikis = fis.FisTuru;
            stokHareket.GirisCikisMiktar = Convert.ToDouble(txtMiktari.Value);
            stokHareket.Tarih = fis.Tarih;
            return stokHareket;
        }
    }
}