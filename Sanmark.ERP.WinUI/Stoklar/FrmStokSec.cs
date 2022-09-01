using DevExpress.XtraEditors.Repository;
using Sanmark.Core.Utilities.Tipler;
using Sanmark.Erp.Entities.Concrete.Stok;
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

namespace Sanmark.ERP.WinUI.Stoklar
{
    public partial class FrmStokSec : XPopupForm
    {
        public List<StokKarti> secilen = new List<StokKarti>();
        public bool secildi = false;
        public FrmStokSec(bool cokluSecim = false)
        {
            InitializeComponent();
            lbCokluSecim.Visible = cokluSecim;
            gvData.OptionsSelection.MultiSelect = cokluSecim;
        }

        private void FrmStokSec_Load(object sender, EventArgs e)
        {
            gcData.DataSource = DataSession.StokKartService.GetAll(f => f.SirketId == AppSession.Sirket.Id);
            gleDoldur();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gvData.GetSelectedRows().Length != 0)
            {
                foreach (var row in gvData.GetSelectedRows())
                {
                    int _id = intParse(gvData.GetRowCellValue(row, colId).ToString());
                    secilen.Add(DataSession.StokKartService.GetById(_id));
                }
                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen bir ürün bulunamadı");
            }
        }

        private void gleDoldur()
        {
            RepositoryItemGridLookUpEdit gleBirimler = GetCustomGLE(DataSession.StokBirimService.GetAll(s => s.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleBirimler.View.OptionsView.ColumnAutoWidth = true;
            gvData.Columns["StokBirimId"].ColumnEdit = gleBirimler;


            RepositoryItemGridLookUpEdit gleGruplar = GetCustomGLE(DataSession.StokGrupService.GetAll(g => g.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleGruplar.View.OptionsView.ColumnAutoWidth = true;
            gvData.Columns["StokGrupId"].ColumnEdit = gleGruplar;
            RepositoryItemGridLookUpEdit gleStokTur = GetGLEEnum((List<EnumListesi>)typeof(StokTipi).ToList2(), "Ad");
            gvData.Columns["Tip"].ColumnEdit = gleStokTur;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
