using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Sanmark.Core.Utilities.Tipler;
using Sanmark.Erp.Entities.Concrete.Uretim;
using Sanmark.ERP.WinUI.BaseForms;
using Sanmark.ERP.WinUI.Core;
using Sanmark.ERP.WinUI.Core.Grid;
using Sanmark.ERP.WinUI.Uretim.Raporlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanmark.ERP.WinUI.Uretim
{
    public partial class FrmIsEmirleri : XForm
    {
        FormatRulesStore store;
        private ExportTool exportTool;
        public bool Expand = true;
        List<IsEmri> Listem;
        GridColumn unbColumn;
        RepositoryItemGridLookUpEdit gleDonemler, gleBirimler, gleMakinalar, gleStoklar, gleStatus, gleIsEmriTipleri;
        public FrmIsEmirleri()
        {
            InitializeComponent();
            exportTool = new ExportTool(this, gvHareket, bbiExport);
        }

        private void gcHareket_Click(object sender, EventArgs e)
        {

        }

        private void btnAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvHareket.FocusedRowHandle;
            if (handle > -1)
            {
                var id = intParse(gvHareket.GetRowCellValue(gvHareket.FocusedRowHandle, "Id"));
                //FrmIsEmri frmIsEmri = new FrmIsEmri(id);
                //frmIsEmri.so
                if (AppSession.MainForm.ShowMdiChildForm(typeof(FrmIsEmri), id).DialogResult == DialogResult.OK)
                    bbiGuncelle.PerformClick();

            }
        }

        private void gvHareket_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "colTotal" && e.IsGetData) e.Value =
              getTotalDate(view, e.ListSourceRowIndex);
        }

        private object getTotalDate(GridView view, int listSourceRowIndex)
        {
            DateTime islemBitisTarihi = Convert.ToDateTime(view.GetListSourceRowCellValue(listSourceRowIndex, "KapanisTarihi"));
            DateTime planlamaBitisTarihi = Convert.ToDateTime(view.GetListSourceRowCellValue(listSourceRowIndex, "PlananBitisTarihi"));
            if (islemBitisTarihi == Convert.ToDateTime("01.01.0001 00:00:00"))
                return "";
            var günSayisi = GunFarkikBul(islemBitisTarihi,planlamaBitisTarihi);
            if (günSayisi > 0)
                return String.Format("{0} gün geçikme var", günSayisi.ToString());
            else
                return "";
            //throw new NotImplementedException();
        }
        public int GunFarkikBul(DateTime dt1, DateTime dt2)
        {
            TimeSpan zaman = new TimeSpan(); // zaman farkını bulmak adına kullanılacak olan nesne
            zaman = dt1 - dt2;//metoda gelen 2 tarih arasındaki fark
            return Math.Abs(zaman.Days); // 2 tarih arasındaki farkın kaç gün olduğu döndürülüyor.
        }

        private void gvHareket_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {

            GridView view = sender as GridView;
            IsEmri ısEmri = view.GetRow(e.RowHandle) as IsEmri;
            if (ısEmri != null)
            {
                e.ChildList = ısEmri.IsEmriOperasyon.ToList();
                
            }
        }

        private void gvHareket_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Operasyonlar";
            
        }

        private void gvHareket_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void btnYazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvHareket.FocusedRowHandle;
            if (handle > -1)
            {
                var Tipi = intParse(gvHareket.GetRowCellValue(gvHareket.FocusedRowHandle, "IsEmriTipi"));
                if (Tipi != (int)IsEmriTipi.HammaddeTartim)
                    return;
                Cursor.Current = Cursors.WaitCursor;
                this.UseWaitCursor = true;
                xrHammadeKontrolFoyu xr = new xrHammadeKontrolFoyu();
                var UretimEmir = DataSession.IsEmirService.GetById(intParse(gvHareket.GetRowCellValue(gvHareket.FocusedRowHandle, "Id")));
                UretimEmir.IsEmriOperasyon = DataSession.IsEmirService.GetOperasyonlarAll(f=>f.IsEmriId==UretimEmir.Id);
                var StokKarti = DataSession.StokKartService.GetById(UretimEmir.StokKartiId);
                var data = DataSession.IsEmirService.HammaddeKontrolFoyuOlustur(UretimEmir.Id);
                var data2 = data.DistinctBy(a => new { a.StokKodu, a.TeorikMiktar }).ToList();
                xr.DataSource = data2;
                var Durumu = "";
                decimal toplam = 0;
                foreach (var item in data2)
                {
                    var count = DataSession.IsEmirService.TartimCarpaniBul(UretimEmir.StokKartiId, item.BirimId, UretimEmir.BirimId);
                    var Miktar = (item.ReelMiktar-item.TeorikMiktar) * count;
                    var Fark = (item.ReelMiktar - item.TeorikMiktar);
                    if (Fark != 0)
                    {
                        Durumu += String.Format("{0}-{1} Fark {2} {3}", item.StokKodu, item.Stok.Ad, Convert.ToDouble(Fark).ToString(), item.Birim);
                        Durumu += Environment.NewLine;
                    }
                    toplam += Miktar;
                }
                if (toplam!=0)
                Durumu += String.Format("Toplamda {0} {1} {2}", Convert.ToDouble(toplam).ToString(), DataSession.StokBirimService.GetById(UretimEmir.BirimId).Kod,
                    toplam > 0 ? "Üretim Fazlası" : "Üretim Eksiği");
                //Üst Bilgileri Aktarılacak
                xr.xrQRCODE.Text = UretimEmir.Id.ToString() + " - " + UretimEmir.Aciklama + " - www.sanmark.com.tr";
                xr.xrlblSeriNo.Text = UretimEmir.PartiNo;
                xr.xrlblStokKodu.Text = StokKarti.Kod;
                xr.xrlblUrunAdi.Text = StokKarti.Ad;
                
                if (UretimEmir.BaslamaTarihi != null)
                    xr.xrlblTarih.Text = UretimEmir.BaslamaTarihi.Value.ToShortDateString();
                else
                    xr.xrlblTarih.Text = UretimEmir.PlanlananBaslangicTarihi.Value.ToShortDateString();

                xr.xrlblRevizyonNo.Text = DataSession.UrunReceteService.GetById(UretimEmir.IsEmriOperasyon.FirstOrDefault().UrunReceteId).RevizyonNo.ToString();
                xr.xrlblSarjBoyu.Text = UretimEmir.Miktar.ToString() + " " + DataSession.StokBirimService.GetById(StokKarti.StokBirimId).Kod;
                xr.xrlblDurumu.Text ="Notlar :"+ Environment.NewLine+ Durumu;
                AppSession.MainForm.ShowMdiChildForm(typeof(ReportViewer), xr, AppSession.Sirket.Email + ";" + AppSession.CurrentUser.Email, "Tartim:" + UretimEmir.Aciklama + "-" + UretimEmir.Id);
                //var tool = new ReportPrintTool(xr);
                //tool.ShowPreview();
                Cursor.Current = Cursors.Default;
                this.UseWaitCursor = false;
            }
        }

        private void gvHareket_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            GridView dView = gvHareket.GetDetailView(e.RowHandle, 0) as GridView;
            //(dView);
            //InitGridView
            dView.Columns["Id"].Visible = false;
            dView.Columns["DonemId"].Visible = false;
            dView.Columns["IsEmriId"].Visible = false;
            dView.Columns["Carpan"].Visible = false;
            dView.Columns["FireMiktari"].Visible = false;
            dView.Columns["MakinaId"].Visible = false;
            dView.Columns["SiraNo"].Visible = false;
            dView.Columns["FisId"].Visible = false;
            dView.Columns["FisSatirId"].Visible = false;
            dView.Columns["KayitTarihi"].Visible = false;
            dView.Columns["KayitUserId"].Visible = false;
            dView.Columns["DegistirmeUserId"].Visible = false;
            dView.Columns["DegistirmeTarihi"].Visible = false;
            dView.Columns["IsEmri"].Visible = false;
            dView.Columns["Donem"].Visible = false;
            dView.Columns["StokKarti"].Visible = false;
            dView.Columns["Makina"].Visible = false;
            dView.Columns["StokBirim"].Visible = false;
            dView.Columns["UrunRecete"].Visible = false;
            dView.Columns["UrunReceteDetay"].Visible = false;
            dView.Columns["UrunReceteId"].Visible = false;
            dView.Columns["UrunReceteDetayId"].Visible = false;
            dView.Columns["IsEmriOperasyonIslem"].Visible = false;
            dView.Columns["StokKartiId"].ColumnEdit = gleStoklar;
            dView.Columns["BirimId"].ColumnEdit = gleBirimler;
            dView.Columns["GenelDurum"].ColumnEdit = gleStatus;
            dView.OptionsView.EnableAppearanceOddRow = true;
            dView.MakeReadOnly();
            dView.BestFitColumns();
        }

        private void bbiExpand_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExpandAllRows(gvHareket,Expand);
        }
        public void ExpandAllRows(GridView View, bool durum)
        {
            View.BeginUpdate();
            try
            {
                int dataRowCount = View.DataRowCount;
                for (int rHandle = 0; rHandle < dataRowCount; rHandle++)
                    View.SetMasterRowExpanded(rHandle, durum);
            }
            finally
            {
                Expand = durum ? false : true;
                bbiExpand.Caption = durum ? "Tüm Detaylari Gizle" : "Tüm Detaylari Gör";
                View.EndUpdate();
            }
        }

        private void FrmIsEmirleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            GridViewAyarKaydet();
        }
        public void GridViewAyarKaydet()
        {
            bool Kontrol = Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"Settings\");
            if (!Kontrol)
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"Settings\");

            store.FormatRules = gvHareket.FormatRules;
            store.Save(AppDomain.CurrentDomain.BaseDirectory + @"Settings\TartimEmirleri.xml");

        }

        private void FrmIsEmirleri_Load(object sender, EventArgs e)
        {
            EmirListesi();
            store = new FormatRulesStore();
            gvHareket.OptionsMenu.ShowConditionalFormattingItem = true;
            store.FormatRules = gvHareket.FormatRules;

            try
            {
                store.Restore(AppDomain.CurrentDomain.BaseDirectory + @"Settings\TartimEmirleri.xml");
                foreach (var item in store.FormatRules)
                    gvHareket.FormatRules.Add(item);

                //gvHareket.RestoreLayoutFromXml(AppDomain.CurrentDomain.BaseDirectory + @"Settings\StokHareket2.xml");
            }
            catch { }

        }
        private void GleDoldur()
        {
            gleStatus = GetGLEEnum((List<EnumListesi>)typeof(Status).ToList2(), "Ad");
            gleIsEmriTipleri = GetGLEEnum((List<EnumListesi>)typeof(IsEmriTipi).ToList2(), "Ad");
            gleDonemler = GetCustomGLE(DataSession.DonemService.GetAll(f => f.SirketId == AppSession.Sirket.Id), "Yil", "Id");
            gleBirimler = GetCustomGLE(DataSession.StokBirimService.GetAll(f => f.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleMakinalar = GetCustomGLE(DataSession.UretimService.GetMakinalar(f => f.SirketId == AppSession.Sirket.Id && f.DonemId == AppSession.Donem.Id), "MakinaAdi", "Id");
            gleStoklar = GetCustomGLE(DataSession.StokKartService.GetAll(f => f.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            
            gvHareket.Columns["StokKartiId"].ColumnEdit = gleStoklar;
            
            gvHareket.Columns["BirimId"].ColumnEdit = gleBirimler;
            gvHareket.Columns["DonemId"].ColumnEdit = gleDonemler;
            gvHareket.Columns["MakinaId"].ColumnEdit = gleMakinalar;
            
            gvHareket.Columns["GenelDurumu"].ColumnEdit = gleStatus;
            gvHareket.Columns["IsEmriTipi"].ColumnEdit = gleIsEmriTipleri;


        }

        private void EmirListesi()
        {
            Listem= DataSession.IsEmirService.GetAll();
            gcHareket.DataSource = Listem;
            //unbColumn = gvHareket.Columns.AddField("Total");
            //// Disable editing.
            //unbColumn.OptionsColumn.AllowEdit = false;
            //// Specify format settings.
            //gvHareket.MakeColumnVisible(unbColumn);
            //gvHareket.AddColumn("Adet", "");
            GleDoldur();
            gvHareket.OptionsView.EnableAppearanceOddRow = true;
        }

        private void bbiYeniIsEmri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppSession.MainForm.ShowMdiChildForm(typeof(FrmIsEmri));
            EmirListesi();

        }

        private void bbiGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvHareket.FocusedRowHandle;
            EmirListesi();
            ExpandAllRows(gvHareket, false);
            gvHareket.FocusedRowHandle = handle;
        }
    }
}
