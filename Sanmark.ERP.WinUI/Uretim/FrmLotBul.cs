using DevExpress.XtraEditors.Repository;
using Sanmark.ERP.WinUI.BaseForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanmark.ERP.WinUI.Uretim
{
    public partial class FrmLotBul : XPopupForm
    {
        int _stokId;
        public bool secildi = false;

        public string SecilenLot { get; set; }
        public string SecilenRef { get; set; }
        public string SecilenSTK { get; set; }

        public FrmLotBul(int StokId)
        {
            InitializeComponent();
            _stokId = StokId;
        }

        private void FrmLotBul_Load(object sender, EventArgs e)
        {
            //            var select = @"SELECT        Id, SirketId, DonemId, StokId, BirimId, LotNo,
            //                             (SELECT        SUM(G.GirisCikisMiktar * CASE WHEN G.BirimId = K.StokBirimId THEN 1 WHEN G.BirimId = K.Birim2Id THEN K.Birim2Pay / K.Birim2Payda WHEN G.BirimId
            //                                                          = K.Birim3Id THEN K.Birim3Pay / K.Birim3Payda ELSE 0 END) AS Expr1
            //                               FROM            dbo.StokHareketleri AS G LEFT OUTER JOIN
            //                                                         dbo.StokKartlar AS K ON K.Id = G.StokId
            //                               WHERE(G.StokId = H.StokId) AND(G.GirisCikis = 1)) AS Giris,
            //                             (SELECT        SUM(G.GirisCikisMiktar * CASE WHEN G.BirimId = K.StokBirimId THEN 1 WHEN G.BirimId = K.Birim2Id THEN K.Birim2Pay / K.Birim2Payda WHEN G.BirimId
            //                                                 = K.Birim3Id THEN K.Birim3Pay / K.Birim3Payda ELSE 0 END) AS Expr1

            //                      FROM            dbo.StokHareketleri AS G LEFT OUTER JOIN

            //                                                dbo.StokKartlar AS K ON K.Id = G.StokId

            //                      WHERE(G.StokId = H.StokId) AND(G.GirisCikis = 2)) AS Cikis,
            //                             (SELECT        TOP(1) MIN(SKT) AS Expr1

            //             FROM            dbo.StokHareketleri AS TH

            //             WHERE(StokId = H.StokId) AND(SKT IS NOT NULL)) AS SKT,
            //                             (SELECT        TOP(1) MIN(UretimTarihi) AS Expr1

            //    FROM            dbo.StokHareketleri AS TH

            //    WHERE(StokId = H.StokId) AND(UretimTarihi IS NOT NULL)) AS UretimTarihi, Tarih,
            //                             (SELECT        StokBirimId

            //FROM            dbo.StokKartlar

            //WHERE(Id = H.StokId)) AS StokKartBirimId
            //FROM dbo.StokHareketleri AS H";
            //            String strConnection = Properties.Settings.Default.ErpContext;
            //            var c = new SqlConnection(strConnection); // Your Connection String here
            //            var dataAdapter = new SqlDataAdapter(select, c);

            //            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            //            var ds = new DataSet();
            //            dataAdapter.Fill(ds);

            //            gcData.DataSource = ds.Tables[0];
            gcData.DataSource = DataSession.IsEmirService.LotListesi(f => f.StokId == _stokId);
            gleDoldur();
        }

        private void gleDoldur()
        {
            RepositoryItemGridLookUpEdit gleBirimler = GetCustomGLE(DataSession.StokBirimService.GetAll(s => s.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleBirimler.View.OptionsView.ColumnAutoWidth = true;
            gvData.Columns["StokKartBirimId"].ColumnEdit =
            gvData.Columns["Birim"].ColumnEdit = gleBirimler;
            RepositoryItemGridLookUpEdit gleStoklar = GetCustomGLE(DataSession.StokKartService.GetAll(s => s.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleStoklar.View.OptionsView.ColumnAutoWidth = true;


            gvData.Columns["StokId"].ColumnEdit = gleStoklar;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gvData.GetSelectedRows().Length != 0)
            {
                foreach (var row in gvData.GetSelectedRows())
                {
                    SecilenLot = strParse(gvData.GetRowCellValue(row, colLotNo).ToString());
                    SecilenRef = DataSession.StokHareketService.GetById(intParse(gvData.GetRowCellValue(row, colId).ToString())).KaliteKontrolNo;
                    SecilenSTK= strParse(gvData.GetRowCellValue(row, colSKT).ToString());
                }
                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen bir lot bulunamadı");
            }
        }
    }
}
