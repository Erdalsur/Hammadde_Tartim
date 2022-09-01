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
    public partial class FrmDonemSec : XPopupForm
    {
        public Donem donem;
        public Sirket _sirket;
        public FrmDonemSec()
        {
            InitializeComponent();
        }
        public FrmDonemSec(Sirket sirket)
        {
            InitializeComponent();
            _sirket = sirket;
        }

        private void FrmDonemSec_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = DataSession.DonemService.GetAll(f => f.SirketId == _sirket.Id);
            InitGridView(gridView1);
            gridView1.MakeColumnInvisible("Id", "SirketId","Baslangic","Bitis","OncekiYilId", "KayitUserId", "KayitTarihi", "DegistirmeUserId", "DegistirmeTarihi");
            gridView1.MakeReadOnly();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int handle = gridView1.FocusedRowHandle;
            if (handle > -1)
            {
                donem = DataSession.DonemService.GetById(intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id")));
            }
        }

        private void Sec_Click(object sender, EventArgs e)
        {
            DonemSec();
        }

        private void DonemSec()
        {
            if (donem != null)
                this.DialogResult = DialogResult.OK;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DonemSec();
        }
    }
}
