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
using Sanmark.ERP.WinUI.Core.Grid;
using DevExpress.XtraSplashScreen;
using Sanmark.Erp.Framework.Abstract;
using DevExpress.XtraEditors.Repository;
using Sanmark.Erp.Entities.Concrete;
using DevExpress.XtraEditors.Controls;

namespace Sanmark.ERP.WinUI.Sirketler
{
    public partial class FrmDonemler : XForm
    {
        public int seciliSatir = 999999999;
        IDonemService _donemService;
        Donem _donem;
        private int secilenId;

        public FrmDonemler()
        {
            InitializeComponent();
            SplashScreenManager.ShowForm(typeof(FrmWait));
            _donemService = DataSession.DonemService;
        }

        void DonemleriAl()
        {
            gcDonemler.DataSource = _donemService.GetAll();
            
        }
        private void FrmDonemler_Load(object sender, EventArgs e)
        {
            this.Text = "Şirket Dönemleri";
            DonemleriAl();
            RepositoryItemGridLookUpEdit gle = GetCustomGLE(DataSession.SirketService.GetAll(), "Ad", "Id");
            gvDonemler.Columns["SirketId"].ColumnEdit = gle;
            //.Properties.Assign(riSirket);
            //.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            gvDonemler.SetCaptions("Id:Referans No", "SirketId:Şirket", "Yil:Dönemi","Baslangic:Başlangıç Tarihi","Bitis:Bitis Tarihi","OncekiYilId:Devir Öncesi Referansı");
            gvDonemler.MakeReadOnly();
            gvDonemler.SetAlternateRowStyle(true);
            gvDonemler.Columns["DegistirmeUserId"].ColumnEdit =
            gvDonemler.Columns["KayitUserId"].ColumnEdit = AppSession.MainForm.gleUser;
            gvDonemler.MakeColumnInvisible("Id","OncekiYilId");
            _donem = new Donem();

        }

        private void FrmDonemler_Shown(object sender, EventArgs e)
        {
            SplashScreenManager.CloseForm();
        }

        private void BbiYeniDonem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvDonemler.FocusedRowHandle;
            using (FrmDonem frmDonem = new FrmDonem())
            {
                frmDonem.ShowDialog();
                if (frmDonem.DialogResult == DialogResult.OK)
                    DonemleriAl();
                gvDonemler.FocusedRowHandle = handle;
            }
        }

        private void BbiDonemAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvDonemler.FocusedRowHandle;
            if (handle > -1)
            {
                Donem_Ac(DataSession.DonemService.GetById(intParse(gvDonemler.GetRowCellValue(gvDonemler.FocusedRowHandle, "Id"))));
                gvDonemler.FocusedRowHandle = handle;
            }
        }

        private void BbiSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvDonemler.FocusedRowHandle;
            if (handle > -1)
            {
                _donem.Id = intParse(gvDonemler.GetRowCellValue(handle, "Id"));
                _donem.Yil = Convert.ToInt16(gvDonemler.GetRowCellValue(handle, "Yil"));
                _donem.SirketId = intParse(gvDonemler.GetRowCellValue(handle, "SirketId"));
                if (XtraMessageBox.Show(String.Format("{0} dönemini Simek İstiyormusunuz?", _donem.Yil.ToString()), "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                else
                {
                    _donemService.Delete(_donem);
                    AppSession.MainForm.ShowInfoMessage("Silindi");
                    DonemleriAl();
                    
                }
            }
        }


        private void GvDonemler_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gvDonemler.SelectRow(gvDonemler.FocusedRowHandle);
            gvDonemler.ShowEditor();
            gvDonemler.Appearance.FocusedCell.BackColor = Color.Transparent;
            if (seciliSatir == gvDonemler.FocusedRowHandle)
            {
                seciliSatir = 999999999;
                _donem = DataSession.DonemService.GetById(intParse(gvDonemler.GetRowCellValue(gvDonemler.FocusedRowHandle, "Id")));
                //Kart Açılacak
                Donem_Ac(_donem);
                
            }
            else { seciliSatir = gvDonemler.FocusedRowHandle; }
        }

        private void Donem_Ac(Donem donem)
        {
            using (FrmDonem frmDonem = new FrmDonem(donem.Id))
            {
                frmDonem.ShowDialog();
                if (frmDonem.DialogResult == DialogResult.OK)
                    DonemleriAl();
                
            }
        }

        private void GvDonemler_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var handle = gvDonemler.GetSelectedRows()[0];
                secilenId = intParse(gvDonemler.GetRowCellValue(handle, "Id"));
            }
            catch
            {
                secilenId = 0;
            }
        }
    }
}