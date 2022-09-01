using DevExpress.XtraEditors.Repository;
using Sanmark.ERP.WinUI.BaseForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanmark.ERP.WinUI.Uretim
{
    public partial class FrmIsEmriIhtiyacListesi : XPopupForm
    {
        private int _stokId;
        private int _birimId;
        private decimal _miktar;
        RepositoryItemGridLookUpEdit gleBirimler;
        private ExportTool exportTool;
        public FrmIsEmriIhtiyacListesi(int StokId, int BirimId,decimal Miktar)
        {
            InitializeComponent();
            _stokId = StokId;
            _birimId = BirimId;
            _miktar = Miktar;
            exportTool = new ExportTool(this, gvHareket, bbiExport);
        }

        private void FrmIsEmriIhtiyacListesi_Load(object sender, EventArgs e)
        {
            gcHareket.DataSource = DataSession.IsEmirService.IsEmriIhtiyacListesiHazirla(_stokId, _birimId, _miktar);
            gleBirimler = GetCustomGLE(DataSession.StokBirimService.GetAll(f => f.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gvHareket.Columns["StokBirimi"].ColumnEdit = gleBirimler;
        }

        private void bbiYazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gvHareket.ShowPrintPreview();
        }
    }
}
