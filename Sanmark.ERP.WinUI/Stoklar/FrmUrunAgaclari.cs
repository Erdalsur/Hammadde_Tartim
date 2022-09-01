using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Framework.Abstract;
using Sanmark.ERP.WinUI.BaseForms;
using Sanmark.ERP.WinUI.Core.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanmark.ERP.WinUI.Stoklar
{
    public partial class FrmUrunAgaclari : XForm
    {
        IUrunReceteService urunAgaciService;
        RepositoryItemGridLookUpEdit gleSirket, gleStokKart, gleBirimler, gleMakinalar,gleDepolar;
        public FrmUrunAgaclari()
        {
            InitializeComponent();
            SplashScreenManager.ShowForm(typeof(FrmWait));
            urunAgaciService = DataSession.UrunReceteService;
            gleSirket = GetCustomGLE(DataSession.SirketService.GetAll(), "Ad", "Id");
        }

        private void FrmUrunAgaclari_Load(object sender, EventArgs e)
        {
            this.Text = "Ürün Reçeteleri";
            ReceteKartListesi();
        }

        private void FrmUrunAgaclari_Shown(object sender, EventArgs e)
        {
            SplashScreenManager.CloseForm();
        }

        private void bbiYeniStokKart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvUrunAgaclari.FocusedRowHandle;
            using (FrmUrunRecete frmStokKart = new FrmUrunRecete())
            {
                frmStokKart.ShowDialog();
                if (frmStokKart.DialogResult == DialogResult.OK)
                {
                    ReceteKartListesi();
                    gvUrunAgaclari.FocusedRowHandle = handle;
                }
            }
        }

        private void bbiStokKartAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvUrunAgaclari.FocusedRowHandle;
            if (handle > -1)
            {
                if (boolParse(gvUrunAgaclari.GetRowCellValue(gvUrunAgaclari.FocusedRowHandle, "IsActive")) == true)
                {
                    Kart_Ac(intParse(gvUrunAgaclari.GetRowCellValue(gvUrunAgaclari.FocusedRowHandle, "Id")));
                    gvUrunAgaclari.FocusedRowHandle = handle;
                }
                else
                {
                    Kart_Ac(intParse(gvUrunAgaclari.GetRowCellValue(gvUrunAgaclari.FocusedRowHandle, "Id")),true);
                    gvUrunAgaclari.FocusedRowHandle = handle;
                    //AppSession.MainForm.ShowErrorMessage("Reçete değiştirilmiş olduğunda göremezsiniz.");
                    //return;
                }

            }
        }

        private void btnGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReceteKartListesi();
        }

        private void gcUrunAgaclari_Click(object sender, EventArgs e)
        {

        }

        private void Kart_Ac(int v,bool durum=false)
        {
            using (FrmUrunRecete frmReceteKart = new FrmUrunRecete(v,durum))
            {
                frmReceteKart.ShowDialog();
                if (frmReceteKart.DialogResult == DialogResult.OK)
                    ReceteKartListesi();

            }
        }

        private void bbiSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ReceteKartListesi()
        {
            gcUrunAgaclari.DataSource = urunAgaciService.GetAll(s => s.SirketId == AppSession.Sirket.Id).OrderBy(s => s.ReceteKodu).OrderByDescending(b => b.RevizyonNo).ToList();
            //GridColumn colCounter = gvUrunAgaclari.Columns.AddVisible("RowHandle");
            //colCounter.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            ////colCounter.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            //gvUrunAgaclari.CustomUnboundColumnData += (sender, e) =>
            //{
            //    GridView view = sender as GridView;
            //    if (e.Column.FieldName == "RowHandle" && e.IsGetData)
            //        e.Value = view.GetRowHandle(e.ListSourceRowIndex) + 1;
            //};            
            gleStokKart = GetCustomGLE(DataSession.StokKartService.GetAll(s => s.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleBirimler = GetCustomGLE(DataSession.StokBirimService.GetAll(s => s.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleMakinalar = GetCustomGLE(DataSession.UretimService.GetMakinalar(s => s.SirketId == AppSession.Sirket.Id && s.DonemId == AppSession.Donem.Id), "MakinaAdi", "Id");
            gleDepolar = GetCustomGLE(DataSession.DepoService.GetAll(s=>s.SirketId==AppSession.Sirket.Id),"Ad","Id");
            //InitGridView(gvUrunAgaclari);
            //gvUrunAgaclari.YanYanaGetirSoluna("Id", "RowHandle");
            gvUrunAgaclari.SetAlternateRowStyle(true);
            gvUrunAgaclari.Columns["SirketId"].ColumnEdit = gleSirket;
            gvUrunAgaclari.Columns["StokId"].ColumnEdit = gleStokKart;
            gvUrunAgaclari.Columns["BirimId"].ColumnEdit = gleBirimler;
            gvUrunAgaclari.Columns["MakinaId"].ColumnEdit = gleMakinalar;
            gvUrunAgaclari.Columns["DepoId"].ColumnEdit = gleDepolar;
            gvUrunAgaclari.MakeColumnInvisible("SirketId", "Stok", "Sirket", "UrunAgacSatirlari", "Carpan", "Id");
            gvUrunAgaclari.SetCaptions("RowHandle:Sıra No", "StokId:Stok Adı", "Kod:Reçete Kodu", "Aciklama:Reçete Açıklaması", "RevizyonNo:Revizyon No", "RevizyonTarihi:Revizyon Tarihi");
            gvUrunAgaclari.Columns["DegistirmeUserId"].ColumnEdit =
            gvUrunAgaclari.Columns["KayitUserId"].ColumnEdit = AppSession.MainForm.gleUser;
            gvUrunAgaclari.MakeReadOnly();
            
            gvUrunAgaclari.BestFitColumns();
        }
    }
}
