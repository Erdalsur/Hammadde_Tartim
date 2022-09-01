using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Sanmark.Erp.Entities.Concrete.Stok;
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
    public partial class FrmUrunAgaci : XPopupForm
    {
        UrunAgaclari urunAgaci;
        BindingList<UrunAgacSatirlari> _urunAgacSatirlaris;
        public FrmUrunAgaci()
        {
            InitializeComponent();
            urunAgaci = new UrunAgaclari();
            urunAgaci.UrunAgacSatirlari = new BindingList<UrunAgacSatirlari>();
            this.Text = "Yeni Reçete";
        }

        public FrmUrunAgaci(int ReceteId)
        {
            InitializeComponent();
            urunAgaci = DataSession.UrunAgaciService.GetById(ReceteId);
            //urunAgaci.UrunAgacSatirlari = new BindingList<UrunAgacSatirlari>();
            txtAd.Text = urunAgaci.Aciklama;
            txtKod.Text = urunAgaci.Kod;
            gleGrup.EditValue = urunAgaci.StokId;
            gleMakina.EditValue = urunAgaci.MakinaId;
            urunAgaci.UrunAgacSatirlari = new BindingList<UrunAgacSatirlari>(urunAgaci.UrunAgacSatirlari.ToList());
            this.Text =urunAgaci.Kod +" Kodlu Reçete";
        }

        private void FrmUrunAgaci_Load(object sender, EventArgs e)
        {
            Ayarlamalar();

        }

        private void Ayarlamalar()
        {
            RepositoryItemGridLookUpEdit gleGruplar = GetCustomGLE(
                            DataSession.StokKartService.GetAll(
                                g => g.SirketId == AppSession.Sirket.Id).Select(s => new { Id = s.Id, Kod = s.Kod, Ad = s.Ad }).ToList(), "Ad", "Id");
            gleGruplar.View.OptionsView.ColumnAutoWidth = true;
            gleGrup.Properties.Assign(gleGruplar);
            gleGrup.Properties.View.BestFitColumns();
            RepositoryItemGridLookUpEdit gleMakinalar = GetCustomGLE(
                            DataSession.UretimService.GetMakinalar(
                                g => g.SirketId == AppSession.Sirket.Id).Select(s => new { Id = s.Id, Ad = s.MakinaAdi }).ToList(), "Ad", "Id");
            gleMakinalar.View.OptionsView.ColumnAutoWidth = true;
            gleMakina.Properties.Assign(gleMakinalar);
            gleMakina.Properties.View.BestFitColumns();

            gcUrunAgaclari.DataSource = urunAgaci.UrunAgacSatirlari;
            GridColumn colCounter = gvUrunAgaclari.Columns.AddVisible("RowHandle");
            colCounter.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            //colCounter.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;

            gvUrunAgaclari.CustomUnboundColumnData += (sender, e) =>
            {
                GridView view = sender as GridView;
                if (e.Column.FieldName == "RowHandle" && e.IsGetData)
                    e.Value = view.GetRowHandle(e.ListSourceRowIndex) + 1;
            };
            InitGridView(gvUrunAgaclari);
            gvUrunAgaclari.YanYanaGetirSoluna("Id", "RowHandle");
            gvUrunAgaclari.SetAlternateRowStyle(true);
            gvUrunAgaclari.EnableNewRow();
            gvUrunAgaclari.Columns["UrunId"].ColumnEdit = gleGruplar;
            gvUrunAgaclari.Columns["DegistirmeUserId"].ColumnEdit =
            gvUrunAgaclari.Columns["KayitUserId"].ColumnEdit = AppSession.MainForm.gleUser;
            gvUrunAgaclari.MakeColumnInvisible("Id","UrunAgacId","Urun","UrunAgac");
            gvUrunAgaclari.SetCaptions("RowHandle:Sıra No", "UrunId:Stok Adı");
            //gvUrunAgaclari.Columns["UrunId"]
            //gvUrunAgaclari.MakeReadOnly("KayitTarihi","KayitUserId","DegistirmeTarihi","DegistirmeUserId");
            gvUrunAgaclari.BestFitColumns();
        }

        private void FrmUrunAgaci_Shown(object sender, EventArgs e)
        {

        }

        private void gvUrunAgaclari_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["UrunAgacId"], urunAgaci.Id);
            if (view.GetRowCellValue(e.RowHandle, view.Columns["UrunId"]) != "")
            {
                view.SetRowCellValue(e.RowHandle, view.Columns["Urun"], DataSession.StokKartService.GetById((int)(view.GetRowCellValue(e.RowHandle, view.Columns["UrunId"]))));
                view.SetRowCellValue(e.RowHandle, view.Columns["KayitUserId"], AppSession.CurrentUser.Id);
                view.SetRowCellValue(e.RowHandle, view.Columns["KayitTarihi"], DateTime.Now);
                view.SetRowCellValue(e.RowHandle, view.Columns["DegistirmeUserId"], AppSession.CurrentUser.Id);
                view.SetRowCellValue(e.RowHandle, view.Columns["DegistirmeTarihi"], DateTime.Now);
            }
        }

        private void bbiKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (urunAgaci.Id > 0)
                if (XtraMessageBox.Show(String.Format("{0} Kodlu Reçetede Revizyon Kayıt Edilsin mi?", txtKod.Text), "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            urunAgaci.Kod = txtKod.Text.Trim();
            urunAgaci.SirketId = AppSession.Sirket.Id;
            urunAgaci.Aciklama = txtAd.Text.Trim();
            urunAgaci.StokId = intParse(gleGrup.EditValue);
            //urunAgaci.Stok = DataSession.StokKartService.GetById(intParse(gleGrup.EditValue));
            urunAgaci.RevizyonTarihi = DateTime.Now;
            urunAgaci.RevizyonNo = DataSession.UrunAgaciService.GetAll(s => s.StokId == urunAgaci.StokId).ToList().Count;
            DataSession.UrunAgaciService.Add(urunAgaci);
            //var test = urunAgaci.UrunAgacSatirlari.ToList();
            this.DialogResult = DialogResult.OK;

        }

        private void gvUrunAgaclari_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control) {
                GridView view = sender as GridView;
                var Aciklama = "";
                var deger = intParse(gvUrunAgaclari.GetRowCellValue(view.FocusedRowHandle, "UrunId"));
                if ( deger== 0)
                    Aciklama = "Silmek İstiyormusunuz?";
                else
                    Aciklama = DataSession.StokKartService.GetById(intParse(gvUrunAgaclari.GetRowCellValue(view.FocusedRowHandle, "UrunId"))).Ad.ToString() + " Ürününü Silmek İstiyormusunuz?";
                if (MessageBox.Show(Aciklama, "Silme", MessageBoxButtons.YesNo) !=
                  DialogResult.Yes)
                    return;
                
                view.DeleteRow(view.FocusedRowHandle);
            }
        }

        private void gvUrunAgaclari_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //GridView view = sender as GridView;
            ////view.SetRowCellValue(e.RowHandle, view.Columns["UrunAgacId"], urunAgaci.Id);
            //if (view.GetRowCellValue(e.RowHandle, view.Columns["UrunId"]) != "")
            //{
            //    //view.SetRowCellValue(e.RowHandle, view.Columns["Urun"], DataSession.StokKartService.GetById((int)(view.GetRowCellValue(e.RowHandle, view.Columns["UrunId"]))));
            //    view.SetRowCellValue(e.RowHandle, view.Columns["DegistirmeUserId"], AppSession.CurrentUser.Id);
            //    view.SetRowCellValue(e.RowHandle, view.Columns["DegistirmeTarihi"], DateTime.Now);
            //}
        }

        private void gvUrunAgaclari_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            GridView view = sender as GridView;
            ////view.SetRowCellValue(e.RowHandle, view.Columns["UrunAgacId"], urunAgaci.Id);
            //if (view.GetRowCellValue(e.RowHandle, view.Columns["UrunId"]) != "")
            //{
            //    //view.SetRowCellValue(e.RowHandle, view.Columns["Urun"], DataSession.StokKartService.GetById((int)(view.GetRowCellValue(e.RowHandle, view.Columns["UrunId"]))));
                view.SetRowCellValue(e.RowHandle, view.Columns["DegistirmeUserId"], AppSession.CurrentUser.Id);
                view.SetRowCellValue(e.RowHandle, view.Columns["DegistirmeTarihi"], DateTime.Now);
            //}
        }
    }
}
