namespace Sanmark.ERP.WinUI.Uretim
{
    partial class FrmUretimEmirleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUretimEmirleri));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbiYeniUretimEmir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDuzenle = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUretimBaslat = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFoyYazdir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBitir = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiSil = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.pnlControl = new DevExpress.XtraEditors.PanelControl();
            this.gcUretimEmirleri = new DevExpress.XtraGrid.GridControl();
            this.gvUretimEmirleri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.noktalar = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl)).BeginInit();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUretimEmirleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUretimEmirleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noktalar)).BeginInit();
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
            this.bbiYeniUretimEmir,
            this.bbiDuzenle,
            this.bbiSil,
            this.bbiUretimBaslat,
            this.bbiFoyYazdir,
            this.bbiBitir,
            this.barSubItem1,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiYeniUretimEmir),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDuzenle),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiUretimBaslat),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiFoyYazdir),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiBitir),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbiYeniUretimEmir
            // 
            this.bbiYeniUretimEmir.Caption = "Yeni Üretim";
            this.bbiYeniUretimEmir.Id = 0;
            this.bbiYeniUretimEmir.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.Action_New_32x32;
            this.bbiYeniUretimEmir.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.bbiYeniUretimEmir.Name = "bbiYeniUretimEmir";
            this.bbiYeniUretimEmir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiYeniUretimEmir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiYeniUretimEmir_ItemClick);
            // 
            // bbiDuzenle
            // 
            this.bbiDuzenle.Caption = "Düzenle";
            this.bbiDuzenle.Id = 1;
            this.bbiDuzenle.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.purchase_order32;
            this.bbiDuzenle.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.bbiDuzenle.Name = "bbiDuzenle";
            this.bbiDuzenle.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiDuzenle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDuzenle_ItemClick);
            // 
            // bbiUretimBaslat
            // 
            this.bbiUretimBaslat.Caption = "Üretimi Başlat";
            this.bbiUretimBaslat.Id = 3;
            this.bbiUretimBaslat.Name = "bbiUretimBaslat";
            this.bbiUretimBaslat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUretimBaslat_ItemClick);
            // 
            // bbiFoyYazdir
            // 
            this.bbiFoyYazdir.Caption = "Üretim Föyü Yazdır";
            this.bbiFoyYazdir.Id = 4;
            this.bbiFoyYazdir.Name = "bbiFoyYazdir";
            this.bbiFoyYazdir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFoyYazdir_ItemClick);
            // 
            // bbiBitir
            // 
            this.bbiBitir.Caption = "Üretimi Bitir";
            this.bbiBitir.Id = 5;
            this.bbiBitir.Name = "bbiBitir";
            this.bbiBitir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiBitir_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Dışarı Aktar";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            
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
            this.barDockControlTop.Size = new System.Drawing.Size(800, 61);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 430);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 369);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 61);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 369);
            // 
            // bbiSil
            // 
            this.bbiSil.Caption = "Sil";
            this.bbiSil.Id = 2;
            this.bbiSil.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.Delete;
            this.bbiSil.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete));
            this.bbiSil.Name = "bbiSil";
            this.bbiSil.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 6;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.gcUretimEmirleri);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(0, 61);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(800, 369);
            this.pnlControl.TabIndex = 9;
            // 
            // gcUretimEmirleri
            // 
            this.gcUretimEmirleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUretimEmirleri.Location = new System.Drawing.Point(2, 2);
            this.gcUretimEmirleri.MainView = this.gvUretimEmirleri;
            this.gcUretimEmirleri.Name = "gcUretimEmirleri";
            this.gcUretimEmirleri.Size = new System.Drawing.Size(796, 365);
            this.gcUretimEmirleri.TabIndex = 0;
            this.gcUretimEmirleri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUretimEmirleri});
            // 
            // gvUretimEmirleri
            // 
            this.gvUretimEmirleri.GridControl = this.gcUretimEmirleri;
            this.gvUretimEmirleri.Name = "gvUretimEmirleri";
            this.gvUretimEmirleri.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvUretimEmirleri_RowStyle);
            // 
            // noktalar
            // 
            this.noktalar.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("noktalar.ImageStream")));
            this.noktalar.Images.SetKeyName(0, "noktConfExpert.gif");
            this.noktalar.Images.SetKeyName(1, "nokta3.gif");
            this.noktalar.Images.SetKeyName(2, "nokta4.gif");
            this.noktalar.Images.SetKeyName(3, "nokta2.gif");
            // 
            // FrmUretimEmirleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmUretimEmirleri";
            this.Text = "Üretim Emirleri";
            this.Load += new System.EventHandler(this.FrmUretimEmirleri_Load);
            this.Shown += new System.EventHandler(this.FrmUretimEmirleri_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl)).EndInit();
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUretimEmirleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUretimEmirleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noktalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem bbiYeniUretimEmir;
        private DevExpress.XtraBars.BarButtonItem bbiDuzenle;
        private DevExpress.XtraBars.BarButtonItem bbiSil;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl pnlControl;
        private DevExpress.XtraGrid.GridControl gcUretimEmirleri;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUretimEmirleri;
        private DevExpress.XtraBars.BarButtonItem bbiUretimBaslat;
        private DevExpress.Utils.ImageCollection noktalar;
        private DevExpress.XtraBars.BarButtonItem bbiFoyYazdir;
        private DevExpress.XtraBars.BarButtonItem bbiBitir;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}