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
using DevExpress.XtraSplashScreen;
using Sanmark.ERP.WinUI.BaseForms;
using Sanmark.Erp.Framework.Abstract;
using Sanmark.ERP.WinUI.Core.Grid;
using Sanmark.Erp.Entities.Concrete.Cari;
using DevExpress.XtraEditors.Repository;
using Sanmark.Core.Utilities.Tipler;

namespace Sanmark.ERP.WinUI.Cariler
{
    public partial class FrmFirmalar : XForm
    {
        public int seciliSatir = 999999999;
        IFirmaService firmaService;
        Firma firmaKart;
        private int secilenId;
        RepositoryItemGridLookUpEdit gleFirmaTipleri, gleFirmaKartTipleri;

        public FrmFirmalar()
        {
            InitializeComponent();
            SplashScreenManager.ShowForm(typeof(FrmWait));
            firmaService = DataSession.FirmaService;
        }

        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            KartListesi();
        }

        private void KartListesi()
        {
            gleFirmaTipleri = GetGLEEnum((List<EnumListesi>)typeof(FirmaTipi).ToList2(), "Ad");


            gleFirmaKartTipleri = GetGLEEnum((List<EnumListesi>)typeof(FirmaKartTipi).ToList2(), "Ad");
            
            gcKartlar.DataSource=firmaService.GetAll(s => s.SirketId == AppSession.Sirket.Id).ToList();
            gvKartlar.Columns["FirmaTip"].ColumnEdit = gleFirmaTipleri;
            gvKartlar.Columns["FirmaKartTip"].ColumnEdit = gleFirmaKartTipleri;
            gvKartlar.MakeReadOnly();
            gvKartlar.SetCaptions("Id:Referans No", "SirketId:Firma","FirmaTip:Tipi","FirmaKartTip:Türü","Ad:Ad-Ünvan","Soyad:Soyad-Ünvan","VergiDairesi:Vergi Dairesi","VergiNo:Vergi No", "KayitTarihi:Kayıt Tarihi", "DegistirmeTarihi:Değiştirme Tarihi", "KayitUserId:Kayıt Eden", "DegistirmeUserId:Değiştiren");
            gvKartlar.YanYanaGetir("KayitTarihi:KayitUserId", "DegistirmeTarihi:DegistirmeUserId");
            gvKartlar.MakeColumnInvisible("Id","SirketId", "FirmaKartTip", "KayitTarihi","KayitUserId", "DegistirmeTarihi","DegistirmeUserId");
            gvKartlar.Columns["DegistirmeUserId"].ColumnEdit =
            gvKartlar.Columns["KayitUserId"].ColumnEdit = AppSession.MainForm.gleUser;
        }

        private void FrmFirmalar_Shown(object sender, EventArgs e)
        {
            SplashScreenManager.CloseForm();
        }

        private void GvKartlar_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var handle = gvKartlar.GetSelectedRows()[0];
                secilenId = intParse(gvKartlar.GetRowCellValue(handle, "Id"));
            }
            catch
            {
                secilenId = 0;
            }
        }

        private void GvKartlar_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gvKartlar.SelectRow(gvKartlar.FocusedRowHandle);
            gvKartlar.ShowEditor();
            gvKartlar.Appearance.FocusedCell.BackColor = Color.Transparent;
            if (seciliSatir == gvKartlar.FocusedRowHandle)
            {
                seciliSatir = 999999999;
                firmaKart = DataSession.FirmaService.GetById(intParse(gvKartlar.GetRowCellValue(gvKartlar.FocusedRowHandle, "Id")));
                Kart_Ac(firmaKart);
            }
            else { seciliSatir = gvKartlar.FocusedRowHandle; }
        }

        private void Kart_Ac(Firma firmaKart)
        {
            using (FrmFirmaKart frmStokKart = new FrmFirmaKart(firmaKart.Id))
            {
                frmStokKart.ShowDialog();
                if (frmStokKart.DialogResult == DialogResult.OK)
                    KartListesi();

            }
        }

        private void BbiSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvKartlar.FocusedRowHandle;
            if (handle > -1)
            {
                firmaKart.Id = intParse(gvKartlar.GetRowCellValue(handle, "Id"));
                firmaKart.Ad = strParse(gvKartlar.GetRowCellValue(handle, "Ad"));
                firmaKart.Kod = strParse(gvKartlar.GetRowCellValue(handle, "Kod"));
                if (XtraMessageBox.Show(String.Format("{0} Firma Kartını Simek İstiyormusunuz?", firmaKart.Ad), "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                else
                {
                    firmaService.Delete(firmaKart);
                    AppSession.MainForm.ShowInfoMessage("Silindi");
                    KartListesi();

                }
            }
        }

        private void BbiYeniStokKart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvKartlar.FocusedRowHandle;
            using (FrmFirmaKart frmStokKart = new FrmFirmaKart())
            {
                frmStokKart.ShowDialog();
                if (frmStokKart.DialogResult == DialogResult.OK)
                    KartListesi();
                gvKartlar.FocusedRowHandle = handle;
            }
        }

        private void BbiStokKartAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int handle = gvKartlar.FocusedRowHandle;
            if (handle > -1)
            {
                Kart_Ac(DataSession.FirmaService.GetById(intParse(gvKartlar.GetRowCellValue(gvKartlar.FocusedRowHandle, "Id"))));
                gvKartlar.FocusedRowHandle = handle;
            }
        }
    }
}