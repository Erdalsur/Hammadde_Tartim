namespace Sanmark.ERP.WinUI.Stoklar
{
    partial class FrmUrunAgaci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunAgaci));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pnlControl = new DevExpress.XtraEditors.PanelControl();
            this.gcUrunAgaclari = new DevExpress.XtraGrid.GridControl();
            this.gvUrunAgaclari = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gleMakina = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gleGrup = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtKod = new DevExpress.XtraEditors.TextEdit();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl)).BeginInit();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUrunAgaclari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUrunAgaclari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleMakina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleGrup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
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
            this.bbiKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiKaydet_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 410);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 410);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.gcUrunAgaclari);
            this.pnlControl.Controls.Add(this.gleMakina);
            this.pnlControl.Controls.Add(this.gleGrup);
            this.pnlControl.Controls.Add(this.txtKod);
            this.pnlControl.Controls.Add(this.txtAd);
            this.pnlControl.Controls.Add(this.labelControl2);
            this.pnlControl.Controls.Add(this.labelControl4);
            this.pnlControl.Controls.Add(this.labelControl3);
            this.pnlControl.Controls.Add(this.labelControl1);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(0, 40);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(800, 410);
            this.pnlControl.TabIndex = 9;
            // 
            // gcUrunAgaclari
            // 
            this.gcUrunAgaclari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcUrunAgaclari.Location = new System.Drawing.Point(4, 107);
            this.gcUrunAgaclari.MainView = this.gvUrunAgaclari;
            this.gcUrunAgaclari.Name = "gcUrunAgaclari";
            this.gcUrunAgaclari.Size = new System.Drawing.Size(796, 298);
            this.gcUrunAgaclari.TabIndex = 27;
            this.gcUrunAgaclari.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUrunAgaclari});
            // 
            // gvUrunAgaclari
            // 
            this.gvUrunAgaclari.GridControl = this.gcUrunAgaclari;
            this.gvUrunAgaclari.Name = "gvUrunAgaclari";
            this.gvUrunAgaclari.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvUrunAgaclari_InitNewRow);
            this.gvUrunAgaclari.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvUrunAgaclari_CellValueChanged);
            this.gvUrunAgaclari.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvUrunAgaclari_RowUpdated);
            this.gvUrunAgaclari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvUrunAgaclari_KeyDown);
            // 
            // gleMakina
            // 
            this.gleMakina.Location = new System.Drawing.Point(69, 69);
            this.gleMakina.Name = "gleMakina";
            this.gleMakina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleMakina.Properties.PopupView = this.gridView1;
            this.gleMakina.Size = new System.Drawing.Size(650, 20);
            this.gleMakina.TabIndex = 26;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gleGrup
            // 
            this.gleGrup.Location = new System.Drawing.Point(69, 43);
            this.gleGrup.Name = "gleGrup";
            this.gleGrup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleGrup.Properties.PopupView = this.gridView2;
            this.gleGrup.Size = new System.Drawing.Size(650, 20);
            this.gleGrup.TabIndex = 26;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // txtKod
            // 
            this.txtKod.EnterMoveNextControl = true;
            this.txtKod.Location = new System.Drawing.Point(69, 15);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(310, 20);
            this.txtKod.TabIndex = 24;
            // 
            // txtAd
            // 
            this.txtAd.EnterMoveNextControl = true;
            this.txtAd.Location = new System.Drawing.Point(409, 15);
            this.txtAd.MenuManager = this.barManager1;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(310, 20);
            this.txtAd.TabIndex = 25;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Makina Adı";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(385, 18);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(13, 13);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Ad";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 46);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Stok Adı";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 13);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Kod";
            // 
            // FrmUrunAgaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmUrunAgaci.IconOptions.LargeImage")));
            this.Name = "FrmUrunAgaci";
            this.Text = "FrmUrunAgaci";
            this.Load += new System.EventHandler(this.FrmUrunAgaci_Load);
            this.Shown += new System.EventHandler(this.FrmUrunAgaci_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUrunAgaclari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUrunAgaclari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleMakina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleGrup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl pnlControl;
        private DevExpress.XtraEditors.GridLookUpEdit gleGrup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit txtKod;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcUrunAgaclari;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUrunAgaclari;
        private DevExpress.XtraEditors.GridLookUpEdit gleMakina;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}