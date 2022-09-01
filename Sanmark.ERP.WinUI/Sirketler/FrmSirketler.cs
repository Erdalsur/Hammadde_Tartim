using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraSplashScreen;
using Sanmark.Erp.Entities.Concrete;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Sanmark.ERP.WinUI.Sirketler
{
    public partial class FrmSirketler : XForm
    {
        ISirketService _sirketService;
        Sirket sirket = new Sirket();
        public FrmSirketler()
        {
            InitializeComponent();            
            SplashScreenManager.ShowForm(typeof(FrmWait));
            _sirketService = DataSession.SirketService;
        }

        private void FrmSirketler_Load(object sender, EventArgs e)
        {            
            SirketleriAl();
            //gvSirketler.SetViewCaption("Tanımlı Şirketler");
            gvSirketler.SetCaptions("Id:Referans No","Ad:Ünvan","Email:E-mail Adresi");
            gvSirketler.MakeReadOnly();
            gvSirketler.SetAlternateRowStyle(true);
            //gvSirketler.AddSummary();
            gvSirketler.MakeColumnInvisible("Id");
            gvSirketler.Columns["DegistirmeUserId"].ColumnEdit =
            gvSirketler.Columns["KayitUserId"].ColumnEdit = AppSession.MainForm.gleUser;
            gvSirketler.DoubleClick += GvSirketler_DoubleClick;
        }

        private void GvSirketler_DoubleClick(object sender, EventArgs e)
        {
            SirketiAc();
        }

        private void SirketiAc()
        {
            int handle = gvSirketler.FocusedRowHandle;
            if (handle > -1)
            {
                int SirketId = intParse(gvSirketler.GetRowCellValue(handle, "Id"));
                using (FrmSirket frmSirket = new FrmSirket(SirketId))
                {
                    frmSirket.ShowDialog();
                    if (frmSirket.DialogResult == DialogResult.OK)
                        SirketleriAl();
                    gvSirketler.FocusedRowHandle = handle;
                }
            }
        }

        private void SirketleriAl()
        {
            List<Sirket> sirketler= _sirketService.GetAll();
            gcSirketler.DataSource = sirketler;
        }

        private void FrmSirketler_Shown(object sender, EventArgs e)
        {
            
            SplashScreenManager.CloseForm();
        }

        private void BbiYeniSirket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvSirketler.FocusedRowHandle;
            using (FrmSirket frmSirket = new FrmSirket())
            {
                frmSirket.ShowDialog();
                if (frmSirket.DialogResult == DialogResult.OK)
                    SirketleriAl();
                gvSirketler.FocusedRowHandle = handle;
            }
        }

        private void BbiSirketAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SirketiAc();
        }

        private void BbiSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvSirketler.FocusedRowHandle;
            if (handle > -1)
            {                
                sirket.Id = intParse(gvSirketler.GetRowCellValue(handle, "Id"));
                sirket.Ad = strParse(gvSirketler.GetRowCellValue(handle, "Ad"));
                sirket.Email= strParse(gvSirketler.GetRowCellValue(handle, "Email"));
                if (XtraMessageBox.Show(String.Format("{0} ünvanlı şirketi Simek İstiyormusunuz?", sirket.Ad), "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                else
                {
                    _sirketService.Delete(sirket);
                    AppSession.MainForm.ShowInfoMessage("Silindi");
                    SirketleriAl();
                }
            }
        }
    }
}
