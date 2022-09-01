namespace Sanmark.ERP.WinUI
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnChangePassword = new DevExpress.XtraEditors.HyperLinkEdit();
            this.txtDonem = new DevExpress.XtraEditors.ButtonEdit();
            this.txtFirma = new DevExpress.XtraEditors.ButtonEdit();
            this.txtNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblDonem = new System.Windows.Forms.Label();
            this.lblFirma = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl1.ContentImage")));
            this.panelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.panelControl1.Controls.Add(this.btnChangePassword);
            this.panelControl1.Controls.Add(this.txtDonem);
            this.panelControl1.Controls.Add(this.txtFirma);
            this.panelControl1.Controls.Add(this.txtNewPassword);
            this.panelControl1.Controls.Add(this.txtPassword);
            this.panelControl1.Controls.Add(this.txtUser);
            this.panelControl1.Controls.Add(this.lblNewPassword);
            this.panelControl1.Controls.Add(this.lblDonem);
            this.panelControl1.Controls.Add(this.lblFirma);
            this.panelControl1.Controls.Add(this.lblSifre);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.btnLogin);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(297, 328);
            this.panelControl1.TabIndex = 0;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.EditValue = "Parola Değiştir";
            this.btnChangePassword.Location = new System.Drawing.Point(12, 303);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.btnChangePassword.Properties.Appearance.Options.UseBackColor = true;
            this.btnChangePassword.Properties.Appearance.Options.UseForeColor = true;
            this.btnChangePassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnChangePassword.Size = new System.Drawing.Size(90, 18);
            this.btnChangePassword.TabIndex = 41;
            this.btnChangePassword.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.btnChangePassword_OpenLink);
            // 
            // txtDonem
            // 
            this.txtDonem.EditValue = "";
            this.txtDonem.Location = new System.Drawing.Point(88, 235);
            this.txtDonem.Name = "txtDonem";
            this.txtDonem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDonem.Size = new System.Drawing.Size(187, 20);
            this.txtDonem.TabIndex = 3;
            this.txtDonem.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtDonem_ButtonClick);
            // 
            // txtFirma
            // 
            this.txtFirma.EditValue = "";
            this.txtFirma.Location = new System.Drawing.Point(88, 209);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtFirma.Size = new System.Drawing.Size(187, 20);
            this.txtFirma.TabIndex = 2;
            this.txtFirma.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtFirma_ButtonClick);
            this.txtFirma.EditValueChanged += new System.EventHandler(this.txtFirma_EditValueChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(88, 261);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Properties.PasswordChar = 'X';
            this.txtNewPassword.Size = new System.Drawing.Size(187, 20);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(88, 182);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(187, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(88, 156);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(187, 20);
            this.txtUser.TabIndex = 0;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(30, 264);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(52, 13);
            this.lblNewPassword.TabIndex = 36;
            this.lblNewPassword.Text = "Yeni Şifre";
            this.lblNewPassword.Visible = false;
            // 
            // lblDonem
            // 
            this.lblDonem.AutoSize = true;
            this.lblDonem.Location = new System.Drawing.Point(42, 238);
            this.lblDonem.Name = "lblDonem";
            this.lblDonem.Size = new System.Drawing.Size(40, 13);
            this.lblDonem.TabIndex = 36;
            this.lblDonem.Text = "Dönem";
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Location = new System.Drawing.Point(49, 212);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(33, 13);
            this.lblFirma.TabIndex = 36;
            this.lblFirma.Text = "Firma";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(53, 185);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(29, 13);
            this.lblSifre.TabIndex = 36;
            this.lblSifre.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // btnLogin
            // 
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnLogin.Location = new System.Drawing.Point(218, 287);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(57, 36);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 328);
            this.Controls.Add(this.panelControl1);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.accounting;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.Shown += new System.EventHandler(this.FrmLogin_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private System.Windows.Forms.Label lblDonem;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ButtonEdit txtDonem;
        private DevExpress.XtraEditors.ButtonEdit txtFirma;
        public DevExpress.XtraEditors.HyperLinkEdit btnChangePassword;
        private DevExpress.XtraEditors.TextEdit txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
    }
}