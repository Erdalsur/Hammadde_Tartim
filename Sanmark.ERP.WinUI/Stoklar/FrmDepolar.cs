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
using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Framework.Abstract;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors.Repository;
using Sanmark.ERP.WinUI.Core.Grid;
using DevExpress.XtraGrid.Views.Grid;
using FluentValidation;

namespace Sanmark.ERP.WinUI.Stoklar
{
    public partial class FrmDepolar : XForm
    {
        BindingList<Depo> _depos;
        IDepoService _depoService;
        Depo depo = new Depo();
        public FrmDepolar()
        {
            InitializeComponent();
            SplashScreenManager.ShowForm(typeof(FrmWait));
            _depoService = DataSession.DepoService;
        }

        private void FrmDepolar_Load(object sender, EventArgs e)
        {
            ListeGetir();
        }

        private void ListeGetir()
        {
            _depos= new BindingList<Depo>(_depoService.GetAll(g => g.SirketId == AppSession.Sirket.Id).ToList());
            RepositoryItemGridLookUpEdit gle = GetCustomGLE(DataSession.SirketService.GetAll(), "Ad", "Id");
            gcDepolar.DataSource = _depos;
            gvDepolar.PopulateColumns();
            gvDepolar.Columns["SirketId"].ColumnEdit = gle;
            gvDepolar.SetCaptions("Id:Referans No", "SirketId:Firma", "Ad:Açıklama", "Kod:Kod");
            InitGridView(gvDepolar);
            //gvBirimler.MakeColumnsReadOnly("Id","SirketId");
            gvDepolar.MakeColumnInvisible("Id", "SirketId", "KayitUserId", "KayitTarihi", "DegistirmeUserId", "DegistirmeTarihi");
            gvDepolar.EnableNewRow();
        }

        private void FrmDepolar_Shown(object sender, EventArgs e)
        {
            SplashScreenManager.CloseForm();
        }

        private void BbiKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gvDepolar.EndEditing();
                _depoService.SaveAll(_depos);
                AppSession.MainForm.ShowInfoMessage("Kayıt başarılı bir şekilde yapıldı.");
                ListeGetir();
            }
            catch (ValidationException ex)
            {
                XtraMessageBox.Show("Depo Nesne Hatası.\r\n\r\n Hata: " + ex.Message.Replace("Validation failed: \r\n", ""), "Validasyon Hatası");
                //view.RefreshData();
            }
        }

        private void BbiSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvDepolar.FocusedRowHandle;
            if (handle > -1)
            {
                depo.Id = intParse(gvDepolar.GetRowCellValue(handle, "Id"));
                depo.Ad = strParse(gvDepolar.GetRowCellValue(handle, "Ad"));

                if (XtraMessageBox.Show(String.Format("{0} Depoyu Simek İstiyormusunuz?", depo.Ad), "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                else
                {
                    if (depo.Id != 0)
                    {
                        _depoService.Delete(depo);
                        AppSession.MainForm.ShowInfoMessage("Silindi");
                        ListeGetir();
                    }
                    else
                    {
                        gvDepolar.DeleteRow(handle);
                    }
                }
            }
        }

        private void GvDepolar_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["SirketId"], AppSession.Sirket.Id);
            view.SetRowCellValue(e.RowHandle, view.Columns["KayitUserId"], AppSession.CurrentUser.Id);
            view.SetRowCellValue(e.RowHandle, view.Columns["KayitTarihi"], DateTime.Now);
        }
    }
}