namespace Sanmark.ERP.WinUI.Cariler
{
    partial class FrmFirmaKart
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
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gleKartTipi = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gleFirmaTipi = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.txtKod = new DevExpress.XtraEditors.TextEdit();
            this.txtVergiNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gleKartTipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleFirmaTipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
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
            this.bbiKaydet});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 1;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiKaydet)});
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
            this.bbiKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiKaydet_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(418, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 268);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(418, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 228);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(418, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 228);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gleKartTipi);
            this.panelControl1.Controls.Add(this.gleFirmaTipi);
            this.panelControl1.Controls.Add(this.txtAd);
            this.panelControl1.Controls.Add(this.txtKod);
            this.panelControl1.Controls.Add(this.txtVergiNo);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.txtVergiDairesi);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txtSoyad);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 40);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(418, 228);
            this.panelControl1.TabIndex = 6;
            // 
            // gleKartTipi
            // 
            this.gleKartTipi.Location = new System.Drawing.Point(95, 43);
            this.gleKartTipi.Name = "gleKartTipi";
            this.gleKartTipi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleKartTipi.Properties.PopupView = this.gridView3;
            this.gleKartTipi.Size = new System.Drawing.Size(310, 20);
            this.gleKartTipi.TabIndex = 20;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gleFirmaTipi
            // 
            this.gleFirmaTipi.Location = new System.Drawing.Point(95, 14);
            this.gleFirmaTipi.Name = "gleFirmaTipi";
            this.gleFirmaTipi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleFirmaTipi.Properties.PopupView = this.gridView2;
            this.gleFirmaTipi.Size = new System.Drawing.Size(310, 20);
            this.gleFirmaTipi.TabIndex = 10;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // txtAd
            // 
            this.txtAd.EnterMoveNextControl = true;
            this.txtAd.Location = new System.Drawing.Point(95, 99);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(310, 20);
            this.txtAd.TabIndex = 40;
            // 
            // txtKod
            // 
            this.txtKod.EnterMoveNextControl = true;
            this.txtKod.Location = new System.Drawing.Point(95, 71);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(310, 20);
            this.txtKod.TabIndex = 30;
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.EnterMoveNextControl = true;
            this.txtVergiNo.Location = new System.Drawing.Point(95, 182);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(310, 20);
            this.txtVergiNo.TabIndex = 70;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(44, 185);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(40, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Vergi No";
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.EnterMoveNextControl = true;
            this.txtVergiDairesi.Location = new System.Drawing.Point(95, 155);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(310, 20);
            this.txtVergiDairesi.TabIndex = 60;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(25, 158);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Vergi Dairesi";
            // 
            // txtSoyad
            // 
            this.txtSoyad.EnterMoveNextControl = true;
            this.txtSoyad.Location = new System.Drawing.Point(95, 128);
            this.txtSoyad.MenuManager = this.barManager1;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(310, 20);
            this.txtSoyad.TabIndex = 50;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 131);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Soyad / Ünvan";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(30, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Ad / Ünvan";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(39, 17);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Firma Tipi";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(45, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Kart Tipi";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(66, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kod";
            // 
            // FrmFirmaKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 268);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.accounting;
            this.MaximumSize = new System.Drawing.Size(420, 300);
            this.MinimumSize = new System.Drawing.Size(420, 300);
            this.Name = "FrmFirmaKart";
            this.Text = "Firma Kartı";
            this.Load += new System.EventHandler(this.FrmFirmaKart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gleKartTipi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleFirmaTipi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
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
        private DevExpress.XtraEditors.GridLookUpEdit gleKartTipi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.GridLookUpEdit gleFirmaTipi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.TextEdit txtKod;
        private DevExpress.XtraEditors.TextEdit txtVergiNo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtVergiDairesi;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}