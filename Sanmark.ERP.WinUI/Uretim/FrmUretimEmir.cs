using DevExpress.XtraEditors.Repository;
using Sanmark.Erp.Entities.Concrete.Uretim;
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
    public partial class FrmUretimEmir : XPopupForm
    {
        RepositoryItemGridLookUpEdit gleStokKart, gleMakinalar;
        UretimEmirleri uretimEmir;
        public FrmUretimEmir()
        {
            InitializeComponent();
            uretimEmir = new UretimEmirleri();
        }
        public FrmUretimEmir(int UretimEmirId)
        {
            InitializeComponent();
            uretimEmir = DataSession.UretimService.GetById(UretimEmirId);
            
            txtAciklama.Text = uretimEmir.Aciklama;
            txtMiktar.Text = uretimEmir.Miktar.ToString();
            txtSeriNo.Text = uretimEmir.SeriNo;
            gleMakina.EditValue = uretimEmir.MakinaId;
            gleUrun.EditValue = uretimEmir.UrunId;
            dateBaslamaTarihi.EditValue = Convert.ToDateTime(uretimEmir.UretimBaslangicTarihi);
            if (uretimEmir.UretimBaslangicTarihi != null)
            {
                this.bbiKaydet.Enabled = false;
            }
        }

        private void FrmUretimEmir_Load(object sender, EventArgs e)
        {
            
            gleStokKart = GetCustomGLE(DataSession.StokKartService.GetAll(g => g.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleStokKart.View.OptionsView.ColumnAutoWidth = true;
            gleUrun.Properties.Assign(gleStokKart);
            gleUrun.Properties.View.Columns["StokGrupId"].Visible =
                gleUrun.Properties.View.Columns["StokBirimId"].Visible =
                gleUrun.Properties.View.Columns["Tip"].Visible =
                gleUrun.Properties.View.Columns["Barkod"].Visible =
                gleUrun.Properties.View.Columns["AmbalajId"].Visible =
                gleUrun.Properties.View.Columns["SirketId"].Visible = false;
            gleUrun.Properties.View.BestFitColumns();
            gleMakinalar = GetCustomGLE(DataSession.UretimService.GetMakinalar(g => g.SirketId == AppSession.Sirket.Id &&
            g.DonemId == AppSession.Donem.Id), "MakinaAdi", "Id");
            gleMakina.Properties.Assign(gleMakinalar);
            gleMakina.Properties.View.Columns["DonemId"].Visible =
                gleMakina.Properties.View.Columns["Donem"].Visible =
                gleMakina.Properties.View.Columns["UretimEmirleri"].Visible =
                gleMakina.Properties.View.Columns["Sirket"].Visible = false;
            gleMakina.Properties.View.BestFitColumns();
        }

        private void bbiKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                uretimEmir.DonemId = AppSession.Donem.Id;
                uretimEmir.Aciklama = txtAciklama.Text.Trim();
                uretimEmir.MakinaId = intParse(gleMakina.EditValue);
                uretimEmir.UrunId = intParse(gleUrun.EditValue);
                uretimEmir.SeriNo = txtSeriNo.Text.Trim();
                uretimEmir.Miktar = Convert.ToDecimal(txtMiktar.Text);
                if (uretimEmir.Id == 0)
                    DataSession.UretimService.UretimEmri_Kayit(uretimEmir);
                else
                    DataSession.UretimService.UretimEmir_Duzelt(uretimEmir);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void txtAd_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
