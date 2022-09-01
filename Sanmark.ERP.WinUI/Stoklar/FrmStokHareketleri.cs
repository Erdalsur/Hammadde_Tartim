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
using Sanmark.Erp.Framework.Abstract;
using Sanmark.ERP.WinUI.Core.Grid;
using DevExpress.XtraEditors.Repository;
using Sanmark.Core.Utilities.Tipler;
using System.Collections;
using Sanmark.Erp.Entities.ComplexTypes.Uretim;
using System.IO;

namespace Sanmark.ERP.WinUI.Stoklar
{
    public partial class FrmStokHareketleri : XForm
    {
        FormatRulesStore store;
        IStokHareketService _stokHareketService;
        RepositoryItemGridLookUpEdit gleSirket, gleDonem, gleDepo, gleGirisCikis, gleStok, gleHareketTuru, gleStokTipi, glestokBirimi,gleAnalizSertifika;

        private void FrmStokHareketleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            GridViewAyarKaydet();
        }
        public void GridViewAyarKaydet()
        {
            bool Kontrol = Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"Settings\");
            if (!Kontrol)
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"Settings\");
            
            store.FormatRules = gvHareket.FormatRules;
            store.Save(AppDomain.CurrentDomain.BaseDirectory + @"Settings\StokHareket.xml");

            //gvHareket.SaveLayoutToXml(AppDomain.CurrentDomain.BaseDirectory + @"Settings\StokHareket2.xml");
        }
        private void btnAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvHareket.GetSelectedRows().Length != 0)
            {
                foreach (var row in gvHareket.GetSelectedRows())
                {
                    int _id = intParse(gvHareket.GetRowCellValue(row, "Id").ToString());
                    var secilen = DataSession.StokHareketService.GetById(_id);
                    if (secilen.GirisCikis == ((int)StokGirisCikis.Giris).ToString())//secilen.HareketTuru == ((int)HareketTuru.GirisFisi).ToString() && 
                        AppSession.MainForm.ShowMdiChildForm(typeof(FrmStokGiris), StokGirisCikis.Giris, secilen.FisId);

                    if ( secilen.GirisCikis == ((int)StokGirisCikis.Cikis).ToString())//secilen.HareketTuru == ((int)HareketTuru.GirisFisi).ToString() &&
                        AppSession.MainForm.ShowMdiChildForm(typeof(FrmStokGiris), StokGirisCikis.Cikis, secilen.FisId);
                }
            }
            else
            {
                MessageBox.Show("Seçilen bir ürün bulunamadı");
            }
        }

        private void btnGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TabloOlustur();
        }

        public FrmStokHareketleri()
        {
            InitializeComponent();
            SplashScreenManager.ShowForm(typeof(FrmWait));
            _stokHareketService = DataSession.StokHareketService;
        }

        private void FrmStokHareketleri_Load(object sender, EventArgs e)
        {
            store = new FormatRulesStore();
            TabloOlustur();
            gvHareket.OptionsMenu.ShowConditionalFormattingItem = true;
            store.FormatRules = gvHareket.FormatRules;

            try
            {
                store.Restore(AppDomain.CurrentDomain.BaseDirectory + @"Settings\StokHareket.xml");
                foreach (var item in store.FormatRules)
                    gvHareket.FormatRules.Add(item);
                
                //gvHareket.RestoreLayoutFromXml(AppDomain.CurrentDomain.BaseDirectory + @"Settings\StokHareket2.xml");
            }
            catch { }
        }


        private void TabloOlustur()
        {
            var hareketler = DataSession.StokHareketService.StokHareketListesi(h => h.SirketId == AppSession.Sirket.Id).OrderByDescending(f => f.Id);
            if (hareketler.Count() == 0)
            {
                gcHareket.DataSource = new List<StokHareketListe>();
            }
            else
                gcHareket.DataSource = hareketler;
            //            gcHareket.DataSource = _stokHareketService.GetAll(h => h.SirketId == AppSession.Sirket.Id);
            gleSirket = GetCustomGLE(DataSession.SirketService.GetAll(), "Ad", "Id");
            glestokBirimi = GetCustomGLE(DataSession.StokBirimService.GetAll(), "Ad", "Id");
            gleDonem = GetCustomGLE(DataSession.DonemService.GetAll(), "Yil", "Id");
            gleDepo = GetCustomGLE(DataSession.DepoService.GetAll(), "Ad", "Id");
            gleStok = GetCustomGLE(DataSession.StokKartService.GetAll(), "Ad", "Id");
            var stokGirisCikis = (List<EnumListesi>)typeof(StokGirisCikis).ToList2();
            gleGirisCikis = GetGLEEnum(stokGirisCikis, "Ad");
            var hareketTuru = (List<EnumListesi>)typeof(HareketTuru).ToList2();

            gleHareketTuru = GetGLEEnum(hareketTuru, "Ad");
            var analizSertifikaTip = (List<EnumListesi>)typeof(AnalizSerifikası).ToList2();
            gleAnalizSertifika = GetGLEEnum(analizSertifikaTip, "Ad");
            gleStokTipi = GetGLEEnum((List<EnumListesi>)typeof(StokTipi).ToList2(), "Ad");
            InitGridView(gvHareket);
            gvHareket.SetCaptions("Id:Referans No", "SirketId:Firma", "DonemId:Dönemi", "DepoId:Deposu", "StokId:Ürün Adı", "FisNo:Fiş No",
                "Tarih:Tarih", "GirisCikis:Giriş/Çıkış", "HareketTuru:HareketNereden",
                "KaliteKontrolNo:K.K.No", "BaglantiId:Referans Formu", "BaglantiSatirId:Referans Formu Satırı",
                "KayitTarihi:Kayıt Tarihi", "DegistirmeTarihi:Değiştirme Tarihi", "KayitUserId:Kayıt Eden", "DegistirmeUserId:Değiştiren");
            gvHareket.SetAlternateRowStyle(true);
            gvHareket.Columns["AnalizSertifikasiGeldimi"].ColumnEdit = gleAnalizSertifika;
            gvHareket.Columns["SirketId"].ColumnEdit = gleSirket;
            gvHareket.Columns["DepoId"].ColumnEdit = gleDepo;
            gvHareket.Columns["DonemId"].ColumnEdit = gleDonem;
            gvHareket.Columns["StokId"].ColumnEdit = gleStok;
            gvHareket.Columns["StokTipi"].ColumnEdit = gleStokTipi;
            gvHareket.Columns["GirisCikis"].ColumnEdit = gleGirisCikis;
            gvHareket.Columns["HareketTuru"].ColumnEdit = gleHareketTuru;
            gvHareket.Columns["StokAnaBirimi"].ColumnEdit =
            gvHareket.Columns["StokBirimi"].ColumnEdit = glestokBirimi;
            
            gvHareket.Columns["DegistirmeUserId"].ColumnEdit =
            gvHareket.Columns["KayitUserId"].ColumnEdit = AppSession.MainForm.gleUser;

            gvHareket.FormatAsNumber(6, "StokGirisMiktari", "StokCikisMiktari", "StokBakiyesi");
            gvHareket.MakeReadOnly();
            gvHareket.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            gvHareket.YanYanaGetir("FisNo:SirketId", "KayitTarihi:KayitUserId", "DegistirmeTarihi:DegistirmeUserId");
            gvHareket.MakeColumnInvisible("Id","FisId", "StokAdi", "SirketId", "DonemId", "BaglantiId", "BaglantiSatirId", "KayitTarihi", "KayitUserId", "DegistirmeTarihi", "DegistirmeUserId");
            //gvHareket.Columns.Add("Kalan", typeof(decimal), "(isnull(GirisCikisMiktar)-isnull(GirisCikisMiktar2))");
            gvHareket.BestFitColumns();
        }

        private void FrmStokHareketleri_Shown(object sender, EventArgs e)
        {
            SplashScreenManager.CloseForm();
            gvHareket.BestFitColumns();
        } 
    }
}