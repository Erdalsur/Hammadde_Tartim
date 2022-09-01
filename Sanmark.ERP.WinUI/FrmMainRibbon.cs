using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Sanmark.ERP.WinUI.Sirketler;
using Sanmark.Core.Utilities.Win.Infrastructure;
using Sanmark.ERP.WinUI.BaseForms;
using DevExpress.XtraEditors;
using Sanmark.Erp.Framework.Abstract;
using DevExpress.XtraSplashScreen;
using Sanmark.ERP.WinUI.Stoklar;
using DevExpress.XtraBars.Ribbon;
using Sanmark.ERP.WinUI.Cariler;
using Sanmark.ERP.WinUI.Uretim;
using System.Security.Cryptography;
using System.Web.Security;
using System.Security;
using Sanmark.ERP.WinUI.Core;
using DevExpress.XtraEditors.Repository;
using Sanmark.Core.Utilities.Tipler;

namespace Sanmark.ERP.WinUI
{
    public partial class FrmMainRibbon : RibbonForm
    {
        public RepositoryItemGridLookUpEdit gleUser;
        public Dictionary<string, XForm> forms = new Dictionary<string, XForm>();
        public XForm ActiveXForm = null;
        public FrmMainRibbon()
        {
            InitializeComponent();
        }

        private void FrmMainRibbon_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            this.Hide();
            
            try
            {
                new AppSession();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Restart();
                return;
            }
            Text = AppSession.ApplicationName;
            this.KeyPreview = true;
            this.KeyDown += FrmMainRibbon_KeyDown;
            bsiDonem.Caption = AppSession.Donem.Yil.ToString();
            bsiDonem.Hint = AppSession.Donem.Baslangic.ToLongDateString() + "-" + AppSession.Donem.Bitis.ToLongDateString();
            bsiSirket.Caption = AppSession.Sirket.Ad;
            bsiUser.Caption = AppSession.CurrentUser.FirstName + " " + AppSession.CurrentUser.LastName;
            gleUser= GetCustomGLE(
                            DataSession.UserService.GetAll().Select(s => new { Id = s.Id, UserName = s.UserName, Ad = s.FirstName+" "+s.LastName }).ToList(), "Ad", "Id");

        }

        public RepositoryItemGridLookUpEdit GetCustomGLE<T>(List<T> liste, string displayMember, string valueMember)
        {
            RepositoryItemGridLookUpEdit ri = XForm.GetGLESablon(liste, displayMember, valueMember);

            // ri.View.Columns.Clear();
            ri.View.Columns["Id"].Visible = false;
            return ri;
        }
        private void FrmMainRibbon_Shown(object sender, EventArgs e)
        {
            AppSession.MainForm.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Maximized;
            this.Show();
            this.ResumeLayout();
            SplashScreenManager.CloseDefaultSplashScreen();
            
        }
        void FrmMainRibbon_KeyDown(object sender, KeyEventArgs e)
        {
            //Kısayollar yapılacak
        }

        public void NotifyMain(string message)
        {
            bsiInfo.Caption = DateTime.Now.ToLongTimeString() + " | " + message;
        }


        #region Form Açma
        //private string GetHash(Type type, object[] prm)
        //{
        //    string str = "";
        //    foreach (object obj in prm)
        //        str += (string)(object)obj.GetHashCode();
        //    return type.GetHashCode().ToString() + "." + str;
        //}
        //public XForm GetActiveForm(Type type, params object[] prm)
        //{
        //    string hash = this.GetHash(type, prm);
        //    forms.TryGetValue(hash, out XForm xform);
        //    if (xform != null)
        //    {
        //        if (!xform.IsDisposed)
        //        {
        //            xform.Activate();
        //            return xform;
        //        }
        //        forms.Remove(hash);
        //    }
        //    return (XForm)null;
        //}

        //public XForm ShowMdiChildForm(Type type, params object[] prm)
        //{
        //    XForm xform = this.GetActiveForm(type, prm);
        //    if (xform != null)
        //    {
        //        this.ActiveXForm = xform;
        //        return xform;
        //    }
        //    try
        //    {
        //        if (type.BaseType == typeof(XPopupForm))
        //        {
        //            using (XPopupForm instance = (XPopupForm)Activator.CreateInstance(type, prm))
        //            {
        //                this.ActiveXForm = (XForm)instance;
        //                xform = (XForm)instance;
        //                int num = (int)instance.ShowDialog();
        //            }
        //        }
        //        else
        //        {
        //            xform = (XForm)Activator.CreateInstance(type, prm);
        //            xform.MdiParent = (Form)this;
        //            xform.WindowState = FormWindowState.Maximized;
        //            this.forms.Add(this.GetHash(type, prm), xform);
        //            this.ActiveXForm = xform;
        //            xform.Show();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        int num = (int)XtraMessageBox.Show(ex.InnerException.ToString());
        //    }
        //    return xform;
        //}
        public XForm GetActiveForm(Type type, params object[] prm)
        {
            XForm frm;
            string hash = CryptoManager.GetObjectHash(type, prm);

            forms.TryGetValue(hash, out frm);

            if (frm != null)
                if (!frm.IsDisposed)
                {
                    frm.Activate();
                    return frm;
                }
                else
                    RemoveForm(hash);

            return null;
        }
        public void RemoveForm(string Hash)
        {
            if (Hash != null)       //Popup formlar da buraya geldiğinden, bu kontrol gerekli. Xpopup formlarda bu event e gelmesi engellenebilir.
                forms.Remove(Hash);
        }
        public XForm ShowMdiChildForm(Type type, params object[] prm)
        {
            XForm frm = GetActiveForm(type, prm);

            if (frm != null)
            {
                ActiveXForm = frm;
                return frm;
            }

            //try
            {
                if (type.BaseType == typeof(XPopupForm))
                {
                    using (XForm popup = (XForm)Activator.CreateInstance(type, prm))
                    {
                        ActiveXForm = popup;
                        frm = popup;
                        popup.ShowDialog();
                    }
                }
                else
                {
                    frm = (XForm)Activator.CreateInstance(type, prm);
                    if (frm.isPopup)
                    {
                        using (XForm popup = (XForm)Activator.CreateInstance(type, prm))
                        {
                            ActiveXForm = popup;
                            frm = popup;
                            popup.ShowDialog();
                        }
                    }
                    else
                    {
                        frm.MdiParent = tabbedView1.Manager.MdiParent;
                        frm.WindowState = FormWindowState.Maximized;
                        string hash = CryptoManager.GetObjectHash(type, prm);
                        forms.Add(hash, frm);
                        frm.Hash = hash;
                        ActiveXForm = frm;
                        frm.Show();
                    }

                }
            }
            //catch (Exception Ex)
            {
            //    XtraMessageBox.Show(Ex.InnerException.ToString());
            }

            return frm;
        }
        #endregion

        private void BbiSirket_ItemClick(object sender, ItemClickEventArgs e)
        {
            //CompositionRootNinject.Resolve <FrmSirketler>().Show();
            ShowMdiChildForm(typeof(FrmSirketler));
            
        }


        #region Message Dialogs
        public DialogResult ShowErrorMessage(string message)
        {
            return XtraMessageBox.Show(message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult ShowInfoMessage(string message)
        {
            return XtraMessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowMessage(string message)
        {
            XtraMessageBox.Show(message);
        }

        public static void ShowMessage(Exception exception)
        {
            XtraMessageBox.Show(exception.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        private void BbiDonem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildForm(typeof(FrmDonemler));
            //ShowMdiChildForm(typeof(FrmDonem));
        }

        private void FrmMainRibbon_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void BbiStokKartlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildForm(typeof(FrmStokKartlari));
        }

        private void FrmMainRibbon_MdiChildActivate(object sender, EventArgs e)
        {
            
        }

        private void BbiStokGruplar_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildForm(typeof(FrmStokGruplari));
        }

        private void BbiBirimler_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildForm(typeof(FrmStokBirimleri));
        }

        private void BbiStokGiris_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildForm(typeof(FrmStokGiris),StokGirisCikis.Giris);
        }

        private void BbiDepolar_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildForm(typeof(FrmDepolar));
        }

        private void BbiStokHareket_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildForm(typeof(FrmStokHareketleri));
        }

        private void BbiFirmalar_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildForm(typeof(FrmFirmalar));
        }

        private void bbiUrunRecetesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildForm(typeof(FrmUrunAgaclari));
        }

        private void bbiUretimEmirleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            //ShowMdiChildForm(typeof(FrmUretimEmirleri));
            ShowMdiChildForm(typeof(FrmIsEmirleri));
        }

        private void bbiAyarlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildForm(typeof(FrmAyar));
        }

        private void bbDepoCikis_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildForm(typeof(FrmStokGiris),StokGirisCikis.Cikis);
        }

        private void btnTest_ItemClick(object sender, ItemClickEventArgs e)
        {
            //ShowMdiChildForm(typeof(FrmLotBul));
            var key = "142601-263221-810285-123457";
            //  
            var key2 = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            ParseKey(key,key2);
        }

        private void bbiTartimOperasyonlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildForm(typeof(FrmTartimOperasyonlar));
        }
        public void ParseKey(string key, string upgradeCode)
        {
                key = key.Replace("-", string.Empty);
                int int32_1 = Convert.ToInt32(key.Substring(0, 2));
                int int32_2 = Convert.ToInt32(key.Substring(2, 2));
                int int32_3 = Convert.ToInt32(key.Substring(4, 2));
                int int32_4 = Convert.ToInt32(key.Substring(6, 4));
                int int32_5 = Convert.ToInt32(key.Substring(10, 2));
                int int32_6 = Convert.ToInt32(key.Substring(12, 1));
                int int32_7 = Convert.ToInt32(key.Substring(13, 2));
                int int32_8 = Convert.ToInt32(key.Substring(15, 2));
                int int32_9 = Convert.ToInt32(key.Substring(17, 2));
                int int32_10 = Convert.ToInt32(key.Substring(19, 2));
                int int32_11 = Convert.ToInt32(key.Substring(21, 2));
                int int32_12 = Convert.ToInt32(key.Substring(23, 1));
                int checkDigit1 = GetCheckDigit(key.Substring(0, 23), 3);
            int checkDigit2 = GetCheckDigit(key.Substring(0, 12), 5);
            if (int32_12 != checkDigit1)
                    throw new Exception("Digit");
                
                if (int32_6 != checkDigit2)
                    throw new Exception("Digit 2");
                var Version = int32_8 - int32_2;
                var CreationTime = new DateTime(int32_5 + 2000, int32_3, int32_1, int32_7, int32_9, int32_11);
                if (Version == 50)
                {
                    var ProgramVariant = (eProgramVariant)(int32_4 % 100 - int32_2);
                    eProgramFeatures ProgramFeatures = eProgramFeatures.All;
                }
                else if (Version < 3)
                {
                    var ProgramVariant = (eProgramVariant)(int32_4 % 100 - int32_2);
                    var aeProgramType = (eProgramType)(int32_4 / 100 - int32_10);
                var d = aeProgramType;
                //if (upgradeCode!=null)
                //{
                //    if (upgradeCode.Length != 6)
                //        throw new Exception("KArekter Fazla");
                //    int int32_13 = Convert.ToInt32(upgradeCode.Substring(0, 1));
                //    if (int32_6 != int32_13)
                //        throw new Exception("Hata326");
                //    int int32_14 = Convert.ToInt32(upgradeCode.Substring(5, 1));
                //    if (int32_12 != int32_14)
                //        throw new LicenseKeyException(Resources.Error_Wrong_CheckDigit_UpgradeCode.FormatString((object)2, (object)int32_14, (object)int32_12));
                //    if (eProgramType != (LicenseKey.eProgramType)(Convert.ToInt32(upgradeCode.Substring(1, 2)) - int32_2))
                //        throw new LicenseKeyException(Resources.Error_Wrong_ProgramType_UpgradeCode);
                //    eProgramType = (LicenseKey.eProgramType)(Convert.ToInt32(upgradeCode.Substring(3, 2)) - int32_10);
                //}
                //switch (eProgramType)
                //{
                //    case eProgramType.Basic:
                //        licenseKey.ProgramFeatures = eProgramFeatures.LabelDesigner;
                //        break;
                //    case eProgramType.Professional:
                //        licenseKey.ProgramFeatures = eProgramFeatures.LabelDesigner | eProgramFeatures.QuickPrint | eProgramFeatures.PrintForm | eProgramFeatures.FolderMonitor | eProgramFeatures.OleAutomation;
                //        break;
                //    case eProgramType.PrintOnly:
                //        licenseKey.ProgramFeatures = eProgramFeatures.QuickPrint | eProgramFeatures.PrintForm | eProgramFeatures.FolderMonitor;
                //        break;
                //    case eProgramType.Runtime:
                //        licenseKey.ProgramFeatures = eProgramFeatures.OleAutomation;
                //        break;
                //}
                //licenseKey.ProgramType = eProgramType;
            }
                else
                {
                    //int num = (int32_4 % 100 - int32_2) * 100 + (int32_4 / 100 - int32_10);
                    //licenseKey.ProgramVariant = (eProgramVariant)(num % 10);
                    //licenseKey.ProgramFeatures = (eProgramFeatures)(num / 10);
                }
               var Status = Version < 3 ? eLicenseStatus.Expired : eLicenseStatus.Active;
            var durum = Status;
            
        }
        private int GetCheckDigit(string text, int weight)
        {
            int num = 0;
            for (int index = 0; index < text.Length; ++index)
                num += (int)text[index] * (index % 2 == 0 ? 1 : weight);
            var sonuc = num % 10;
            return sonuc;
        }
        public enum eLicenseStatus
        {
            Active,
            Inactive,
            Invalid,
            Expired,
            Duplicate,
        }
        [Flags]
        private enum eProgramType
        {
            None = 0,
            Basic = 1,
            Professional = 2,
            PrintOnly = 4,
            Runtime = 8,
        }
        [Flags]
        public enum eProgramFeatures
        {
            [Browsable(false)] None = 0,
            [Browsable(false)] All = 511, // 0x000001FF
            LabelDesigner = 1,
            QuickPrint = 2,
            PrintForm = 4,
            FolderMonitor = 8,
            Printer5 = 16, // 0x00000010
            Printer10 = 32, // 0x00000020
            OleAutomation = 64, // 0x00000040
            [Browsable(false)] Upgrade = 128, // 0x00000080
            PrintManager = 256, // 0x00000100
        }
        public enum eProgramVariant
        {
            Undefined,
            LabelstarOffice,
            VersaStyle,
        }
        

    }
    public static class CryptoManager
    {
        public static string GetObjectHash(Type type, object[] prm)
        {
            string prmHash = "";
            foreach (object o in prm)
                prmHash += o.GetHashCode();

            return type.GetHashCode() + "." + prmHash;
        }

        public static string[] GetSaltedHash(string password)
        {
            int SaltByteSize = 10;    //16 idi!

            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[SaltByteSize];
            rng.GetBytes(buff);
            string salt = Convert.ToBase64String(buff).Substring(0, 10);
            return new string[] { salt, FormsAuthentication.HashPasswordForStoringInConfigFile(salt + password, "SHA1") };
        }
        public static string Sifrele(string Sifresiz)
        {
            SecureString secureString = Sifresiz.ToSecureString();
            return secureString.Encrypt();
        }

        public static string SifreCoz(string Sifreli)
        {
            var secureString = Sifreli.DecryptSecure();
            return secureString.ToUnsecureString();
        }
    }
}
