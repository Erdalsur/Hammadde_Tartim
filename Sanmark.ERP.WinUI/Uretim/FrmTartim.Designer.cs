namespace Sanmark.ERP.WinUI.Uretim
{
    partial class FrmTartim
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
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtSKT = new System.Windows.Forms.DateTimePicker();
            this.btnTartiOku = new DevExpress.XtraEditors.SimpleButton();
            this.txtMiktar = new DevExpress.XtraEditors.TextEdit();
            this.txtKontrolEden = new DevExpress.XtraEditors.TextEdit();
            this.txtTartan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtReferans = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtLot = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblDara = new DevExpress.XtraEditors.LabelControl();
            this.lblUrunAd = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKontrolEden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTartan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLot.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.AllowShowToolbarsPopup = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiKaydet,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiKaydet),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // bbiKaydet
            // 
            this.bbiKaydet.Caption = "Kaydet";
            this.bbiKaydet.Hint = "Kaydet";
            this.bbiKaydet.Id = 0;
            this.bbiKaydet.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.Save_32x321;
            this.bbiKaydet.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.bbiKaydet.Name = "bbiKaydet";
            this.bbiKaydet.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiKaydet_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Yaz";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem1.VisibleInSearchMenu = false;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(569, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 274);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(569, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 234);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(569, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 234);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtSKT);
            this.panelControl1.Controls.Add(this.btnTartiOku);
            this.panelControl1.Controls.Add(this.txtMiktar);
            this.panelControl1.Controls.Add(this.txtKontrolEden);
            this.panelControl1.Controls.Add(this.txtTartan);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtReferans);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtLot);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.lblDara);
            this.panelControl1.Controls.Add(this.lblUrunAd);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 40);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(569, 234);
            this.panelControl1.TabIndex = 4;
            // 
            // txtSKT
            // 
            this.txtSKT.Location = new System.Drawing.Point(95, 151);
            this.txtSKT.Name = "txtSKT";
            this.txtSKT.Size = new System.Drawing.Size(200, 21);
            this.txtSKT.TabIndex = 4;
            // 
            // btnTartiOku
            // 
            this.btnTartiOku.Location = new System.Drawing.Point(406, 49);
            this.btnTartiOku.Name = "btnTartiOku";
            this.btnTartiOku.Size = new System.Drawing.Size(151, 95);
            this.btnTartiOku.TabIndex = 6;
            this.btnTartiOku.Text = "Tartı Okuma";
            this.btnTartiOku.Click += new System.EventHandler(this.btnTartiOku_Click);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(119, 178);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Properties.DisplayFormat.FormatString = "n6";
            this.txtMiktar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMiktar.Properties.EditFormat.FormatString = "n6";
            this.txtMiktar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMiktar.Properties.Mask.EditMask = "n6";
            this.txtMiktar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMiktar.Size = new System.Drawing.Size(267, 20);
            this.txtMiktar.TabIndex = 7;
            // 
            // txtKontrolEden
            // 
            this.txtKontrolEden.Location = new System.Drawing.Point(95, 124);
            this.txtKontrolEden.Name = "txtKontrolEden";
            this.txtKontrolEden.Size = new System.Drawing.Size(291, 20);
            this.txtKontrolEden.TabIndex = 3;
            // 
            // txtTartan
            // 
            this.txtTartan.Location = new System.Drawing.Point(95, 98);
            this.txtTartan.Name = "txtTartan";
            this.txtTartan.Size = new System.Drawing.Size(291, 20);
            this.txtTartan.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 157);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(65, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Son Kul.Tarihi";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 127);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Kontrol Eden";
            // 
            // txtReferans
            // 
            this.txtReferans.Location = new System.Drawing.Point(95, 72);
            this.txtReferans.Name = "txtReferans";
            this.txtReferans.Size = new System.Drawing.Size(291, 20);
            this.txtReferans.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tartan Kişi";
            // 
            // txtLot
            // 
            this.txtLot.Location = new System.Drawing.Point(95, 46);
            this.txtLot.MenuManager = this.barManager1;
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(291, 20);
            this.txtLot.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Referans No";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 178);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(101, 16);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Tartılan Değer :";
            // 
            // lblDara
            // 
            this.lblDara.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDara.Appearance.Options.UseFont = true;
            this.lblDara.Location = new System.Drawing.Point(12, 206);
            this.lblDara.Name = "lblDara";
            this.lblDara.Size = new System.Drawing.Size(85, 16);
            this.lblDara.TabIndex = 0;
            this.lblDara.Text = "labelControl1";
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAd.Appearance.Options.UseFont = true;
            this.lblUrunAd.Location = new System.Drawing.Point(12, 17);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(85, 16);
            this.lblUrunAd.TabIndex = 0;
            this.lblUrunAd.Text = "labelControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Lot Numarası";
            // 
            // FrmTartim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 274);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmTartim";
            this.Text = "FrmTartim";
            this.Load += new System.EventHandler(this.FrmTartim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKontrolEden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTartan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLot.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiKaydet;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTartiOku;
        private DevExpress.XtraEditors.TextEdit txtKontrolEden;
        private DevExpress.XtraEditors.TextEdit txtTartan;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtReferans;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtLot;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblUrunAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMiktar;
        private System.Windows.Forms.DateTimePicker txtSKT;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblDara;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}