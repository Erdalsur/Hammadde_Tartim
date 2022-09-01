using DevExpress.XtraEditors;
using Sanmark.Core.Utilities.Terazi;
using Sanmark.Core.Utilities.Win.Infrastructure;
using Sanmark.Core.Utilities.Yazici;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Entities.Concrete.Uretim;
using Sanmark.ERP.WinUI.BaseForms;
using Sanmark.ERP.WinUI.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanmark.ERP.WinUI.Uretim
{
    public partial class FrmTartim : XPopupForm
    {
        
        private SerialPort serialPort;
        private string Temp = "";
        public UretimEmirDetaylari _detay = new UretimEmirDetaylari();
        public StokKarti stokKarti = new StokKarti();
        public StokBirim stokBirim = new StokBirim();
        public UretimTartimlari uretimTartim;
        private TeraziData teraziData = new TeraziData();
        public FrmTartim()
        {
            InitializeComponent();
            uretimTartim = new UretimTartimlari();
        }

        private void FrmTartim_Load(object sender, EventArgs e)
        {
            szPrinterName = SettingsTool.AyarOku(SettingsTool.Ayarlar.BarkodYazici_Name);
            Control.CheckForIllegalCrossThreadCalls = false;
            stokKarti = DataSession.StokKartService.GetById(_detay.UrunId);
            stokBirim = DataSession.StokBirimService.GetById(stokKarti.StokBirimId);
            lblUrunAd.Text = stokKarti.Ad;
            lblDara.Text = "";
            this.Text = lblUrunAd.Text + " - " + _detay.Miktar.ToString() + " " + DataSession.StokBirimService.GetById(stokKarti.StokBirimId).Kod;
            txtKontrolEden.Text = uretimTartim.KontrolEden;
            txtLot.Text = uretimTartim.LotNo;
            txtMiktar.EditValue = uretimTartim.Miktar;
            txtReferans.Text = uretimTartim.ReferansNo;
            if (uretimTartim.TartimTarihi == null)
                txtSKT.Value = DateTime.Now;
            else
                txtSKT.Value = (DateTime)uretimTartim.TartimTarihi;
            txtTartan.Text = uretimTartim.Tartan;

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
        }

        private void TeraziData_TeraziTamam()
        {
            decimal carpan = 1;
            serialPort.Close();
            if (stokBirim.Kod.ToLower() == AppSession.Kilogram.ToLower())
                carpan = 1;
            else if (stokBirim.Kod.ToLower() == AppSession.Gram.ToLower())
                carpan = 1000;
            else if (stokBirim.Kod.ToLower() == AppSession.Ton.ToLower())
                carpan = 1 / 1000;
            uretimTartim.Brut = Convert.ToDecimal(teraziData.Brut * carpan);
            uretimTartim.Dara = Convert.ToDecimal(teraziData.Dara * carpan);
            txtMiktar.EditValue =
            uretimTartim.Miktar = Convert.ToDecimal(teraziData.Net * carpan);
            uretimTartim.Birim = stokBirim.Kod;
            lblDara.Text = "Dara: " + uretimTartim.Dara.ToString() + "  -   Brüt: " + uretimTartim.Brut.ToString() + " " + uretimTartim.Birim;
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

        private void bbiKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uretimTartim.KontrolEden = txtKontrolEden.Text.Trim();
            uretimTartim.LotNo = txtLot.Text.Trim();
            uretimTartim.Miktar = (decimal)txtMiktar.EditValue;
            uretimTartim.Brut = uretimTartim.Dara + uretimTartim.Miktar;
            uretimTartim.ReferansNo = txtReferans.Text.Trim();
            uretimTartim.SKT = txtSKT.Value;
            uretimTartim.Tartan = txtTartan.Text.Trim();
            if (uretimTartim.TartimTarihi == null)
                uretimTartim.TartimTarihi = DateTime.Now;
            uretimTartim.UrunId = stokKarti.Id;

            //uretimTartim.UretimEmirDetay = _detay;
            uretimTartim.UretimEmirDetayId = _detay.Id;
            uretimTartim = DataSession.UretimService.Tartim_Kayit(uretimTartim);
            if (SettingsTool.AyarOku(SettingsTool.Ayarlar.BarkodYazici_OtomatikBasim) == "True")
                EtiketBas(uretimTartim);
            this.DialogResult = DialogResult.OK;

        }
        private string szPrinterName = "test";
        private void EtiketBas(UretimTartimlari uretimTartim)
        {
            var urunEmir = DataSession.UretimService.GetById(_detay.UretimEmirId);

            var stokKart = DataSession.StokKartService.GetById(uretimTartim.UrunId);
            var stokKartAna = DataSession.StokKartService.GetById(urunEmir.UrunId);
            var UrunAgac = DataSession.UrunAgaciService.GetById(DataSession.UrunAgaciService.GetAll(f => f.StokId == urunEmir.UrunId).OrderByDescending(u => u.RevizyonNo).FirstOrDefault().Id);
            //
            //var file =Core.GenericExtensions.GetResourceStream(resName);
            String tempFile = Application.StartupPath.ToString() + "\\RP80VI_001.bin";
            StreamReader SR = new StreamReader(tempFile, Encoding.Default);
            String all = SR.ReadToEnd();
            //string all = "";
            //all = GetFromResources(resName);
            //using (var reader = new StreamReader(file))
            //{
            //    all = reader.ReadToEnd();
            //}
            all += "PRINT 1,1\r\n";
            all = all.Replace("*TARIH*", DateTime.Now.ToShortDateString());
            all = all.Replace("*SAAT", DateTime.Now.ToShortTimeString());
            all = all.Replace("*URUNAD*", UrunAgac.Aciklama);//16 KARAKTER
            all = all.Replace("ÜRÜN ADI     :", "ÜRÜN ADI     : " + UrunAgac.Kod);
            all = all.Replace("*URUNSERINO*", urunEmir.SeriNo);
            all = all.Replace("*HAMMADDEAD*", stokKarti.Ad);
            all = all.Replace("HAMMADDE ADI:", "HAMMADDE ADI: " + stokKarti.Kod);
            all = all.Replace("*BATCHNO*", uretimTartim.LotNo);
            all = all.Replace("*KALITENO*", uretimTartim.ReferansNo);
            all = all.Replace("*OPERATOR*", uretimTartim.Tartan);
            all = all.Replace("*NET*", Convert.ToDecimal(uretimTartim.Miktar).ToString() + " " + stokBirim.Kod);
            all = all.Replace("*DARA*", Convert.ToDecimal(uretimTartim.Dara).ToString() + " " + stokBirim.Kod);
            all = all.Replace("*BRUT*", Convert.ToDecimal(uretimTartim.Brut).ToString() + " " + stokBirim.Kod);
            all = all.Replace("QRCODE 24,12,Q,1,B,0,", "QRCODE 15,34,M,4,B,0,");
            all = all.Replace("*KOD", uretimTartim.Id.ToString());
            RawPrinterHelper.SendStringToPrinter(szPrinterName, all);
        }

        internal static string GetFromResources(string resourceName)
        {
            Assembly assem = Assembly.GetExecutingAssembly();

            using (Stream stream = assem.GetManifestResourceStream(assem.GetName().Name + '.' + resourceName))
            {
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EtiketBas(uretimTartim);
        }
    }
}
