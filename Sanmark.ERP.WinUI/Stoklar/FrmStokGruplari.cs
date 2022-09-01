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
using DevExpress.XtraGrid.Views.Grid;
using Sanmark.Erp.Framework.ValidationRules.FluentValidation;
using FluentValidation.Results;
using FluentValidation;
using Sanmark.ERP.WinUI.Core.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraSplashScreen;

namespace Sanmark.ERP.WinUI.Stoklar
{
    public partial class FrmStokGruplari : XForm
    {
        BindingList<StokGrup> grups;
        IStokGrupService _stokGrupService;
        RepositoryItemGridLookUpEdit gle;
        StokGrup stokGrup;
        public FrmStokGruplari()
        {
            InitializeComponent();
            SplashScreenManager.ShowForm(typeof(FrmWait));
            _stokGrupService = DataSession.StokGrupService;
            stokGrup = new StokGrup();
        }
        
        private void FrmStokGruplari_Load(object sender, EventArgs e)
        {
            ListeGetir();  
            
        }

        private void ListeGetir()
        {
            grups = new BindingList<StokGrup>(_stokGrupService.GetAll(g => g.SirketId == AppSession.Sirket.Id).ToList());
            gle = GetCustomGLE(DataSession.SirketService.GetAll(), "Ad", "Id");
            gcStokGruplari.DataSource = grups;
            gvStokGruplari.PopulateColumns();
            gvStokGruplari.Columns["SirketId"].ColumnEdit = gle;
            gvStokGruplari.Columns["DegistirmeUserId"].ColumnEdit =
            gvStokGruplari.Columns["KayitUserId"].ColumnEdit = AppSession.MainForm.gleUser;
            InitGridView(gvStokGruplari);
            gvStokGruplari.EnableNewRow();
            gvStokGruplari.BestFitColumns();
            gvStokGruplari.SetCaptions("Id:Referans No", "SirketId:Firma", "ParentId:Referans", "Ad:Stok Grup Adı", "Aciklama:Açıklama");
            gvStokGruplari.MakeColumnInvisible("Id", "ParentId", "SirketId");
            gvStokGruplari.MakeColumnsReadOnly("SirketId", "ParentId");
            //gvStokGruplari.OptionsView.ColumnAutoWidth = true;
        }

        private void BbiKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Sakla(this.gvStokGruplari);
        }
        private void Sakla(GridView view)
        {
            try
            {
                
                view.EndEditing();
                List<StokGrup> stokGrups = grups.ToList<StokGrup>();
                _stokGrupService.SaveAll(stokGrups);
                AppSession.MainForm.ShowInfoMessage("Kayıt başarılı bir şekilde yapıldı.");
                ListeGetir();
            }
            catch (ValidationException ex)
            {
                XtraMessageBox.Show("Stok Grubu Nesne Hatası.\r\n\r\n Hata: " + ex.Message.Replace("Validation failed: \r\n", ""), "Validasyon Hatası");
                //view.RefreshData();
            }
        }

       
        private void GvStokGruplari_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["SirketId"], AppSession.Sirket.Id);
        }

        private void BbiSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvStokGruplari.FocusedRowHandle;
            if (handle > -1)
            {
                stokGrup.Id = intParse(gvStokGruplari.GetRowCellValue(handle, "Id"));
                stokGrup.Ad = strParse(gvStokGruplari.GetRowCellValue(handle, "Ad"));
                
                if (XtraMessageBox.Show(String.Format("{0} Stok Grubunu Simek İstiyormusunuz?", stokGrup.Ad), "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                else
                {
                    if (stokGrup.Id != 0)
                    {
                        _stokGrupService.Delete(stokGrup);
                        AppSession.MainForm.ShowInfoMessage("Silindi");
                        ListeGetir();
                    }
                    else
                    {
                        gvStokGruplari.DeleteRow(handle);
                    }
                }
            }
        }

        private void FrmStokGruplari_Shown(object sender, EventArgs e)
        {
            SplashScreenManager.CloseForm();
        }

        private void gcStokGruplari_Click(object sender, EventArgs e)
        {

        }
    }
}