namespace Sanmark.ERP.WinUI.BaseForms
{
    partial class FrmKodlar
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSirketId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTablo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOnEki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSonDeger = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegistirmeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegistirmeUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSirket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colUzunlugu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(625, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 471);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(625, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 431);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(625, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 431);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcData);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 40);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(625, 431);
            this.panelControl1.TabIndex = 4;
            // 
            // gcData
            // 
            this.gcData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcData.Location = new System.Drawing.Point(2, 2);
            this.gcData.MainView = this.gvData;
            this.gcData.MenuManager = this.barManager1;
            this.gcData.Name = "gcData";
            this.gcData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gcData.Size = new System.Drawing.Size(621, 427);
            this.gcData.TabIndex = 0;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSirketId,
            this.colDonemId,
            this.colTablo,
            this.colOnEki,
            this.colSonDeger,
            this.colKayitTarihi,
            this.colDegistirmeTarihi,
            this.colKayitUserId,
            this.colDegistirmeUserId,
            this.colSirket,
            this.colUzunlugu,
            this.colDonem,
            this.colSil});
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.EditFormShowing += new DevExpress.XtraGrid.Views.Grid.EditFormShowingEventHandler(this.gvData_EditFormShowing);
            this.gvData.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gvData_ShowingEditor);
            this.gvData.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvData_InitNewRow);
            this.gvData.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvData_ValidateRow);
            // 
            // colId
            // 
            this.colId.Caption = "Referans No";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colSirketId
            // 
            this.colSirketId.Caption = "Şirketi";
            this.colSirketId.FieldName = "SirketId";
            this.colSirketId.Name = "colSirketId";
            this.colSirketId.Width = 119;
            // 
            // colDonemId
            // 
            this.colDonemId.Caption = "Dönemi";
            this.colDonemId.FieldName = "DonemId";
            this.colDonemId.Name = "colDonemId";
            // 
            // colTablo
            // 
            this.colTablo.Caption = "Tablo";
            this.colTablo.FieldName = "Tablo";
            this.colTablo.Name = "colTablo";
            this.colTablo.Width = 119;
            // 
            // colOnEki
            // 
            this.colOnEki.Caption = "Ön Eki";
            this.colOnEki.FieldName = "OnEki";
            this.colOnEki.Name = "colOnEki";
            this.colOnEki.Visible = true;
            this.colOnEki.VisibleIndex = 0;
            this.colOnEki.Width = 163;
            // 
            // colSonDeger
            // 
            this.colSonDeger.Caption = "Son Değeri";
            this.colSonDeger.FieldName = "SonDeger";
            this.colSonDeger.Name = "colSonDeger";
            this.colSonDeger.Visible = true;
            this.colSonDeger.VisibleIndex = 2;
            this.colSonDeger.Width = 205;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            // 
            // colDegistirmeTarihi
            // 
            this.colDegistirmeTarihi.FieldName = "DegistirmeTarihi";
            this.colDegistirmeTarihi.Name = "colDegistirmeTarihi";
            // 
            // colKayitUserId
            // 
            this.colKayitUserId.FieldName = "KayitUserId";
            this.colKayitUserId.Name = "colKayitUserId";
            // 
            // colDegistirmeUserId
            // 
            this.colDegistirmeUserId.FieldName = "DegistirmeUserId";
            this.colDegistirmeUserId.Name = "colDegistirmeUserId";
            // 
            // colSirket
            // 
            this.colSirket.FieldName = "Sirket";
            this.colSirket.Name = "colSirket";
            // 
            // colDonem
            // 
            this.colDonem.FieldName = "Donem";
            this.colDonem.Name = "colDonem";
            // 
            // colSil
            // 
            this.colSil.Caption = "Sil";
            this.colSil.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colSil.Name = "colSil";
            this.colSil.Visible = true;
            this.colSil.VisibleIndex = 3;
            this.colSil.Width = 49;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = global::Sanmark.ERP.WinUI.Properties.Resources.actions_delete;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // colUzunlugu
            // 
            this.colUzunlugu.Caption = "Uzunluğu";
            this.colUzunlugu.FieldName = "Uzunlugu";
            this.colUzunlugu.Name = "colUzunlugu";
            this.colUzunlugu.Visible = true;
            this.colUzunlugu.VisibleIndex = 1;
            this.colUzunlugu.Width = 179;
            // 
            // FrmKodlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 471);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmKodlar";
            this.Text = "FrmKodlar";
            this.Load += new System.EventHandler(this.FrmKodlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSirketId;
        private DevExpress.XtraGrid.Columns.GridColumn colDonemId;
        private DevExpress.XtraGrid.Columns.GridColumn colTablo;
        private DevExpress.XtraGrid.Columns.GridColumn colOnEki;
        private DevExpress.XtraGrid.Columns.GridColumn colSonDeger;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colDegistirmeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colDegistirmeUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colSirket;
        private DevExpress.XtraGrid.Columns.GridColumn colDonem;
        private DevExpress.XtraGrid.Columns.GridColumn colSil;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colUzunlugu;
    }
}