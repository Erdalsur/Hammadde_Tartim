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
using Sanmark.Erp.Entities.Concrete.Stok;
using DevExpress.XtraEditors.Repository;
using Sanmark.Core.Utilities.Tipler;

namespace Sanmark.ERP.WinUI.Stoklar
{
    public partial class FrmStokKartlari : XForm
    {
        public int seciliSatir = 999999999;
        private StokKarti stokKart;
        IStokKartService _stokKartService;
        private int secilenId;
        RepositoryItemGridLookUpEdit gleSirketler, gleStokGruplari, gleBirimler, gleStokTipleri, gleUser, gleAmbalajlar;

        public FrmStokKartlari()
        {
            InitializeComponent();
            SplashScreenManager.ShowForm(typeof(FrmWait));
            _stokKartService = DataSession.StokKartService;
        }

        private void FrmStokKartlari_Load(object sender, EventArgs e)
        {
            this.Text = "Stok Kartları";
            StokKartListesi();
            
        }
        void StokKartListesi()
        {
            gleSirketler = GetCustomGLE(DataSession.SirketService.GetAll(), "Ad", "Id");
            gleStokGruplari = GetCustomGLE(DataSession.StokGrupService.GetAll(), "Ad", "Id");
            gleBirimler = GetCustomGLE(DataSession.StokBirimService.GetAll(), "Kod", "Id");
            gleStokTipleri = GetGLEEnum((List<EnumListesi>)typeof(StokTipi).ToList2(), "Ad"); 
            gleAmbalajlar= GetCustomGLE(DataSession.AmbalajService.GetAll(s => s.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gcStokKartlari.DataSource = _stokKartService.GetAll(s=>s.SirketId==AppSession.Sirket.Id).OrderBy(s=>s.Kod).ToList();
            InitGridView(gvStokKartlari);
            gvStokKartlari.SetCaptions("Id:Referans No", "SirketId:Firma", "StokGrupId:Stok Grubu", "StokBirimId:Stok Birimi", "Tip:Stok Tipi", 
                "Kod:Stok Kodu", "Ad:Stok Açıklama", "MevcutMiktar:Stok Miktarı","AmbalajId:Ambalaj Şekli");
            gvStokKartlari.MakeReadOnly();
            gvStokKartlari.YanYanaGetirSagina("MevcutMiktar", "StokBirimId");
            gvStokKartlari.YanYanaGetirSagina("Tip", "StokGrupId");
            gvStokKartlari.SetAlternateRowStyle(true);
            gvStokKartlari.MakeColumnInvisible("Id","SirketId","KayitUserId","KayitTarihi","DegistirmeUserId","DegistirmeTarihi","Birim2Id","Birim2Pay","Birim2Payda", "Birim3Id", "Birim3Pay", "Birim3Payda");
            gvStokKartlari.Columns["SirketId"].ColumnEdit = gleSirketler;
            gvStokKartlari.Columns["StokGrupId"].ColumnEdit = gleStokGruplari;
            gvStokKartlari.Columns["Birim2Id"].ColumnEdit =
                gvStokKartlari.Columns["Birim3Id"].ColumnEdit =
            gvStokKartlari.Columns["StokBirimId"].ColumnEdit = gleBirimler;
            gvStokKartlari.Columns["Tip"].ColumnEdit = gleStokTipleri;
            gvStokKartlari.Columns["AmbalajId"].ColumnEdit = gleAmbalajlar;
            gvStokKartlari.Columns["DegistirmeUserId"].ColumnEdit =
            gvStokKartlari.Columns["KayitUserId"].ColumnEdit = AppSession.MainForm.gleUser;
            gvStokKartlari.Columns["Ad"].Width=250;
            gvStokKartlari.BestFitColumns();
        }

        private void FrmStokKartlari_Shown(object sender, EventArgs e)
        {
            SplashScreenManager.CloseForm();
        }

        private void GvStokKartlari_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var handle = gvStokKartlari.GetSelectedRows()[0];
                secilenId = intParse(gvStokKartlari.GetRowCellValue(handle, "Id"));
            }
            catch
            {
                secilenId = 0;
            }
        }

        private void btnGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StokKartListesi();
        }

        private void GvStokKartlari_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gvStokKartlari.SelectRow(gvStokKartlari.FocusedRowHandle);
            gvStokKartlari.ShowEditor();
            gvStokKartlari.Appearance.FocusedCell.BackColor = Color.Transparent;
            if (seciliSatir == gvStokKartlari.FocusedRowHandle)
            {
                seciliSatir = 999999999;
                stokKart = DataSession.StokKartService.GetById(intParse(gvStokKartlari.GetRowCellValue(gvStokKartlari.FocusedRowHandle, "Id")));
                Kart_Ac(stokKart);
            }
            else { seciliSatir = gvStokKartlari.FocusedRowHandle; }
        }

        private void BbiYeniStokKart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvStokKartlari.FocusedRowHandle;
            using (FrmStokKart frmStokKart = new FrmStokKart())
            {
                frmStokKart.ShowDialog();
                if (frmStokKart.DialogResult == DialogResult.OK)
                    StokKartListesi();
                gvStokKartlari.FocusedRowHandle = handle;
            }
        }

        private void BbiStokKartAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvStokKartlari.FocusedRowHandle;
            if (handle > -1)
            {
                Kart_Ac(DataSession.StokKartService.GetById(intParse(gvStokKartlari.GetRowCellValue(gvStokKartlari.FocusedRowHandle, "Id"))));
                gvStokKartlari.FocusedRowHandle = handle;
            }
        }

        private void Kart_Ac(StokKarti stokKarti)
        {
            using (FrmStokKart frmStokKart = new FrmStokKart(stokKarti.Id))
            {
                int handle = gvStokKartlari.FocusedRowHandle;
                frmStokKart.ShowDialog();
                if (frmStokKart.DialogResult == DialogResult.OK)
                    StokKartListesi();
                gvStokKartlari.FocusedRowHandle = handle;
            }
        }

        private void BbiSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvStokKartlari.FocusedRowHandle;
            if (handle > -1)
            {
                stokKart.Id = intParse(gvStokKartlari.GetRowCellValue(handle, "Id"));
                stokKart.Ad =strParse(gvStokKartlari.GetRowCellValue(handle, "Ad"));
                stokKart.Kod = strParse(gvStokKartlari.GetRowCellValue(handle, "Kod"));
                if (XtraMessageBox.Show(String.Format("{0} Stok Kartını Simek İstiyormusunuz?", stokKart.Ad), "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                else
                {
                    _stokKartService.Delete(stokKart);
                    AppSession.MainForm.ShowInfoMessage("Silindi");
                    StokKartListesi();

                }
            }
        }
    }
}