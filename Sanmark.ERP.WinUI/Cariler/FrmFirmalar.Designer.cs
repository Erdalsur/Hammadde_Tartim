namespace Sanmark.ERP.WinUI.Cariler
{
    partial class FrmFirmalar
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
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbiYeniStokKart = new DevExpress.XtraBars.BarButtonItem();
            this.bbiStokKartAc = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSil = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pnlControl = new DevExpress.XtraEditors.PanelControl();
            this.gcKartlar = new DevExpress.XtraGrid.GridControl();
            this.gvKartlar = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl)).BeginInit();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKartlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKartlar)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiYeniStokKart,
            this.bbiStokKartAc,
            this.bbiSil});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            this.bar1.Visible = false;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiYeniStokKart),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiStokKartAc),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSil)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbiYeniStokKart
            // 
            this.bbiYeniStokKart.Caption = "Yeni Kart";
            this.bbiYeniStokKart.Id = 0;
            this.bbiYeniStokKart.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.Action_New_32x32;
            this.bbiYeniStokKart.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.bbiYeniStokKart.Name = "bbiYeniStokKart";
            this.bbiYeniStokKart.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiYeniStokKart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiYeniStokKart_ItemClick);
            // 
            // bbiStokKartAc
            // 
            this.bbiStokKartAc.Caption = "Aç";
            this.bbiStokKartAc.Id = 1;
            this.bbiStokKartAc.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.purchase_order32;
            this.bbiStokKartAc.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.bbiStokKartAc.Name = "bbiStokKartAc";
            this.bbiStokKartAc.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiStokKartAc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiStokKartAc_ItemClick);
            // 
            // bbiSil
            // 
            this.bbiSil.Caption = "Sil";
            this.bbiSil.Id = 2;
            this.bbiSil.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.Delete;
            this.bbiSil.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete));
            this.bbiSil.Name = "bbiSil";
            this.bbiSil.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiSil_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(967, 61);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 484);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(967, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 423);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(967, 61);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 423);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.gcKartlar);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(0, 61);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(967, 423);
            this.pnlControl.TabIndex = 6;
            // 
            // gcKartlar
            // 
            this.gcKartlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKartlar.Location = new System.Drawing.Point(2, 2);
            this.gcKartlar.MainView = this.gvKartlar;
            this.gcKartlar.Name = "gcKartlar";
            this.gcKartlar.Size = new System.Drawing.Size(963, 419);
            this.gcKartlar.TabIndex = 0;
            this.gcKartlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKartlar});
            // 
            // gvKartlar
            // 
            this.gvKartlar.GridControl = this.gcKartlar;
            this.gvKartlar.Name = "gvKartlar";
            this.gvKartlar.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GvKartlar_RowClick);
            this.gvKartlar.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GvKartlar_FocusedRowChanged);
            // 
            // FrmFirmalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 504);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmFirmalar";
            this.Text = "Satıcı ve Alıcı Firmalar";
            this.Load += new System.EventHandler(this.FrmFirmalar_Load);
            this.Shown += new System.EventHandler(this.FrmFirmalar_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl)).EndInit();
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcKartlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKartlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem bbiYeniStokKart;
        private DevExpress.XtraBars.BarButtonItem bbiStokKartAc;
        private DevExpress.XtraBars.BarButtonItem bbiSil;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl pnlControl;
        private DevExpress.XtraGrid.GridControl gcKartlar;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKartlar;
    }
}