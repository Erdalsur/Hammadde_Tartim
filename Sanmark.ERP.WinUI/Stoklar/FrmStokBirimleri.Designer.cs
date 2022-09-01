namespace Sanmark.ERP.WinUI.Stoklar
{
    partial class FrmStokBirimleri
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
            this.bbiSil = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pnlControl = new DevExpress.XtraEditors.PanelControl();
            this.gcBirimler = new DevExpress.XtraGrid.GridControl();
            this.gvBirimler = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl)).BeginInit();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBirimler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBirimler)).BeginInit();
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
            this.bbiSil});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSil)});
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
            // bbiSil
            // 
            this.bbiSil.Caption = "Sil";
            this.bbiSil.Id = 1;
            this.bbiSil.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.Delete;
            this.bbiSil.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete));
            this.bbiSil.Name = "bbiSil";
            this.bbiSil.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiSil_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(738, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 478);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(738, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 438);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(738, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 438);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.gcBirimler);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(0, 40);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(738, 438);
            this.pnlControl.TabIndex = 6;
            // 
            // gcBirimler
            // 
            this.gcBirimler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBirimler.Location = new System.Drawing.Point(2, 2);
            this.gcBirimler.MainView = this.gvBirimler;
            this.gcBirimler.Name = "gcBirimler";
            this.gcBirimler.Size = new System.Drawing.Size(734, 434);
            this.gcBirimler.TabIndex = 0;
            this.gcBirimler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBirimler});
            // 
            // gvBirimler
            // 
            this.gvBirimler.GridControl = this.gcBirimler;
            this.gvBirimler.Name = "gvBirimler";
            this.gvBirimler.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.GvBirimler_InitNewRow);
            // 
            // FrmStokBirimleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 478);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmStokBirimleri";
            this.Text = "Stok Birimleri";
            this.Load += new System.EventHandler(this.FrmStokBirimleri_Load);
            this.Shown += new System.EventHandler(this.FrmStokBirimleri_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl)).EndInit();
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBirimler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBirimler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiKaydet;
        private DevExpress.XtraBars.BarButtonItem bbiSil;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl pnlControl;
        private DevExpress.XtraGrid.GridControl gcBirimler;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBirimler;
    }
}