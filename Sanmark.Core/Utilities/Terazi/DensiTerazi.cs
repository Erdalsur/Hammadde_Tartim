using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Threading;

namespace Sanmark.Core.Utilities.Terazi
{
    public class DensiTerazi : ITerazi
    {
        public BackgroundWorker _backgroundWorker;
        public TeraziData TeraziData { get; set; }
        private decimal Temp_Dara { get; set; }
        public bool DataOk { get; set; }

        SerialPort serialPort = new SerialPort();

        private string Serial_Data;
        private static string Temp = "";
        private decimal Temp_Net;

        public DensiTerazi()
        {
            DataOk = false;
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.WorkerReportsProgress = true; //backgroundWorker1 için işlemin ilerlemesini raporlama aktif edildi
            _backgroundWorker.WorkerSupportsCancellation = true; //backgroundWorker1 için işlemin durdurulabilme aktif edildi
            _backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            _backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(_backgroundWorker_RunWorkerCompleted);

        }

        private void _backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SerialPortKapat();
        }

        private void SerialPortKapat()
        {
            serialPort.Close();
        }

        public void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while(!DataOk)
            {
                Serial_Data = serialPort.ReadLine();
                TeraziData = TeraziDataParcala(Serial_Data);
            }
            
        }

        private TeraziData TeraziDataParcala(string Data)
        {
            TeraziData = new TeraziData();
            string[] strArray = Data.Replace("\r", "").Replace("\n", "").Split(',');
            int length = strArray.Length;
            int num;
            try
            {
                num = strArray[1].Length;
            }
            catch (Exception ex)
            {
                num = 0;
            }

            switch(length)
            {
                case 5:
                    if (strArray[0] == "ST")//Temp != strArray[2] && 
                    {
                        //Nesneye Aktar
                        Temp_Dara = Convert.ToDecimal(strArray[3].Replace("T=", "").Replace(".",","));
                        if (strArray[2].Substring(0, 1) == "+")
                            Temp_Net = Convert.ToDecimal(strArray[2].Replace("+", "").Replace(".", ","));
                        if (strArray[2].Substring(0, 1) == "-")
                            Temp_Net = Convert.ToDecimal(strArray[2].Replace("+", "").Replace(".", ",")) *-1;
                        TeraziData.Tarih = DateTime.Now;
                        TeraziData.Adet = 1;
                        TeraziData.Net = Temp_Net;
                        TeraziData.Dara = Temp_Dara;
                        TeraziData.Brut = Temp_Net + Temp_Dara;
                        TeraziData.Birim = strArray[4];
                        Temp = strArray[2];
                        DataOk = true;
                        break;
                    }
                    break;

                default:
                    
                    break;

            }

            return TeraziData;
        }

        private void SerialPortAc()
        {
            if (serialPort.IsOpen)
                serialPort.Close();
            serialPort.PortName = "Com2";
            serialPort.BaudRate = 9600;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.DataBits = 8;
            serialPort.Handshake = Handshake.None;

            serialPort.RtsEnable = true;
            serialPort.ReadTimeout = 500;
            serialPort.WriteTimeout = 500;
            serialPort.Open();

        }

        public void Baglan()
        {
            if (_backgroundWorker.IsBusy!=true)
            {
                SerialPortAc();
                DataOk = false;
                TeraziData = null;
                _backgroundWorker.RunWorkerAsync();
            }
        }

        class Hata : Exception
        {
            public Hata() : base("Terazi Bağlantı Sorunu")
            { }
        }

    }
}
