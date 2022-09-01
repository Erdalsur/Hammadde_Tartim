namespace Sanmark.ERP.WinUI.Uretim
{
    partial class FrmIsEmirleri
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gcHareket = new DevExpress.XtraGrid.GridControl();
            this.ısEmriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsEmriKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsEmriTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenelDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKartiId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMakinaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarpan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaglantiAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaglantiId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanlananBaslangicTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlananBitisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaslamaTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKapanisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegistirmeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegistirmeUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsEmriOperasyon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbiYeniIsEmri = new DevExpress.XtraBars.BarButtonItem();
            this.btnAc = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.btnYazdir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExpand = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.gcHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ısEmriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcHareket
            // 
            this.gcHareket.DataSource = this.ısEmriBindingSource;
            this.gcHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gcHareket.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcHareket.Location = new System.Drawing.Point(0, 20);
            this.gcHareket.MainView = this.gvHareket;
            this.gcHareket.MenuManager = this.barManager1;
            this.gcHareket.Name = "gcHareket";
            this.gcHareket.Size = new System.Drawing.Size(1520, 410);
            this.gcHareket.TabIndex = 4;
            this.gcHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHareket});
            this.gcHareket.Click += new System.EventHandler(this.gcHareket_Click);
            // 
            // ısEmriBindingSource
            // 
            this.ısEmriBindingSource.DataSource = typeof(Sanmark.Erp.Entities.Concrete.Uretim.IsEmri);
            // 
            // gvHareket
            // 
            this.gvHareket.ChildGridLevelName = "Hareketleri";
            this.gvHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDonemId,
            this.colIsEmriKodu,
            this.colIsEmriTipi,
            this.colGenelDurumu,
            this.colAciklama,
            this.colPartiNo,
            this.colStokKartiId,
            this.colMiktar,
            this.colBirimId,
            this.colMakinaId,
            this.colCarpan,
            this.colBaglantiAdres,
            this.colBaglantiId,
            this.colPlanlananBaslangicTarihi,
            this.colPlananBitisTarihi,
            this.colBaslamaTarihi,
            this.colKapanisTarihi,
            this.colKayitTarihi,
            this.colDegistirmeTarihi,
            this.colKayitUserId,
            this.colDegistirmeUserId,
            this.colIsEmriOperasyon,
            this.colTotal});
            this.gvHareket.GridControl = this.gcHareket;
            this.gvHareket.Name = "gvHareket";
            this.gvHareket.OptionsView.ColumnAutoWidth = false;
            this.gvHareket.OptionsView.ShowChildrenInGroupPanel = true;
            this.gvHareket.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gvHareket_MasterRowExpanded);
            this.gvHareket.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gvHareket_MasterRowGetChildList);
            this.gvHareket.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gvHareket_MasterRowGetRelationName);
            this.gvHareket.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gvHareket_MasterRowGetRelationCount);
            this.gvHareket.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvHareket_CustomUnboundColumnData);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colDonemId
            // 
            this.colDonemId.FieldName = "DonemId";
            this.colDonemId.Name = "colDonemId";
            this.colDonemId.OptionsColumn.AllowEdit = false;
            // 
            // colIsEmriKodu
            // 
            this.colIsEmriKodu.FieldName = "IsEmriKodu";
            this.colIsEmriKodu.Name = "colIsEmriKodu";
            this.colIsEmriKodu.OptionsColumn.AllowEdit = false;
            this.colIsEmriKodu.Visible = true;
            this.colIsEmriKodu.VisibleIndex = 2;
            // 
            // colIsEmriTipi
            // 
            this.colIsEmriTipi.FieldName = "IsEmriTipi";
            this.colIsEmriTipi.Name = "colIsEmriTipi";
            this.colIsEmriTipi.OptionsColumn.AllowEdit = false;
            this.colIsEmriTipi.Visible = true;
            this.colIsEmriTipi.VisibleIndex = 1;
            this.colIsEmriTipi.Width = 108;
            // 
            // colGenelDurumu
            // 
            this.colGenelDurumu.FieldName = "GenelDurumu";
            this.colGenelDurumu.Name = "colGenelDurumu";
            this.colGenelDurumu.OptionsColumn.AllowEdit = false;
            this.colGenelDurumu.Visible = true;
            this.colGenelDurumu.VisibleIndex = 0;
            this.colGenelDurumu.Width = 178;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 10;
            this.colAciklama.Width = 207;
            // 
            // colPartiNo
            // 
            this.colPartiNo.FieldName = "PartiNo";
            this.colPartiNo.Name = "colPartiNo";
            this.colPartiNo.OptionsColumn.AllowEdit = false;
            this.colPartiNo.Visible = true;
            this.colPartiNo.VisibleIndex = 9;
            this.colPartiNo.Width = 118;
            // 
            // colStokKartiId
            // 
            this.colStokKartiId.FieldName = "StokKartiId";
            this.colStokKartiId.Name = "colStokKartiId";
            this.colStokKartiId.OptionsColumn.AllowEdit = false;
            this.colStokKartiId.Visible = true;
            this.colStokKartiId.VisibleIndex = 3;
            this.colStokKartiId.Width = 225;
            // 
            // colMiktar
            // 
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 4;
            // 
            // colBirimId
            // 
            this.colBirimId.FieldName = "BirimId";
            this.colBirimId.Name = "colBirimId";
            this.colBirimId.OptionsColumn.AllowEdit = false;
            this.colBirimId.Visible = true;
            this.colBirimId.VisibleIndex = 5;
            this.colBirimId.Width = 70;
            // 
            // colMakinaId
            // 
            this.colMakinaId.FieldName = "MakinaId";
            this.colMakinaId.Name = "colMakinaId";
            this.colMakinaId.OptionsColumn.AllowEdit = false;
            this.colMakinaId.Visible = true;
            this.colMakinaId.VisibleIndex = 6;
            this.colMakinaId.Width = 126;
            // 
            // colCarpan
            // 
            this.colCarpan.FieldName = "Carpan";
            this.colCarpan.Name = "colCarpan";
            this.colCarpan.OptionsColumn.AllowEdit = false;
            // 
            // colBaglantiAdres
            // 
            this.colBaglantiAdres.FieldName = "BaglantiAdres";
            this.colBaglantiAdres.Name = "colBaglantiAdres";
            this.colBaglantiAdres.OptionsColumn.AllowEdit = false;
            this.colBaglantiAdres.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colBaglantiId
            // 
            this.colBaglantiId.FieldName = "BaglantiId";
            this.colBaglantiId.Name = "colBaglantiId";
            this.colBaglantiId.OptionsColumn.AllowEdit = false;
            this.colBaglantiId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colPlanlananBaslangicTarihi
            // 
            this.colPlanlananBaslangicTarihi.FieldName = "PlanlananBaslangicTarihi";
            this.colPlanlananBaslangicTarihi.Name = "colPlanlananBaslangicTarihi";
            this.colPlanlananBaslangicTarihi.OptionsColumn.AllowEdit = false;
            this.colPlanlananBaslangicTarihi.Width = 137;
            // 
            // colPlananBitisTarihi
            // 
            this.colPlananBitisTarihi.FieldName = "PlananBitisTarihi";
            this.colPlananBitisTarihi.Name = "colPlananBitisTarihi";
            this.colPlananBitisTarihi.OptionsColumn.AllowEdit = false;
            this.colPlananBitisTarihi.Width = 99;
            // 
            // colBaslamaTarihi
            // 
            this.colBaslamaTarihi.FieldName = "BaslamaTarihi";
            this.colBaslamaTarihi.Name = "colBaslamaTarihi";
            this.colBaslamaTarihi.OptionsColumn.AllowEdit = false;
            this.colBaslamaTarihi.Visible = true;
            this.colBaslamaTarihi.VisibleIndex = 7;
            // 
            // colKapanisTarihi
            // 
            this.colKapanisTarihi.FieldName = "KapanisTarihi";
            this.colKapanisTarihi.Name = "colKapanisTarihi";
            this.colKapanisTarihi.OptionsColumn.AllowEdit = false;
            this.colKapanisTarihi.Visible = true;
            this.colKapanisTarihi.VisibleIndex = 8;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.OptionsColumn.AllowEdit = false;
            // 
            // colDegistirmeTarihi
            // 
            this.colDegistirmeTarihi.FieldName = "DegistirmeTarihi";
            this.colDegistirmeTarihi.Name = "colDegistirmeTarihi";
            this.colDegistirmeTarihi.OptionsColumn.AllowEdit = false;
            // 
            // colKayitUserId
            // 
            this.colKayitUserId.FieldName = "KayitUserId";
            this.colKayitUserId.Name = "colKayitUserId";
            this.colKayitUserId.OptionsColumn.AllowEdit = false;
            // 
            // colDegistirmeUserId
            // 
            this.colDegistirmeUserId.FieldName = "DegistirmeUserId";
            this.colDegistirmeUserId.Name = "colDegistirmeUserId";
            this.colDegistirmeUserId.OptionsColumn.AllowEdit = false;
            // 
            // colIsEmriOperasyon
            // 
            this.colIsEmriOperasyon.FieldName = "IsEmriOperasyon";
            this.colIsEmriOperasyon.Name = "colIsEmriOperasyon";
            this.colIsEmriOperasyon.OptionsColumn.AllowEdit = false;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.FieldName = "colTotal";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.UnboundExpression = "Iif(DateDiffDay([PlananBitisTarihi], [KapanisTarihi]) > 0, DateDiffDay([PlananBit" +
    "isTarihi], [KapanisTarihi]) + \' gün geçikti!\', \'\')";
            this.colTotal.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 11;
            this.colTotal.Width = 154;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiYeniIsEmri,
            this.bbiGuncelle,
            this.btnAc,
            this.btnYazdir,
            this.bbiExport,
            this.bbiExpand});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiYeniIsEmri),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAc),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiGuncelle),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnYazdir),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExpand)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbiYeniIsEmri
            // 
            this.bbiYeniIsEmri.Caption = "Yeni İş Emri";
            this.bbiYeniIsEmri.Id = 0;
            this.bbiYeniIsEmri.Name = "bbiYeniIsEmri";
            this.bbiYeniIsEmri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiYeniIsEmri_ItemClick);
            // 
            // btnAc
            // 
            this.btnAc.Caption = "Aç";
            this.btnAc.Id = 2;
            this.btnAc.Name = "btnAc";
            this.btnAc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAc_ItemClick);
            // 
            // bbiGuncelle
            // 
            this.bbiGuncelle.Caption = "Güncelle";
            this.bbiGuncelle.Id = 1;
            this.bbiGuncelle.Name = "bbiGuncelle";
            this.bbiGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuncelle_ItemClick);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Caption = "Yazdır";
            this.btnYazdir.Id = 3;
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYazdir_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Dışarı Aktar";
            this.bbiExport.Id = 4;
            this.bbiExport.Name = "bbiExport";
            // 
            // bbiExpand
            // 
            this.bbiExpand.Caption = "Tüm Detaylari Gör";
            this.bbiExpand.Id = 5;
            this.bbiExpand.Name = "bbiExpand";
            this.bbiExpand.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExpand_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1520, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 430);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1520, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 410);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1520, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 410);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // FrmIsEmirleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 450);
            this.Controls.Add(this.gcHareket);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmIsEmirleri";
            this.Text = "İş Emirleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIsEmirleri_FormClosing);
            this.Load += new System.EventHandler(this.FrmIsEmirleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ısEmriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHareket;
        private DevExpress.XtraBars.BarButtonItem bbiYeniIsEmri;
        private DevExpress.XtraBars.BarButtonItem bbiGuncelle;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDonemId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEmriKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEmriTipi;
        private DevExpress.XtraGrid.Columns.GridColumn colGenelDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colPartiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKartiId;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimId;
        private DevExpress.XtraGrid.Columns.GridColumn colMakinaId;
        private DevExpress.XtraGrid.Columns.GridColumn colCarpan;
        private DevExpress.XtraGrid.Columns.GridColumn colBaglantiAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colBaglantiId;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanlananBaslangicTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colPlananBitisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colBaslamaTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colKapanisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colDegistirmeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colDegistirmeUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEmriOperasyon;
        private DevExpress.XtraBars.BarButtonItem btnAc;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private System.Windows.Forms.BindingSource ısEmriBindingSource;
        private DevExpress.XtraBars.BarButtonItem btnYazdir;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarButtonItem bbiExpand;
    }
}