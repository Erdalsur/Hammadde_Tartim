using Sanmark.Erp.Entities.Concrete;
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

namespace Sanmark.ERP.WinUI
{
    public partial class FrmFirmaSec : XPopupForm
    {
        public Sirket sirket;
        public FrmFirmaSec()
        {
            InitializeComponent();
        }

        private void FrmFirmaSec_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = DataSession.SirketService.GetAll();
            InitGridView(gridView1);
            gridView1.MakeColumnInvisible("Id", "Email","KayitUserId","KayitTarihi","DegistirmeUserId","DegistirmeTarihi");
            gridView1.MakeReadOnly();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int handle = gridView1.FocusedRowHandle;
            if (handle > -1)
            {
                sirket= DataSession.SirketService.GetById(intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id")));
            }
        }

        private void Sec_Click(object sender, EventArgs e)
        {
            SirketSec();
        }

        private void SirketSec()
        {
            if (sirket != null)
                this.DialogResult = DialogResult.OK;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            SirketSec();
        }
    }
}
