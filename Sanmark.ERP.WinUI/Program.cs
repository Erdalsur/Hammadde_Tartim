using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraSplashScreen;
using Microsoft.VisualBasic.ApplicationServices;
using Sanmark.Core.Utilities;
using Sanmark.Core.Utilities.Win.Infrastructure;
using Sanmark.Erp.Framework.DependencyResolvers.Ninject;
using System;
<<<<<<< HEAD
using System.Configuration;
using System.Linq;
=======
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
>>>>>>> 8e1775e... Add project files.
using System.Windows.Forms;

namespace Sanmark.ERP.WinUI
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //try
            //{
            InitLookAndFeel();
            //}
            //catch { MessageBox.Show("InitLookAndFeel Hatası"); }

            //try
            {
                CompositionRootNinject.Wire(new ValidationModule());
                CompositionRootNinject.Wire(new BusinessModule());
            }
            //catch { MessageBox.Show("Ninject Modül Yüklenme Hatası"); }
            //Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            //SingleInstanceController instanceController = new SingleInstanceController();
            //try
            //{
            //    string[] args = new string[] { };
            //    instanceController.Run(args);
            //}
            //catch
            //{

            //}
            AppSession.ApplicationName = "Sanmark Tartı Takip";
            using (FrmLogin frmLogin = new FrmLogin())
                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    UserSession.CurrentUser = AppSession.CurrentUser;
                    UserSession.Donem = AppSession.Donem;
                    UserSession.Sirket = AppSession.Sirket;
                    SplashScreenManager.ShowForm(typeof(SplashLogin));
                    //new AppSession();
                    //UserLookAndFeel.Default.SetSkinStyle(AppSession.Settings.SkinName);
                    AppSession.MainForm = new FrmMainRibbon();
                    AppSession.MainForm.WindowState = FormWindowState.Minimized;
                    AppSession.MainForm.ShowInTaskbar = false;
                    AppSession.Kilogram = SettingsTool.AyarOku(SettingsTool.Ayarlar.Birimler_Kilogram);
                    AppSession.Gram = SettingsTool.AyarOku(SettingsTool.Ayarlar.Birimler_Gram);
                    AppSession.Ton = SettingsTool.AyarOku(SettingsTool.Ayarlar.Birimler_Ton);
                    Application.Run(AppSession.MainForm);
                    //MainForm = AppSession.MainForm;

                }
                else
                {
                    Form form = new Form();
                    //MainForm = form;
                    form.Close();
                }
        }
        
        private static void InitLookAndFeel()
        {
            
            string connectionString="";
            //try
            //{
                
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var Server = SettingsTool.AyarOku(SettingsTool.Ayarlar.DataSetting_Host);
                var DataBaseName = SettingsTool.AyarOku(SettingsTool.Ayarlar.DataSetting_DataBase);
                var Kullanici = SettingsTool.AyarOku(SettingsTool.Ayarlar.DataSetting_User);
                var SifreHash = SettingsTool.AyarOku(SettingsTool.Ayarlar.DataSetting_Password);
                var Sifre = SettingsTool.AyarOku(SettingsTool.Ayarlar.DataSetting_Password);//CryptoManager.SifreCoz(SifreHash);
            connectionString = String.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                    Server, DataBaseName, Kullanici, Sifre);
                config.ConnectionStrings.ConnectionStrings["ErpContext"].ConnectionString = connectionString;
                config.Save(ConfigurationSaveMode.Modified);
            //}
            //catch { MessageBox.Show("Ini Yüklenme Hatası"); }

           // try
            {
                Application.EnableVisualStyles();
                SkinManager.EnableFormSkins();
                //BonusSkins.Register();
                SkinManager.Default.RegisterAssembly(typeof(OfficeSkins).Assembly);
                //SkinManager.Default.RegisterAssembly(typeof(BonusSkins).Assembly);
                Application.SetCompatibleTextRenderingDefault(false);
            }
            //catch { MessageBox.Show("Template Yüklenme Hatası"); }
            DataBaseOlusturma.Olustur(connectionString);

        }
    }
    public class SingleInstanceController : WindowsFormsApplicationBase
    {
        public SingleInstanceController()
        {
            this.IsSingleInstance = true;
            this.StartupNextInstance += new StartupNextInstanceEventHandler(this.This_StartupNextInstance);
        }
        public void This_StartupNextInstance(object sender, StartupNextInstanceEventArgs e)
        {
            e.BringToForeground = false;
        }
        protected override void OnCreateMainForm()
        {
            AppSession.ApplicationName = "Sanmark Tartı Takip";
            using (FrmLogin frmLogin = new FrmLogin())
                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    UserSession.CurrentUser = AppSession.CurrentUser;
                    UserSession.Donem = AppSession.Donem;
                    UserSession.Sirket = AppSession.Sirket;
                    SplashScreenManager.ShowForm(typeof(SplashLogin));
                    //new AppSession();
                    //UserLookAndFeel.Default.SetSkinStyle(AppSession.Settings.SkinName);
                    AppSession.MainForm = new FrmMainRibbon();
                    AppSession.MainForm.WindowState = FormWindowState.Minimized;
                    AppSession.MainForm.ShowInTaskbar = false;
                    AppSession.Kilogram= SettingsTool.AyarOku(SettingsTool.Ayarlar.Birimler_Kilogram);
                    AppSession.Gram = SettingsTool.AyarOku(SettingsTool.Ayarlar.Birimler_Gram);
                    AppSession.Ton = SettingsTool.AyarOku(SettingsTool.Ayarlar.Birimler_Ton);
                    MainForm = AppSession.MainForm;
                }
                else
                {
                    Form form = new Form();
                    MainForm = form;
                    form.Close();
                }
        }
    }
}

