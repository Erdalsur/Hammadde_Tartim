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
using Sanmark.Erp.Framework.Abstract;
using Sanmark.Erp.Entities.Concrete;
using DevExpress.XtraSplashScreen;
using Sanmark.ERP.WinUI.BaseForms;
using Sanmark.ERP.WinUI.Core.Grid;

namespace Sanmark.ERP.WinUI.Sirketler
{
    public partial class FrmSirketBul : XPopupForm
    {
        ISirketService _sirketService;
        List<Sirket> sirketler;
        public Sirket sirket = new Sirket();
        int secilenId = 0;
        public int seciliSatir = 999999999;
        public FrmSirketBul()
        {
            InitializeComponent();
            SplashScreenManager.ShowForm(typeof(FrmWait));
            _sirketService = DataSession.SirketService;
        }

        private void FrmSirketBul_Load(object sender, EventArgs e)
        {
            sirketler = _sirketService.GetAll();
            gcSirketler.DataSource = sirketler;
            gvSirketler.SetCaptions("Id:Referans No", "Ad:Ünvan", "Email:E-mail Adresi");
            gvSirketler.MakeReadOnly();
            gvSirketler.SetAlternateRowStyle(true);
            //gvSirketler.AddSummary();
            gvSirketler.Columns["DegistirmeUserId"].ColumnEdit =
            gvSirketler.Columns["KayitUserId"].ColumnEdit = AppSession.MainForm.gleUser;
            gvSirketler.MakeColumnInvisible("Id","Email", "KayitUserId", "KayitTarihi", "DegistirmeUserId", "DegistirmeTarihi");
        }

        private void FrmSirketBul_Shown(object sender, EventArgs e)
        {
            SplashScreenManager.CloseForm();
        }

        private void GvSirketler_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var handle = gvSirketler.GetSelectedRows()[0];
                secilenId = intParse(gvSirketler.GetRowCellValue(handle, "Id"));
            }
            catch
            {
                secilenId=0;
            }
        }

        private void GvSirketler_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gvSirketler.SelectRow(gvSirketler.FocusedRowHandle);
            gvSirketler.ShowEditor();
            gvSirketler.Appearance.FocusedCell.BackColor = Color.Transparent;
            if (seciliSatir==gvSirketler.FocusedRowHandle)
            {
                seciliSatir = 999999999;
                sirket = DataSession.SirketService.GetById(intParse(gvSirketler.GetRowCellValue(gvSirketler.FocusedRowHandle,"Id")));
                DialogResult = DialogResult.OK;
            }
            else { seciliSatir = gvSirketler.FocusedRowHandle; }
        }
    }
}