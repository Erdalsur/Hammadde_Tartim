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
using System.Deployment.Application;
using Sanmark.Core.Utilities.Win.Infrastructure;
using Sanmark.Erp.Entities.Concrete;
using Microsoft.Win32;
using System.Security.AccessControl;
using System.IO;
using System.Security.Principal;

namespace Sanmark.ERP.WinUI
{
    public partial class FrmLogin : XtraForm
    {
        Sirket sirket;
        Donem donem;
        public FrmLogin()
        {
            InitializeComponent();
            KlasorIzın();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //try
            //{
                CompositionRootNinject.Resolve<DataSession>();
                //var test = DataSession.SirketService.GetById(1);
            //}
            //catch
            //{
            //    MessageBox.Show("Session Yüklenme Hatası");
            //}
            string userName = RememberUser();
            if (userName != String.Empty)
            {
                txtUser.Text = userName;
                txtPassword.Focus();
                switch (Environment.MachineName.ToUpper())
                {
                    case "SOLIDWORKS1":
                        txtUser.Text = "admin";
                        txtPassword.Text = "admin";
                        break;
                }
            }
        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            this.Text = AppSession.ApplicationName;
            //this.Text += " - v" + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                Application.Exit();
            }
            if (e.KeyCode == Keys.F2)
            {
                btnLogin.PerformClick();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {       

            if (txtNewPassword.Visible)
            {
                if (txtNewPassword.Text == "")
                {
                    XtraMessageBox.Show("Yeni parola boşluk olamaz. Tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtNewPassword.Text.Length < 3)
                {
                    XtraMessageBox.Show("Yeni parola 3 karakterden kısa olamaz. Tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Text = "";
                    return;
                }
            }
            if(sirket == null)
            {
                var data = DataSession.SirketService.GetAll().Where(f => f.Kod == txtFirma.Text).FirstOrDefault();
                if (data == null)
                {
                    XtraMessageBox.Show("Şirket Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sirket = data;
            }
            if (donem == null)
            {
                var yili = short.Parse(txtDonem.Text);
                var data = DataSession.DonemService.GetAll(f => f.Yil == yili).FirstOrDefault();
                if (data == null)
                {
                    XtraMessageBox.Show("Dönem Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                donem = data;
            }

            if (LoginUserCheck(txtUser.Text, txtPassword.Text, txtNewPassword.Text)==true)
            {


                this.DialogResult = DialogResult.OK;
            }
            else
            {
                XtraMessageBox.Show("Hatalı kullanıcı adı veya şifre. Tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = String.Empty;
                txtPassword.Focus();
            }
        }


        private bool LoginUserCheck(string userName, string userPassword, string NewPassword)
        {

            if (NewPassword != "")
            {
                bool Durum=DataSession.UserService.PasswordChange(userName, userPassword,NewPassword);
                if (!Durum)
                    return false;
                userPassword = NewPassword;
                XtraMessageBox.Show("Parolanız başarıyla değiştirildi. Sonraki girişlerde yeni parolanızı kullanın.");
            }

            User user = DataSession.UserService.UserCheck(userName, userPassword);
            if (user == null)
                return false;
            if (sirket == null)
                return false;
            if (donem == null)
                return false;
            //sirket = DataSession.SirketService.GetById(3);//gerçek veri 1 sahte veri de 3
            //donem = DataSession.DonemService.GetById(1);
            AppSession.CurrentUser = user;
            AppSession.Donem = donem;
            AppSession.Sirket = sirket;
            RememberUser(userName);
            return true;
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txtFirma_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FirmaSec();
        }

        private void FirmaSec()
        {
            using (FrmFirmaSec frmFirmaSec = new FrmFirmaSec())
            {
                if (frmFirmaSec.ShowDialog() == DialogResult.OK)
                {
                    sirket = frmFirmaSec.sirket;
                    txtFirma.Text = sirket.Kod;
                    txtDonem.Focus();
                }
            }
        }

        private void txtDonem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sirket == null)
                return;
            using (FrmDonemSec frmDonemSec = new FrmDonemSec(sirket))
            {
                //frmDonemSec._sirket = sirket;
                if (frmDonemSec.ShowDialog() == DialogResult.OK)
                {
                    donem = frmDonemSec.donem;
                    txtDonem.Text = donem.Yil.ToString();
                    btnLogin.Focus();
                }
            }
        }
        public string RememberUser(string UserNameToSave = "")
        {
            
            try
            {
                RegistryKey register = Registry.CurrentUser.CreateSubKey(@"Software\SanmarkTarti");
                if (UserNameToSave != "")
                {
                    register.SetValue("UserLastLoggedIn", UserNameToSave, RegistryValueKind.String);
                    Registry.LocalMachine.Flush();
                }
                else
                    UserNameToSave = (string)register.GetValue("UserLastLoggedIn", String.Empty);

            }
            catch (Exception)
            {
            }
            return UserNameToSave;
        }

        private void btnChangePassword_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            //int l = lblNewPassword.Location.Y;
            //int c = txtNewPassword.Location.Y;
            //lblNewPassword.Location = new Point(lblNewPassword.Location.X, lblFirma.Location.Y);
            //txtNewPassword.Location = new Point(txtNewPassword.Location.X, txtDonem.Location.Y);
            //lblFirma.Location = new Point(lblFirma.Location.X, l);
            //txtFirma.Location = new Point(txtFirma.Location.X, c);


            //btnLogin.Location = new Point(btnLogin.Location.X, txtFirma.Location.Y);
            bool visible = btnChangePassword.Text == "Parola Değiştir";

            if (visible)
            {
                btnChangePassword.Text = "Parola Değiştirme";
                lblNewPassword.Visible = true;
                txtNewPassword.Visible = true;
            }
            else
            {
                btnChangePassword.Text = "Parola Değiştir";
                lblNewPassword.Visible = false;
                txtNewPassword.Visible = false;
                txtNewPassword.Text = "";
            }
        }

        private void KlasorIzın()
        {
            DirectorySecurity izin = Directory.GetAccessControl(Application.StartupPath);
            SecurityIdentifier everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            izin.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.FullControl, AccessControlType.Allow));
            Directory.SetAccessControl(Application.StartupPath, izin);
        }

        private void txtFirma_EditValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}