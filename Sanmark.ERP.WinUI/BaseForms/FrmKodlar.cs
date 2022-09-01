using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Sanmark.Erp.Entities.Concrete;
using Sanmark.ERP.WinUI.Core.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanmark.ERP.WinUI.BaseForms
{
    public partial class FrmKodlar : XPopupForm
    {
        BindingList<Kod> _kodlar;
        private Kod kod;
        private string _tablo;
        public FrmKodlar(string tablo)
        {
            InitializeComponent();
            _tablo = tablo;
            _kodlar = new BindingList<Kod>(DataSession.KodService.GetAll(f => f.Tablo == _tablo));
            gcData.DataSource = _kodlar;
            //gvData.PopulateColumns();
            //InitGridView(gvData);
            gvData.EnableNewRowTop();
            //gvData.MakeColumnInvisible("Id", "SirketId", "KayitUserId", "KayitTarihi", "DegistirmeUserId", "DegistirmeTarihi");
        }

        private void FrmKodlar_Load(object sender, EventArgs e)
        {

        }

        private void bbiKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gvData.EndEditing();
                DataSession.KodService.SaveAll(_kodlar);
                this.Close();
            }
            catch (ValidationException ex)
            {
                XtraMessageBox.Show("Kod Nesne Hatası.\r\n\r\n Hata: " + ex.Message.Replace("Validation failed: \r\n", ""), "Validasyon Hatası");
                //view.RefreshData();
            }
        }

        private void gvData_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gvData.FocusedRowHandle != GridControl.NewItemRowHandle)
            {
                e.Cancel = true;
            }
        }

        private void gvData_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            Kod row = (Kod)e.Row;
            if (_kodlar.Where(c => c.OnEki.ToLower() == row.OnEki.ToLower()).Count() > 1)
            {
                MessageBox.Show("Aynı Ön Ekle Kod Eklenemez");
                gvData.CancelUpdateCurrentRow();
            }

        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Kaydı Silmek İstediğinize Emin misiniz", "Silme", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gvData.DeleteSelectedRows();
            }
        }

        private void gvData_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["SirketId"], AppSession.Sirket.Id);
            view.SetRowCellValue(e.RowHandle, view.Columns["DonemId"], AppSession.Donem.Id);
            view.SetRowCellValue(e.RowHandle, view.Columns["KayitUserId"], AppSession.CurrentUser.Id);
            view.SetRowCellValue(e.RowHandle, view.Columns["KayitTarihi"], DateTime.Now);
            view.SetRowCellValue(e.RowHandle, view.Columns["Tablo"], _tablo);
        }

        private void gvData_EditFormShowing(object sender, EditFormShowingEventArgs e)
        {
            GridView view = sender as GridView;
            e.Allow = view.IsNewItemRow(e.RowHandle);
        }
    }
}
