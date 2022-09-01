using DevExpress.XtraEditors.Repository;
using Sanmark.Core.Utilities.Tipler;
using Sanmark.Erp.Entities.Concrete.Uretim;
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

namespace Sanmark.ERP.WinUI.Uretim
{
    public partial class FrmUretim : XForm
    {
        private UretimEmirleri _uretimEmirleri;
        private List<UretimEmirDetaylari> _uretimEmirDetaylari;
        private UretimEmirDetaylari _detay;
        RepositoryItemGridLookUpEdit gleSirket, gleStokKart, gleMakina, gleStatus;
        public FrmUretim()
        {
            InitializeComponent();
            gleStokKart = GetCustomGLE(
                            DataSession.StokKartService.GetAll(g => g.SirketId == AppSession.Sirket.Id).Select(s => new { Id = s.Id, Kod = s.Kod, Ad = s.Ad }).ToList(), "Ad", "Id");
            gleStatus = GetGLEEnum((List<EnumListesi>)typeof(Status).ToList2(), "Ad");

        }
        public FrmUretim(int UretimEmirId)
        {
            InitializeComponent();
            _uretimEmirleri = DataSession.UretimService.GetById(UretimEmirId);
            _uretimEmirDetaylari = DataSession.UretimService.UretimEmirDetaylari(_uretimEmirleri.Id);
            gleStokKart = GetCustomGLE(
                            DataSession.StokKartService.GetAll(g => g.SirketId == AppSession.Sirket.Id).Select(s => new { Id = s.Id, Kod = s.Kod, Ad = s.Ad }).ToList(), "Ad", "Id");
            gleStatus = GetGLEEnum((List<EnumListesi>)typeof(Status).ToList2(), "Ad");


        }


        private void FrmUretim_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = _uretimEmirDetaylari;
            
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int handle = gridView1.FocusedRowHandle;
            if (handle > -1)
            {
                Kart_Yukle(intParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id")));
            }
        }

        private void Kart_Yukle(int EmirDetayId)
        {
            _detay = DataSession.UretimService.GetDetaylari(EmirDetayId);
            lblTartimEkrani.Text = DataSession.StokKartService.GetById(_detay.UrunId).Ad + " için Toplam Hazırlanacak Miktar: " + _detay.Miktar;
            _detay.UretimTartimlari = DataSession.UretimService.GetTartimAll(f => f.UretimEmirDetayId == _detay.Id);
            gridControl2.DataSource = _detay.UretimTartimlari;
            InitGridView(gridView1);
            gridView1.MakeReadOnly();
            InitGridView(gridView2);
            gridView2.Columns["UrunId"].ColumnEdit=
            gridView1.Columns["UrunId"].ColumnEdit = gleStokKart;
            gridView1.Columns["UretimDurumu"].ColumnEdit = gleStatus;
            gridView1.Columns["DegistirmeUserId"].ColumnEdit =
            gridView1.Columns["KayitUserId"].ColumnEdit = AppSession.MainForm.gleUser;

            gridView1.MakeColumnInvisible("Id", "UretimEmir", "UretimEmirId", "FireMiktari", "UretimTartimlari", "SonKullanimTarihi");
            gridView2.MakeColumnInvisible("Id","UretimEmirId","UretimEmirDetay", "UretimEmirDetayId");
            gridView2.FormatAsNumber(6,"Miktar", "Brut", "Dara");
            gridView2.AddSummaryKilo("Miktar", "Brut", "Dara");
            gridView1.FormatAsNumber(6, "Miktar", "ReelMiktar");
            gridView1.AddSummaryKilo("Miktar", "ReelMiktar");
            gridView2.Columns["DegistirmeUserId"].ColumnEdit =
            gridView2.Columns["KayitUserId"].ColumnEdit = AppSession.MainForm.gleUser;
            gridView2.MakeReadOnly();
            gridView1.BestFitColumns();
            gridView2.BestFitColumns();
        }

        private void btnTartımEkle_Click(object sender, EventArgs e)
        {
            using (FrmTartim frmTartim = new FrmTartim())
            {
                frmTartim._detay = _detay;
                frmTartim.ShowDialog();
                if (frmTartim.DialogResult == DialogResult.OK)
                {
                    _detay.UretimTartimlari.Add(frmTartim.uretimTartim);
                    gridControl2.RefreshDataSource();
                    DataSession.UretimService.UretimDetay_Kayit(_detay);
                    int handle = gridView1.FocusedRowHandle;
                    if (handle > -1)
                    {
                        gridControl1.DataSource=DataSession.UretimService.UretimEmirDetaylari(_uretimEmirleri.Id);
                    }
                    gridView1.FocusedRowHandle = handle;
                    gridControl1.RefreshDataSource();
                }
            }
        }
    }
}
