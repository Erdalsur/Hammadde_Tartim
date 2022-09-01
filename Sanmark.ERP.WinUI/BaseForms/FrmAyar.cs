using DevExpress.XtraEditors.Repository;
using Microsoft.Win32;
using Sanmark.Core.Utilities;
using Sanmark.Core.Utilities.Win.Infrastructure;
using Sanmark.ERP.WinUI.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanmark.ERP.WinUI.BaseForms
{
    public partial class FrmAyar : XPopupForm
    {
        
        Configuration config, config2;
        public List<string> DataBaseBilgi = null;
        public FrmAyar()
        {
            InitializeComponent();
            
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string configPath = Path.Combine(System.Environment.CurrentDirectory, "Sanmark.ERP.WinUI.exe");
            try
            {
                config2 = ConfigurationManager.OpenExeConfiguration(configPath);
            }
            catch { }
        }

        private void YukluSQL()
        {
            string[] yuklusqller = (string[])Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Microsoft").OpenSubKey("Microsoft SQL Server").GetValue("InstalledInstances");
            var yukluozellikler = (from s in yuklusqller
                                   where s.Contains("SQLEXPRESS")
                                   select s).FirstOrDefault();
            if (yuklusqller == null)
            {
                MessageBox.Show("Programı kullanabilmek için SQL Server yüklenmelidir.", "UYARI");
                Application.Exit();
            }
            /*
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        comboBoxEdit1.(Environment.MachineName + @"\" + instanceName);
                    }
                }
            }*/
        }
        private void FrmAyar_Load(object sender, EventArgs e)
        {
            RepositoryItemGridLookUpEdit gleBirimler = GetCustomGLE(DataSession.StokBirimService.GetAll(s => s.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleBirimler.View.OptionsView.ColumnAutoWidth = true;
            gleTartiBirimi.Properties.Assign(gleBirimler);
            gleTartiBirimi.Properties.View.Columns["KayitTarihi"].Visible =
                gleTartiBirimi.Properties.View.Columns["DegistirmeTarihi"].Visible =
                gleTartiBirimi.Properties.View.Columns["KayitUserId"].Visible =
                gleTartiBirimi.Properties.View.Columns["DegistirmeUserId"].Visible =
            gleTartiBirimi.Properties.View.Columns["SirketId"].Visible = false;
            gleTartiBirimi.Properties.View.BestFitColumns();
            RepositoryItemGridLookUpEdit gleDepolar = GetCustomGLE(DataSession.DepoService.GetAll(s => s.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleDepolar.View.OptionsView.ColumnAutoWidth = true;
            gleDepo.Properties.Assign(gleDepolar);
            gleDepo.Properties.View.Columns["KayitTarihi"].Visible =
                gleDepo.Properties.View.Columns["DegistirmeTarihi"].Visible =
                gleDepo.Properties.View.Columns["KayitUserId"].Visible =
                gleDepo.Properties.View.Columns["DegistirmeUserId"].Visible =
            gleDepo.Properties.View.Columns["SirketId"].Visible = false;
            gleDepo.Properties.View.BestFitColumns();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                cmbYazici.Properties.Items.Add(printer);
                
            }
            gleDepo.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.Depo_VarsayilanDepo);
            gleTartiBirimi.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.HTarti_Birimi);
            cmbYazici.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.BarkodYazici_Name); //IniFile.VeriOku("BarkodYazici", "Name");
            cmbR232.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.HTarti_Port);//IniFile.VeriOku("HTarti", "Port");
            cmbBaudRate.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.HTarti_BaudRate); //IniFile.VeriOku("HTarti", "BaudRate");
            cmbParity.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.HTarti_Parity);//IniFile.VeriOku("HTarti", "Parity");
            cmbDataBits.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.HTarti_DataBits);//IniFile.VeriOku("HTarti", "DataBits");
            cmbStopBits.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.HTarti_StopBits);//IniFile.VeriOku("HTarti", "StopBits");
            txtKilo.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.Birimler_Kilogram);//IniFile.VeriOku("Birimler", "Kilogram");
            txtGram.Text= SettingsTool.AyarOku(SettingsTool.Ayarlar.Birimler_Gram);//IniFile.VeriOku("Birimler", "Gram");
            txtTon.Text= SettingsTool.AyarOku(SettingsTool.Ayarlar.Birimler_Ton);//IniFile.VeriOku("Birimler", "Ton");
            if (SettingsTool.AyarOku(SettingsTool.Ayarlar.BarkodYazici_OtomatikBasim) == "True")
                chkBarkodYazdir.EditValue = true;
            DatabaseBilgiOku();
            string new_path = Application.StartupPath + "\\Logo\\MyLogo.png";
            LogoYukle(new_path);
        }
        private void DatabaseBilgiOku()
        {
            string databasestring = GetConnectionString("ErpContext");
            DataBaseBilgi = databasestring.ReverseStringFormat("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}");
            txtServer.EditValue = DataBaseBilgi[0];
            txtDatabaseName.EditValue = DataBaseBilgi[1];
            txtKullanici.EditValue = DataBaseBilgi[2];
            txtSifre.EditValue = DataBaseBilgi[3];
        }
        public string GetConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }
        //Save connection string to App.config file
        public void SaveConnectionString(string key, string value)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void txtServer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.UseWaitCursor = true;
            this.Cursor = Cursors.WaitCursor;
            string[] servers = SqlLocator.GetServers();
            this.Cursor = Cursors.Default;
            this.UseWaitCursor = false;
            if (servers == null)
            {
                int num = (int)MessageBox.Show("Programı kullanabilmek için SQL Server yüklenmelidir.", "SQL Server");
            }
            else
            {
                string str = FrmSQLList.DoPickServer(servers);
                if (str != string.Empty)
                    this.txtServer.Text = str;
            }
            this.txtServer.Focus();
        }

        private void bbiKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            string new_path = Application.StartupPath + "\\Logo\\MyLogo.png";
            LogoKaydet(new_path);
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.Genel_LogoYolu, new_path);
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.HTarti_Port, cmbR232.EditValue.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.HTarti_BaudRate, cmbBaudRate.EditValue.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.HTarti_Parity, cmbParity.EditValue.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.HTarti_DataBits, cmbDataBits.EditValue.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.HTarti_StopBits, cmbStopBits.EditValue.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.HTarti_Birimi, gleTartiBirimi.EditValue.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.BarkodYazici_Name, cmbYazici.EditValue.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.BarkodYazici_OtomatikBasim, chkBarkodYazdir.EditValue.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.Birimler_Kilogram, txtKilo.Text.Trim());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.Birimler_Gram, txtGram.Text.Trim());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.Birimler_Ton, txtTon.Text.Trim());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DataSetting_Host, txtServer.EditValue.ToString().Trim());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DataSetting_DataBase, txtDatabaseName.EditValue.ToString().Trim());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DataSetting_User, txtKullanici.EditValue.ToString().Trim());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.Depo_VarsayilanDepo, gleDepo.EditValue.ToString());
            var sifre = txtSifre.EditValue.ToString().Trim();
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DataSetting_Password, (sifre));
            AppSession.Gram = txtGram.Text.Trim();
            AppSession.Kilogram = txtKilo.Text.Trim();
            AppSession.Ton = txtTon.Text.Trim();
            var connectionString= String.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                txtServer.EditValue.ToString().Trim(), txtDatabaseName.EditValue.ToString().Trim(), txtKullanici.EditValue.ToString().Trim(), txtSifre.EditValue.ToString().Trim());
            config.ConnectionStrings.ConnectionStrings["ErpContext"].ConnectionString = connectionString;
            config.Save(ConfigurationSaveMode.Modified);
            Properties.Settings.Default.Upgrade();
            try
            {
                config2.ConnectionStrings.ConnectionStrings["ErpContext"].ConnectionString = connectionString;
                config2.Save();
                
            }
            catch { }
            DataBaseOlusturma.Olustur(connectionString);
            SettingsTool.Save();
            Application.Restart();
        }

        private void LogoKaydet(string path)
        {
            try
            {
                bool Kontrol = Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"Logo\");
            if (!Kontrol)
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"Logo\");
            Image img = (Image)pictureEdit1.Image.Clone();
            img.Save(path, System.Drawing.Imaging.ImageFormat.Png);
            }
            catch { }
            LogoYukle(path);

        }
        private void LogoYukle(string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                pictureEdit1.Image = Image.FromStream(fs);
                fs.Flush();
                fs.Close();
            }
            catch { }
            
        }
    }
}
