namespace Sanmark.ERP.WinUI.Uretim
{
    partial class FrmIsEmriIhtiyacListesi
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
            this.colIhtiyac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcHareket = new DevExpress.XtraGrid.GridControl();
            this.gvHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokReceteIhtiyaci = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokReceteBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbiYazdir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.gcHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // colIhtiyac
            // 
            this.colIhtiyac.Caption = "Kullanılacak Miktar";
            this.colIhtiyac.DisplayFormat.FormatString = "n6";
            this.colIhtiyac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIhtiyac.FieldName = "Ihtiyac";
            this.colIhtiyac.Name = "colIhtiyac";
            this.colIhtiyac.OptionsColumn.AllowEdit = false;
            this.colIhtiyac.Visible = true;
            this.colIhtiyac.VisibleIndex = 3;
            this.colIhtiyac.Width = 117;
            // 
            // gcHareket
            // 
            this.gcHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHareket.Location = new System.Drawing.Point(0, 24);
            this.gcHareket.MainView = this.gvHareket;
            this.gcHareket.Name = "gcHareket";
            this.gcHareket.Size = new System.Drawing.Size(1082, 426);
            this.gcHareket.TabIndex = 0;
            this.gcHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHareket});
            // 
            // gvHareket
            // 
            this.gvHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colStokKodu,
            this.colStokAd,
            this.colStokMiktari,
            this.colIhtiyac,
            this.colStokBirimi,
            this.colStokReceteIhtiyaci,
            this.colStokReceteBirimi,
            this.colStokId,
            this.gridColumn1});
            this.gvHareket.GridControl = this.gcHareket;
            this.gvHareket.Name = "gvHareket";
            this.gvHareket.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
            this.gvHareket.OptionsFilter.ShowCustomFunctions = DevExpress.Utils.DefaultBoolean.False;
            this.gvHareket.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gvHareket.OptionsView.ColumnAutoWidth = false;
            this.gvHareket.OptionsView.EnableAppearanceEvenRow = true;
            this.gvHareket.OptionsView.ShowAutoFilterRow = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colStokKodu
            // 
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 0;
            this.colStokKodu.Width = 150;
            // 
            // colStokAd
            // 
            this.colStokAd.FieldName = "StokAd";
            this.colStokAd.Name = "colStokAd";
            this.colStokAd.OptionsColumn.AllowEdit = false;
            this.colStokAd.Visible = true;
            this.colStokAd.VisibleIndex = 1;
            this.colStokAd.Width = 283;
            // 
            // colStokMiktari
            // 
            this.colStokMiktari.FieldName = "StokMiktari";
            this.colStokMiktari.Name = "colStokMiktari";
            this.colStokMiktari.OptionsColumn.AllowEdit = false;
            this.colStokMiktari.Visible = true;
            this.colStokMiktari.VisibleIndex = 2;
            this.colStokMiktari.Width = 124;
            // 
            // colStokBirimi
            // 
            this.colStokBirimi.FieldName = "StokBirimi";
            this.colStokBirimi.Name = "colStokBirimi";
            this.colStokBirimi.OptionsColumn.AllowEdit = false;
            this.colStokBirimi.Visible = true;
            this.colStokBirimi.VisibleIndex = 5;
            // 
            // colStokReceteIhtiyaci
            // 
            this.colStokReceteIhtiyaci.FieldName = "StokReceteIhtiyaci";
            this.colStokReceteIhtiyaci.Name = "colStokReceteIhtiyaci";
            this.colStokReceteIhtiyaci.OptionsColumn.AllowEdit = false;
            this.colStokReceteIhtiyaci.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colStokReceteBirimi
            // 
            this.colStokReceteBirimi.FieldName = "StokReceteBirimi";
            this.colStokReceteBirimi.Name = "colStokReceteBirimi";
            this.colStokReceteBirimi.OptionsColumn.AllowEdit = false;
            this.colStokReceteBirimi.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colStokId
            // 
            this.colStokId.FieldName = "StokId";
            this.colStokId.Name = "colStokId";
            this.colStokId.OptionsColumn.AllowEdit = false;
            this.colStokId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "İhtiyaç Durumu";
            this.gridColumn1.DisplayFormat.FormatString = "n6";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.UnboundExpression = "Iif([StokMiktari] < [Ihtiyac], ToFloat([Ihtiyac] - [StokMiktari]), 0)";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 163;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiYazdir,
            this.bbiExport});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiYazdir),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbiYazdir
            // 
            this.bbiYazdir.Caption = "Yazdır";
            this.bbiYazdir.Id = 0;
            this.bbiYazdir.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.printer_16x16;
            this.bbiYazdir.ImageOptions.LargeImage = global::Sanmark.ERP.WinUI.Properties.Resources.printer_32x32;
            this.bbiYazdir.Name = "bbiYazdir";
            this.bbiYazdir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiYazdir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiYazdir_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Dışarı Aktar";
            this.bbiExport.Id = 1;
            this.bbiExport.Name = "bbiExport";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1082, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1082, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 426);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1082, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 426);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
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
            // FrmIsEmriIhtiyacListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 450);
            this.Controls.Add(this.gcHareket);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIsEmriIhtiyacListesi";
            this.Text = "İhtiyaç Listesi";
            this.Load += new System.EventHandler(this.FrmIsEmriIhtiyacListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAd;
        private DevExpress.XtraGrid.Columns.GridColumn colStokMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colIhtiyac;
        private DevExpress.XtraGrid.Columns.GridColumn colStokBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokReceteIhtiyaci;
        private DevExpress.XtraGrid.Columns.GridColumn colStokReceteBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem bbiYazdir;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}