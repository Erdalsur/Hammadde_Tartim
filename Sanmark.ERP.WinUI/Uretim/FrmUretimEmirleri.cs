using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using Sanmark.Core.Utilities.Tipler;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Entities.Concrete.Uretim;
using Sanmark.Erp.Framework.Abstract;
using Sanmark.ERP.WinUI.BaseForms;
using Sanmark.ERP.WinUI.Core;
using Sanmark.ERP.WinUI.Core.Grid;
using Sanmark.ERP.WinUI.Uretim.Raporlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanmark.ERP.WinUI.Uretim
{
    public partial class FrmUretimEmirleri : XForm
    {
        IUretimService uretimService;
        RepositoryItemGridLookUpEdit gleSirket, gleStokKart, gleMakina, gleStatus;
        private ExportTool exportTool;

        public FrmUretimEmirleri()
        {
            InitializeComponent();
            SplashScreenManager.ShowForm(typeof(FrmWait));
            uretimService = DataSession.UretimService;
            gleSirket = GetCustomGLE(DataSession.SirketService.GetAll(), "Ad", "Id");
            gleStokKart = GetCustomGLE(
                            DataSession.StokKartService.GetAll(g => g.SirketId == AppSession.Sirket.Id).Select(s => new { Id = s.Id, Kod = s.Kod, Ad = s.Ad }).ToList(), "Ad", "Id");
            gleMakina = GetCustomGLE(
                DataSession.UretimService.GetMakinalar(g => g.DonemId == AppSession.Donem.Id).Select(s => new { Id = s.Id, MakinaAdi = s.MakinaAdi }).ToList(), "MakinaAdi", "Id");
            gleStatus = GetGLEEnum((List<EnumListesi>)typeof(Status).ToList2(), "Ad");
            exportTool = new ExportTool(this, gvUretimEmirleri, barButtonItem1);
        }

        private void FrmUretimEmirleri_Shown(object sender, EventArgs e)
        {
            SplashScreenManager.CloseForm();
            //PrepareImageComboBoxEdit(gvUretimEmirleri, "Durumu");
        }

        private void PrepareImageComboBoxEdit(GridView gv, string colName)
        {
            RepositoryItemImageComboBox imageCombo = gv.GridControl.RepositoryItems.Add("ImageComboBoxEdit") as RepositoryItemImageComboBox;
            imageCombo.Items.BeginUpdate();
            int ndx = 0;
            imageCombo.SmallImages = noktalar;
            foreach (string opt in "Yeni Kayıt|Yeni Kayıt - Otomatik|Hazırlanıyor|Tamamlandı|Eksik Üretim - Otomatik|Üretim Değişikliği - Otomatik".Split('|'))
                imageCombo.Items.Add(new ImageComboBoxItem(opt, ndx++));
            //imageCombo.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            imageCombo.Items.EndUpdate();
            gv.Columns[colName].ColumnEdit = imageCombo;
        }

        private void bbiDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvUretimEmirleri.FocusedRowHandle;
            if (handle > -1)
            {
                Kart_Ac(intParse(gvUretimEmirleri.GetRowCellValue(gvUretimEmirleri.FocusedRowHandle, "Id")));
                gvUretimEmirleri.FocusedRowHandle = handle;
            }
        }

        private void Kart_Ac(int UretimEmirId)
        {
            using (FrmUretimEmir frmUretimEmir = new FrmUretimEmir(UretimEmirId))
            {
                frmUretimEmir.ShowDialog();
                if (frmUretimEmir.DialogResult == DialogResult.OK)
                    UretimEmirListesi();
            }
        }

        private void bbiUretimBaslat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvUretimEmirleri.FocusedRowHandle;
            if (handle > -1)
            {
                var UretimEmri = DataSession.UretimService.GetById(intParse(gvUretimEmirleri.GetRowCellValue(gvUretimEmirleri.FocusedRowHandle, "Id")));
                DataSession.UretimService.UretimBaslat(UretimEmri);
                UretimEmirListesi();
                gvUretimEmirleri.FocusedRowHandle = handle;
                //Üretim Ekranını aç
                AppSession.MainForm.ShowMdiChildForm(typeof(FrmUretim), UretimEmri.Id);
            }
        }

        private void gvUretimEmirleri_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView gvE = (GridView)sender;
            e.Appearance.BorderColor = Color.White; // gvE.GetRowCellDisplayText(e.RowHandle, "DosyaNo") != string.Empty ? Color.Gray : Color.White;
            //e.Appearance.ForeColor = gvE.GetRowCellDisplayText(e.RowHandle, "Durumu") == "Yeni Kayıt" ? Color.Crimson : Color.Black;
            e.Appearance.BackColor = gvE.GetRowCellDisplayText(e.RowHandle, "Durumu") == "Tamamlandı" ? Color.LightGray : Color.White;   //Beige?
        }

        private void bbiFoyYazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvUretimEmirleri.FocusedRowHandle;
            if (handle > -1)
            {
                Cursor.Current = Cursors.WaitCursor;
                this.UseWaitCursor = true;
                xrHammadeKontrolFoyu xr = new xrHammadeKontrolFoyu();
                var UretimEmir = DataSession.UretimService.GetById(intParse(gvUretimEmirleri.GetRowCellValue(gvUretimEmirleri.FocusedRowHandle, "Id")));
                var StokKarti = DataSession.StokKartService.GetById(UretimEmir.UrunId);
                var data = DataSession.UretimService.HammaddeKontrolFoyuOlustur(UretimEmir.Id);
                var data2 = data.DistinctBy(a => new { a.StokKodu, a.TeorikMiktar }).ToList();
                xr.DataSource = data2;

                //Üst Bilgileri Aktarılacak
                xr.xrQRCODE.Text = UretimEmir.Id.ToString() + " - " + UretimEmir.Aciklama + " - www.sanmark.com.tr";
                xr.xrlblSeriNo.Text = UretimEmir.SeriNo;
                xr.xrlblStokKodu.Text = StokKarti.Kod;
                xr.xrlblUrunAdi.Text = StokKarti.Ad;
                xr.xrlblTarih.Text = UretimEmir.Tarih.Value.ToShortDateString();
                xr.xrlblRevizyonNo.Text = UretimEmir.AltUretimId == 0 ? "0" : DataSession.UrunAgaciService.GetById(UretimEmir.AltUretimId).RevizyonNo.ToString();
                xr.xrlblSarjBoyu.Text = UretimEmir.Miktar.ToString() + " " + DataSession.StokBirimService.GetById(StokKarti.StokBirimId).Kod;
                AppSession.MainForm.ShowMdiChildForm(typeof(ReportViewer), xr, AppSession.Sirket.Email+";"+AppSession.CurrentUser.Email, "Tartim:" + UretimEmir.Aciklama+"-"+UretimEmir.Id);
                //var tool = new ReportPrintTool(xr);
                //tool.ShowPreview();
                Cursor.Current = Cursors.Default;
                this.UseWaitCursor = false;
            }
        }

        private void bbiBitir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvUretimEmirleri.FocusedRowHandle;
            if (handle > -1)
            {
                var UretimEmri = DataSession.UretimService.GetById(intParse(gvUretimEmirleri.GetRowCellValue(gvUretimEmirleri.FocusedRowHandle, "Id")));
                if (UretimEmri.UretimBitisTarihi != null)
                {
                    if (XtraMessageBox.Show(String.Format("Üretim {0} tarihinde bitirilmiş. Değiştirmek İstiyormusunuz?", UretimEmri.UretimBitisTarihi.ToDate()), "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                }

                DataSession.UretimService.UretimBitir(UretimEmri);
                UretimEmirListesi();
                gvUretimEmirleri.FocusedRowHandle = handle;
            }
        }

        

        private void UretimEmirListesi()
        {
            gcUretimEmirleri.DataSource = uretimService.GetAll(u => u.DonemId == AppSession.Donem.Id && u.MakinaId == 1)
            .OrderBy(s => s.Durumu).OrderBy(s => s.UretimBaslangicTarihi).ToList();
            InitGridView(gvUretimEmirleri);
            gvUretimEmirleri.MakeReadOnly();
            gvUretimEmirleri.Columns["UrunId"].ColumnEdit = gleStokKart;
            gvUretimEmirleri.Columns["MakinaId"].ColumnEdit = gleMakina;
            gvUretimEmirleri.Columns["Durumu"].ColumnEdit = gleStatus;
            gvUretimEmirleri.Columns["DegistirmeUserId"].ColumnEdit =
            gvUretimEmirleri.Columns["KayitUserId"].ColumnEdit = AppSession.MainForm.gleUser;
            gvUretimEmirleri.MakeColumnInvisible("Id", "DonemId", "Urun", "Donem", "Makina", "AltUretimId", "UstUretimId", "UretimEmirDetaylari", "UretimTipi");
            gvUretimEmirleri.BestFitColumns();
        }

        private void bbiYeniUretimEmir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvUretimEmirleri.FocusedRowHandle;
            using (FrmUretimEmir frmUretimEmir = new FrmUretimEmir())
            {
                frmUretimEmir.ShowDialog();
                if (frmUretimEmir.DialogResult == DialogResult.OK)
                    UretimEmirListesi();
                gvUretimEmirleri.FocusedRowHandle = handle;
            }
        }

        private void FrmUretimEmirleri_Load(object sender, EventArgs e)
        {
            this.Text = "Üretim Emirleri";
            UretimEmirListesi();
        }
    }
}
