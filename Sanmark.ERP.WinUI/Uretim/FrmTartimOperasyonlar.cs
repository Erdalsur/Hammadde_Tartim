using DevExpress.Data;
using DevExpress.XtraEditors.Repository;
using Sanmark.Core.Utilities.Terazi;
using Sanmark.Core.Utilities.Tipler;
using Sanmark.Core.Utilities.Win.Infrastructure;
using Sanmark.Core.Utilities.Yazici;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Entities.Concrete.Uretim;
using Sanmark.ERP.WinUI.BaseForms;
using Sanmark.ERP.WinUI.Core;
using Sanmark.ERP.WinUI.Uretim.Raporlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanmark.ERP.WinUI.Uretim
{
    public partial class FrmTartimOperasyonlar : XForm
    {
        RepositoryItemGridLookUpEdit gleDurum, gleBirimler, gleStoklar;
        private SerialPort serialPort;
        private string Temp = "";
        private TeraziData teraziData = new TeraziData();
        private IsEmri seciliIsEmri;
        private IsEmriOperasyon secili_Operasyon;
        private IsEmriOperasyonIslem uretimTartim;
        List<IsEmriOperasyonIslem> islemListesi;
        private int TartiBirimi = 0;
        private int TartiSecilen = 0;

        public FrmTartimOperasyonlar()
        {
            InitializeComponent();
            uretimTartim = new IsEmriOperasyonIslem();
            secili_Operasyon = new IsEmriOperasyon();
            seciliIsEmri = new IsEmri();

        }
        private void GLEDoldur()
        {
            gleBirimler = GetCustomGLE(DataSession.StokBirimService.GetAll(f => f.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleStoklar = GetCustomGLE(DataSession.StokKartService.GetAll(f => f.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleDurum = GetGLEEnum((List<EnumListesi>)typeof(Status).ToList2(), "Ad");
            txtTartimBirim.Properties.Assign(gleBirimler);
        }
        private void gvIsEmirOperasyonGLEAyarla()
        {
            gvIsEmirOperasyonlari.Columns["BirimId"].ColumnEdit = gleBirimler;
            gvIsEmirOperasyonlari.Columns["StokKartiId"].ColumnEdit = gleStoklar;
            gvIsEmirOperasyonlari.Columns["GenelDurum"].ColumnEdit = gleDurum;
        }
        private void gvIsEmirOperasyonIslemGLEAyarla()
        {
            gvIslemler.Columns["TartimBirim"].ColumnEdit = gleBirimler;
        }

        private string szPrinterName = "test";
        public int Secili_IsEmri { get; set; }
        public int Secili_Operasyon { get; set; }
        private void FrmOperasyonlar_Load(object sender, EventArgs e)
        {
            IsEmirleriListesi();
            btnUretimBitir.Enabled = false;
            btnUretimBaslat.Enabled = false;
            btnTartiOku.Enabled =
                        btnTartimKaydet.Enabled = false;
            var oBasim = SettingsTool.AyarOku(SettingsTool.Ayarlar.BarkodYazici_OtomatikBasim);
            if (oBasim == "False")
                tsOtomatikYazdir.IsOn = false;
            else
                tsOtomatikYazdir.IsOn = true;
            szPrinterName = SettingsTool.AyarOku(SettingsTool.Ayarlar.BarkodYazici_Name);
            Control.CheckForIllegalCrossThreadCalls = false;
            SeriPortum seriPortum = new SeriPortum();
            seriPortum.PortName = SettingsTool.AyarOku(SettingsTool.Ayarlar.HTarti_Port);
            seriPortum.BaundRate = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.HTarti_BaudRate));
            //(StatusEnum) Enum.Parse(typeof(StatusEnum), "Active", true);
            seriPortum.Parity = (Parity)Enum.Parse(typeof(Parity), SettingsTool.AyarOku(SettingsTool.Ayarlar.HTarti_Parity), true);
            seriPortum.StopBits = (StopBits)Enum.Parse(typeof(StopBits), SettingsTool.AyarOku(SettingsTool.Ayarlar.HTarti_StopBits), true);
            seriPortum.DataBits = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.HTarti_DataBits));
            //Seri Port Ayarlarını ver 

            teraziData.TeraziTamam += TeraziData_TeraziTamam;
            serialPort = new System.IO.Ports.SerialPort(seriPortum.PortName);
            serialPort.BaudRate = seriPortum.BaundRate;
            serialPort.DataBits = seriPortum.DataBits;
            serialPort.Parity = seriPortum.Parity;
            serialPort.StopBits = seriPortum.StopBits;

            serialPort.DataReceived += serialPort_DataReceived;
            GLEDoldur();
            TartiBirimi = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.HTarti_Birimi));
            txtTartimBirim.EditValue = TartiBirimi;
            TartimEkranEnable();
        }
        private void TeraziData_TeraziTamam()
        {
            decimal carpan = 1;
            serialPort.Close();
            txtTartimBirim.EditValue = TartiBirimi;

            //var birim = DataSession.StokBirimService.GetById(secili_Operasyon.BirimId);
            //if (birim.Kod.ToLower() == AppSession.Kilogram.ToLower())
            //    carpan = 1;
            //else if (birim.Kod.ToLower() == AppSession.Gram.ToLower())
            //    carpan = 1000;
            //else if (birim.Kod.ToLower() == AppSession.Ton.ToLower())
            //    carpan = 1 / 1000;
            txtTartimBrut.EditValue =
            uretimTartim.TartimBrut = Convert.ToDecimal(teraziData.Brut);// * carpan);
            txtTartimDara.EditValue =
            uretimTartim.TartimDara = Convert.ToDecimal(teraziData.Dara);// * carpan);
            txtTartimMiktar.EditValue =
            uretimTartim.TartimMiktar = Convert.ToDecimal(teraziData.Net);// * carpan);

            //System.Threading.Thread.Sleep(10000);
            Cursor.Current = Cursors.Default;
            this.UseWaitCursor = false;
            //Application.UseWaitCursor = false;
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = this.serialPort.ReadLine();
            TeraziDataParcala(data);
        }
        private void IsEmirleriListesi()
        {
            var isEmirleri = DataSession.IsEmirService.GetAll(f => f.DonemId == AppSession.Donem.Id&&f.IsEmriTipi == (int)IsEmriTipi.HammaddeTartim);// && f.KapanisTarihi == null &&
            gcIsEmirleri.DataSource = isEmirleri;
            gvIsEmirleri.ActiveFilterString = "[GenelDurumu]<>8";
        }

        private void gvIsEmirleri_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {

                if (gvIsEmirleri.GetFocusedRowCellValue(colId) != null)
                {
                    int handle = gvIsEmirleri.FocusedRowHandle;
                    Secili_IsEmri = Convert.ToInt32(gvIsEmirleri.GetFocusedRowCellValue(colId).ToString());
                    seciliIsEmri = DataSession.IsEmirService.GetById(Secili_IsEmri);
                    Tartim_Listesi();
                    gvIsEmirOperasyonGLEAyarla();
                    gvIsEmirleri.FocusedRowHandle = handle;
                    btnTartiOku.Enabled =
                        btnTartimKaydet.Enabled = false;
                    btnUretimBaslat.Enabled = false;
                    btnUretimBitir.Enabled = false;
                    gcIslemler.DataSource = null;
                }

            }
            catch
            { }
        }

        private void Tartim_Listesi()
        {
            int handle = gvIsEmirOperasyonlari.FocusedRowHandle;
            //if (handle > -1)
            var liste = DataSession.IsEmirService.GetOperasyonlarAll(f => f.IsEmriId == Secili_IsEmri);
            gcIsEmirOperasyonlari.DataSource = liste;
            gvIsEmirOperasyonlari.FocusedRowHandle = handle;
            gvIsEmirOperasyonlari.ActiveFilterString = "[GenelDurum]<>8";
            var count = gvIsEmirOperasyonlari.RowCount;
            //if (count == 0)
            //{
            //    IsEmirleriListesi();
            //    Secili_IsEmri = 0;
            //    seciliIsEmri = null;
            //}
        }

        private void gvIsEmirOperasyonlari_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (gvIsEmirOperasyonlari.GetFocusedRowCellValue(colOperasyonId) != null)
                {
                    Secili_Operasyon = Convert.ToInt32(gvIsEmirOperasyonlari.GetFocusedRowCellValue(colOperasyonId).ToString());
                    secili_Operasyon = DataSession.IsEmirService.GetOperasyonlarAll(f => f.Id == Secili_Operasyon).FirstOrDefault();
                    IslemListesi();
                    gvIsEmirOperasyonIslemGLEAyarla();
                    if (secili_Operasyon.IslemBaslamaTarihi != null)
                    {
                        TartimEkranEnable(true);
                        btnUretimBaslat.Enabled = false;
                    }
                    else
                    {
                        TartimEkranEnable();
                        btnUretimBaslat.Enabled = true;
                    }
                    if (secili_Operasyon.IslemBaslamaTarihi != null && secili_Operasyon.IslemBitisTarihi == null)
                    {
                        btnUretimBitir.Enabled = true;
                    }
                    else
                        btnUretimBitir.Enabled = false;
                    if (secili_Operasyon.GenelDurum == 8)
                    {
                        TartimEkranEnable();
                    }

                }
            }
            catch
            {

            }
        }

        private void TartimEkranEnable(bool durum = false)
        {
            btnTartiOku.Enabled =
            btnTartimKaydet.Enabled = durum;
            txtSonKullanimTarihi.Enabled=
            txtTartimBirim.Enabled=
            txtTartimBrut.Enabled=
            txtTartimDara.Enabled=
            txtTartimMiktar.Enabled=
            txtTartimKontrolEden.Enabled=
            txtTartimTartan.Enabled=
            txtTartimReferansNo.Enabled=
            txtTartimLot.Enabled = durum;
        }

        private void IslemListesi()
        {
            int handle = gvIslemler.FocusedRowHandle;
            //if (handle > -1)
            islemListesi = DataSession.IsEmirService.GetOperasyonIslemelerAll(f => f.IsEmriOperasyonId == Secili_Operasyon);
            gcIslemler.DataSource = islemListesi;
            gvIslemler.FocusedRowHandle = handle;

        }

        private void btnUretimBaslat_Click(object sender, EventArgs e)
        {
            if (secili_Operasyon.IslemBaslamaTarihi == null)
            {
                DataSession.IsEmirService.UretimBaslat(secili_Operasyon);
                Tartim_Listesi();
                btnUretimBaslat.Enabled = false;
                TartimEkranEnable(true);
            }
        }

        private void btnUretimBitir_Click(object sender, EventArgs e)
        {
            if (secili_Operasyon.IslemBaslamaTarihi != null && secili_Operasyon.IslemBitisTarihi == null)
            {
                DataSession.IsEmirService.UretimBitir(secili_Operasyon);
                Tartim_Listesi();
                btnUretimBitir.Enabled = false;
            }
        }

        private void btnTartimKaydet_Click(object sender, EventArgs e)
        {
            bool update = false;
            uretimTartim.DonemId = AppSession.Donem.Id;
            uretimTartim.IsEmriOperasyonId = secili_Operasyon.Id;
            uretimTartim.TartimLotNo = txtTartimLot.Text;
            uretimTartim.TartimReferansNo = txtTartimReferansNo.Text;
            uretimTartim.TartimTartan = txtTartimTartan.Text;
            uretimTartim.TartimKontrolEden = txtTartimKontrolEden.Text;
            uretimTartim.TartimTarihi = DateTime.Now;
            uretimTartim.TartimMiktar = Convert.ToDecimal(txtTartimMiktar.EditValue);
            uretimTartim.TartimDara = Convert.ToDecimal(txtTartimDara.EditValue);
            uretimTartim.TartimBrut = Convert.ToDecimal(txtTartimBrut.EditValue);
            uretimTartim.TartimBirim = txtTartimBirim.EditValue.ToString();
            if (txtSonKullanimTarihi.EditValue != null)
                uretimTartim.SonKullanimTarihi = Convert.ToDateTime(txtSonKullanimTarihi.EditValue);
            uretimTartim.TartimUrunId = secili_Operasyon.StokKartiId;

            if (uretimTartim.Id > 0)
                update = true;
            uretimTartim = DataSession.IsEmirService.OperasyonEkle(uretimTartim, update);
            if (tsOtomatikYazdir.IsOn == true)
            {
                //Yazıcı İşlemleri
                EtiketBas(uretimTartim);
            }
            Tartim_Listesi();
            IslemListesi();
            uretimTartim = new IsEmriOperasyonIslem();
        }

        private void txtTartimBirim_EditValueChanged(object sender, EventArgs e)
        {
            //Tarti Birimi Değişti Rakamları Değiştir.
            var stok = DataSession.StokKartService.GetById(secili_Operasyon.StokKartiId);
            if (stok != null)
            {
                decimal Carpan = DataSession.IsEmirService.TartimCarpaniBul(secili_Operasyon.StokKartiId, TartiSecilen, Convert.ToInt32(txtTartimBirim.EditValue));
                var brut = Convert.ToDouble(Carpan * Convert.ToDecimal(txtTartimBrut.EditValue));
                var dara = Convert.ToDouble(Carpan * Convert.ToDecimal(txtTartimDara.EditValue));
                var net = Convert.ToDouble(Carpan * Convert.ToDecimal(txtTartimMiktar.EditValue));
                txtTartimBrut.EditValue = brut;
                txtTartimDara.EditValue = dara;
                txtTartimMiktar.EditValue = net;
                Console.WriteLine(Carpan.ToString());
            }
            TartiSecilen = Convert.ToInt32(txtTartimBirim.EditValue);

        }

        public void TeraziDataParcala(string Data)
        {
            try
            {
                int sn = 0;
                int ln1 = 0;
                string[] parcala = Data.Replace("\r", "").Replace("\n", "").Split(',');
                sn = parcala.Length;
                try
                {
                    ln1 = parcala[1].Length;
                }
                catch (Exception ex)
                {
                    ln1 = 0;
                }
                switch (sn)
                {

                    case 5:
                        //lb_CihazAdi.Text = "Densi DCD1 İndikator";
                        //lb_Gosterge.Text = parcala[2];
                        //lb_GostergeDara.Text = parcala[3].Replace("T=", "");
                        if (!(Temp != parcala[2]) || !(parcala[0] == "ST"))
                            break;
                        decimal kilo = 0;
                        if (parcala[2].Substring(0, 1) == "+")
                        {
                            kilo = Convert.ToDecimal(parcala[2].Replace("+", "").Replace(".", ","));

                        }
                        else
                        {
                            kilo = Convert.ToDecimal(parcala[2].Replace("-", "").Replace(".", ","));
                            kilo *= -1;

                        }

                        decimal dara = Convert.ToDecimal(parcala[3].Replace("T=", "").Replace(".", ","));
                        decimal brüt = kilo + dara;
                        teraziData.Birim = parcala[4];
                        teraziData.Brut = brüt;
                        teraziData.Dara = dara;
                        teraziData.Net = kilo;
                        teraziData.Tarih = DateTime.Now;
                        //datakayit(this.lb_Gosterge.Text, parcala[3], parcala[4], Convert.ToString(brüt));
                        Temp = parcala[2];
                        break;

                }
                //dataGridView_Deger.CurrentCell = this.dataGridView_Deger.Rows[0].Cells[0];
            }
            catch
            {

            }
        }

        private void btnHammaddeFoyYazdir_Click(object sender, EventArgs e)
        {
            int handle = gvIsEmirleri.FocusedRowHandle;
            if (handle > -1)
            {
                Cursor.Current = Cursors.WaitCursor;
                this.UseWaitCursor = true;
                xrHammadeKontrolFoyu xr = new xrHammadeKontrolFoyu();
                var UretimEmir = DataSession.IsEmirService.GetById(intParse(gvIsEmirleri.GetRowCellValue(gvIsEmirleri.FocusedRowHandle, "Id")));
                UretimEmir.IsEmriOperasyon = DataSession.IsEmirService.GetOperasyonlarAll(f => f.IsEmriId == UretimEmir.Id);
                var StokKarti = DataSession.StokKartService.GetById(UretimEmir.StokKartiId);
                var data = DataSession.IsEmirService.HammaddeKontrolFoyuOlustur(UretimEmir.Id);
                var data2 = data.DistinctBy(a => new { a.StokKodu, a.TeorikMiktar }).ToList();
                xr.DataSource = data2;
                var Durumu = "";
                if (UretimEmir.GenelDurumu == 8)
                {
                    decimal toplam = 0;
                    foreach (var item in data2)
                    {
                        var count = DataSession.IsEmirService.TartimCarpaniBul(UretimEmir.StokKartiId, item.BirimId, UretimEmir.BirimId);
                        var Miktar = (item.ReelMiktar - item.TeorikMiktar) * count;
                        var Fark = (item.ReelMiktar - item.TeorikMiktar);
                        if (Fark != 0)
                        {
                            Durumu += String.Format("{0}-{1} Fark {2} {3}", item.StokKodu, item.Stok.Ad, Convert.ToDouble(Fark).ToString(), item.Birim);
                            Durumu += Environment.NewLine;
                        }
                        toplam += Miktar;
                    }
                    if (toplam != 0)
                        Durumu += String.Format("Toplamda {0} {1} {2}", Convert.ToDouble(toplam).ToString(), DataSession.StokBirimService.GetById(UretimEmir.BirimId).Kod,
                            toplam > 0 ? "Üretim Fazlası" : "Üretim Eksiği");
                }
                //Üst Bilgileri Aktarılacak
                xr.xrQRCODE.Text = UretimEmir.Id.ToString() + " - " + UretimEmir.Aciklama + " - www.sanmark.com.tr";
                xr.xrlblSeriNo.Text = UretimEmir.PartiNo;
                xr.xrlblStokKodu.Text = StokKarti.Kod;
                xr.xrlblUrunAdi.Text = StokKarti.Ad;

                if (UretimEmir.BaslamaTarihi != null)
                    xr.xrlblTarih.Text = UretimEmir.BaslamaTarihi.Value.ToShortDateString();
                else
                    xr.xrlblTarih.Text = UretimEmir.PlanlananBaslangicTarihi.Value.ToShortDateString();

                xr.xrlblRevizyonNo.Text = DataSession.UrunReceteService.GetById(UretimEmir.IsEmriOperasyon.FirstOrDefault().UrunReceteId).RevizyonNo.ToString();
                xr.xrlblSarjBoyu.Text = UretimEmir.Miktar.ToString() + " " + DataSession.StokBirimService.GetById(StokKarti.StokBirimId).Kod;
                xr.xrlblDurumu.Text = "Notlar :" + Environment.NewLine + Durumu;
                AppSession.MainForm.ShowMdiChildForm(typeof(ReportViewer), xr, AppSession.Sirket.Email + ";" + AppSession.CurrentUser.Email, "Tartim:" + UretimEmir.Aciklama + "-" + UretimEmir.Id);
                //var tool = new ReportPrintTool(xr);
                //tool.ShowPreview();
                Cursor.Current = Cursors.Default;
                this.UseWaitCursor = false;
            }
        }

        private void bbiGuncelle_Click(object sender, EventArgs e)
        {
            IsEmirleriListesi();
        }

        private void txtTartimLot_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTartimLot_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmLotBul frmLotBul = new FrmLotBul(secili_Operasyon.StokKartiId);
            frmLotBul.ShowDialog();
            if (frmLotBul.secildi)
            {
                txtTartimLot.Text = frmLotBul.SecilenLot;
                txtTartimReferansNo.Text = frmLotBul.SecilenRef;
                if (frmLotBul.SecilenSTK != "")
                    txtSonKullanimTarihi.EditValue = Convert.ToDateTime(frmLotBul.SecilenSTK);
                else
                    txtSonKullanimTarihi.EditValue = null;
                txtTartimTartan.Focus();
            }
        }

        private void btnTartiOku_Click(object sender, EventArgs e)
        {
            try
            {
                this.UseWaitCursor = true;
                if (!serialPort.IsOpen)
                    serialPort.Open();
                //Cursor.Current = Cursors.WaitCursor;

            }
            catch { MessageBox.Show("Port Okuma Hatası"); }
        }

        private void EtiketBas(IsEmriOperasyonIslem uretimTartim)
        {
            var operasyon = DataSession.IsEmirService.GetOperasyonlarAll(f => f.Id == uretimTartim.IsEmriOperasyonId).FirstOrDefault();
            var urunEmir = DataSession.IsEmirService.GetById(operasyon.IsEmriId);

            var stokKart = DataSession.StokKartService.GetById(Convert.ToInt32(uretimTartim.TartimUrunId));
            var stokKartAna = DataSession.StokKartService.GetById(urunEmir.StokKartiId);
            //var UrunAgac = DataSession.UrunAgaciService.GetById(DataSession.UrunAgaciService.GetAll(f => f.StokId == urunEmir.UrunId).OrderByDescending(u => u.RevizyonNo).FirstOrDefault().Id);
            var stokBirimi = DataSession.StokBirimService.GetById(Convert.ToInt32(uretimTartim.TartimBirim));
            //
            //var file =Core.GenericExtensions.GetResourceStream(resName);
            String tempFile = Application.StartupPath.ToString() + "\\RP80VI_001.bin";
            StreamReader SR = new StreamReader(tempFile, Encoding.Default);
            String all = SR.ReadToEnd();

            all += "PRINT 1,1\r\n";
            all = all.Replace("*TARIH*", DateTime.Now.ToShortDateString());
            all = all.Replace("*SAAT", DateTime.Now.ToShortTimeString());
            all = all.Replace("*URUNAD*", stokKartAna.Ad);//16 KARAKTER
            all = all.Replace("ÜRÜN ADI     :", "ÜRÜN ADI     : " + stokKartAna.Kod);
            all = all.Replace("*URUNSERINO*", urunEmir.PartiNo);
            all = all.Replace("*HAMMADDEAD*", stokKart.Ad);
            all = all.Replace("HAMMADDE ADI:", "HAMMADDE ADI: " + stokKart.Kod);
            all = all.Replace("*BATCHNO*", uretimTartim.TartimLotNo);
            all = all.Replace("*KALITENO*", uretimTartim.TartimReferansNo);
            all = all.Replace("*OPERATOR*", uretimTartim.TartimTartan);
            all = all.Replace("*NET*", Convert.ToDecimal(uretimTartim.TartimMiktar).ToString() + " " + stokBirimi.Kod);
            all = all.Replace("*DARA*", Convert.ToDecimal(uretimTartim.TartimDara).ToString() + " " + stokBirimi.Kod);
            all = all.Replace("*BRUT*", Convert.ToDecimal(uretimTartim.TartimBrut).ToString() + " " + stokBirimi.Kod);
            all = all.Replace("QRCODE 24,12,Q,1,B,0,", "QRCODE 15,34,M,4,B,0,");
            all = all.Replace("*KOD", uretimTartim.Id.ToString());
            RawPrinterHelper.SendStringToPrinter(szPrinterName, all);
        }
    }
}
