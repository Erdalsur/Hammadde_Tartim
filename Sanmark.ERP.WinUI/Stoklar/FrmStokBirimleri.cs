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
using Sanmark.Erp.Framework.Abstract;
using Sanmark.Erp.Entities.Concrete.Stok;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors.Repository;
using Sanmark.ERP.WinUI.Core.Grid;
using DevExpress.XtraGrid.Views.Grid;
using FluentValidation;

namespace Sanmark.ERP.WinUI.Stoklar
{
    public partial class FrmStokBirimleri : XForm
    {
        BindingList<StokBirim> _stokBirims;
        IStokBirimService _stokBirimService;
        StokBirim _stokBirim=new StokBirim();
        public FrmStokBirimleri()
        {
            InitializeComponent();
            SplashScreenManager.ShowForm(typeof(FrmWait));
            _stokBirimService = DataSession.StokBirimService;
        }

        private void FrmStokBirimleri_Load(object sender, EventArgs e)
        {
            ListeGetir();
        }

        private void ListeGetir()
        {
            _stokBirims = new BindingList<StokBirim>(_stokBirimService.GetAll(g => g.SirketId == AppSession.Sirket.Id).ToList());
            RepositoryItemGridLookUpEdit gle = GetCustomGLE(DataSession.SirketService.GetAll(), "Ad", "Id");
            gcBirimler.DataSource = _stokBirims;
            gvBirimler.PopulateColumns();
            gvBirimler.Columns["SirketId"].ColumnEdit = gle;
            gvBirimler.SetCaptions("Id:Referans No", "SirketId:Firma", "Ad:Açıklama", "Kod:Kod");

            InitGridView(gvBirimler);
            //gvBirimler.MakeColumnsReadOnly("Id","SirketId");
            gvBirimler.Columns["DegistirmeUserId"].ColumnEdit =
            gvBirimler.Columns["KayitUserId"].ColumnEdit = AppSession.MainForm.gleUser;
            gvBirimler.MakeColumnInvisible("Id", "SirketId");
            gvBirimler.EnableNewRow();
        }

        private void FrmStokBirimleri_Shown(object sender, EventArgs e)
        {
            SplashScreenManager.CloseForm();
        }

        private void GvBirimler_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["SirketId"], AppSession.Sirket.Id);
        }

        private void BbiSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvBirimler.FocusedRowHandle;
            if (handle > -1)
            {
                _stokBirim.Id = intParse(gvBirimler.GetRowCellValue(handle, "Id"));
                _stokBirim.Ad = strParse(gvBirimler.GetRowCellValue(handle, "Ad"));

                if (XtraMessageBox.Show(String.Format("{0} Stok Birimini Simek İstiyormusunuz?", _stokBirim.Ad), "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                else
                {
                    if (_stokBirim.Id != 0)
                    {
                        _stokBirimService.Delete(_stokBirim);
                        AppSession.MainForm.ShowInfoMessage("Silindi");
                        ListeGetir();
                    }
                    else
                    {
                        gvBirimler.DeleteRow(handle);
                    }
                }
            }
        }

        private void BbiKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gvBirimler.EndEditing();
                _stokBirimService.SaveAll(_stokBirims);
                AppSession.MainForm.ShowInfoMessage("Kayıt başarılı bir şekilde yapıldı.");
                ListeGetir();
            }
            catch (ValidationException ex)
            {
                XtraMessageBox.Show("Stok Birimi Nesne Hatası.\r\n\r\n Hata: " + ex.Message.Replace("Validation failed: \r\n", ""), "Validasyon Hatası");
                //view.RefreshData();
            }
        }
    }
}