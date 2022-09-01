namespace Sanmark.ERP.WinUI.Stoklar
{
    partial class FrmUrunAgaclari
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
            this.btnGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pnlControl = new DevExpress.XtraEditors.PanelControl();
            this.gcUrunAgaclari = new DevExpress.XtraGrid.GridControl();
            this.gvUrunAgaclari = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSirketId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceteKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimPay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimPayda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRevizyonNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRevizyonTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarpan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMakinaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegistirmeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegistirmeUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSirket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMakina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunReceteDetay = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl)).BeginInit();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUrunAgaclari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUrunAgaclari)).BeginInit();
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
            this.bbiSil,
            this.btnGuncelle});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSil),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGuncelle)});
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
            this.bbiYeniStokKart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiYeniStokKart_ItemClick);
            // 
            // bbiStokKartAc
            // 
            this.bbiStokKartAc.Caption = "Aç";
            this.bbiStokKartAc.Id = 1;
            this.bbiStokKartAc.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.purchase_order32;
            this.bbiStokKartAc.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.bbiStokKartAc.Name = "bbiStokKartAc";
            this.bbiStokKartAc.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiStokKartAc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiStokKartAc_ItemClick);
            // 
            // bbiSil
            // 
            this.bbiSil.Caption = "Sil";
            this.bbiSil.Id = 2;
            this.bbiSil.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.Delete;
            this.bbiSil.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete));
            this.bbiSil.Name = "bbiSil";
            this.bbiSil.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiSil.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSil_ItemClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Caption = "Güncelle";
            this.btnGuncelle.Id = 3;
            this.btnGuncelle.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.refresh;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuncelle_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1267, 61);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 430);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1267, 20);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1267, 61);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 369);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.gcUrunAgaclari);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(0, 61);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1267, 369);
            this.pnlControl.TabIndex = 8;
            // 
            // gcUrunAgaclari
            // 
            this.gcUrunAgaclari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUrunAgaclari.Location = new System.Drawing.Point(2, 2);
            this.gcUrunAgaclari.MainView = this.gvUrunAgaclari;
            this.gcUrunAgaclari.Name = "gcUrunAgaclari";
            this.gcUrunAgaclari.Size = new System.Drawing.Size(1263, 365);
            this.gcUrunAgaclari.TabIndex = 0;
            this.gcUrunAgaclari.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUrunAgaclari});
            this.gcUrunAgaclari.Click += new System.EventHandler(this.gcUrunAgaclari_Click);
            // 
            // gvUrunAgaclari
            // 
            this.gvUrunAgaclari.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colIsActive,
            this.colSirketId,
            this.colReceteKodu,
            this.colStokId,
            this.colDepoId,
            this.colMiktar,
            this.colBirimId,
            this.colBirimPay,
            this.colBirimPayda,
            this.colAciklama,
            this.colRevizyonNo,
            this.colRevizyonTarihi,
            this.colCarpan,
            this.colMakinaId,
            this.colKayitTarihi,
            this.colDegistirmeTarihi,
            this.colKayitUserId,
            this.colDegistirmeUserId,
            this.colSirket,
            this.colStok,
            this.colDepo,
            this.colStokBirim,
            this.colMakina,
            this.colUrunReceteDetay});
            this.gvUrunAgaclari.GridControl = this.gcUrunAgaclari;
            this.gvUrunAgaclari.Name = "gvUrunAgaclari";
            this.gvUrunAgaclari.OptionsBehavior.AutoPopulateColumns = false;
            this.gvUrunAgaclari.OptionsView.ColumnAutoWidth = false;
            this.gvUrunAgaclari.OptionsView.ShowAutoFilterRow = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 33;
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.OptionsColumn.AllowEdit = false;
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 1;
            this.colIsActive.Width = 55;
            // 
            // colSirketId
            // 
            this.colSirketId.FieldName = "SirketId";
            this.colSirketId.Name = "colSirketId";
            this.colSirketId.OptionsColumn.AllowEdit = false;
            this.colSirketId.Visible = true;
            this.colSirketId.VisibleIndex = 2;
            this.colSirketId.Width = 62;
            // 
            // colReceteKodu
            // 
            this.colReceteKodu.FieldName = "ReceteKodu";
            this.colReceteKodu.Name = "colReceteKodu";
            this.colReceteKodu.OptionsColumn.AllowEdit = false;
            this.colReceteKodu.Visible = true;
            this.colReceteKodu.VisibleIndex = 3;
            this.colReceteKodu.Width = 118;
            // 
            // colStokId
            // 
            this.colStokId.FieldName = "StokId";
            this.colStokId.Name = "colStokId";
            this.colStokId.OptionsColumn.AllowEdit = false;
            this.colStokId.Visible = true;
            this.colStokId.VisibleIndex = 4;
            this.colStokId.Width = 222;
            // 
            // colDepoId
            // 
            this.colDepoId.FieldName = "DepoId";
            this.colDepoId.Name = "colDepoId";
            this.colDepoId.OptionsColumn.AllowEdit = false;
            this.colDepoId.Visible = true;
            this.colDepoId.VisibleIndex = 10;
            this.colDepoId.Width = 87;
            // 
            // colMiktar
            // 
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 5;
            this.colMiktar.Width = 73;
            // 
            // colBirimId
            // 
            this.colBirimId.FieldName = "BirimId";
            this.colBirimId.Name = "colBirimId";
            this.colBirimId.OptionsColumn.AllowEdit = false;
            this.colBirimId.Visible = true;
            this.colBirimId.VisibleIndex = 6;
            this.colBirimId.Width = 90;
            // 
            // colBirimPay
            // 
            this.colBirimPay.FieldName = "BirimPay";
            this.colBirimPay.Name = "colBirimPay";
            this.colBirimPay.OptionsColumn.AllowEdit = false;
            // 
            // colBirimPayda
            // 
            this.colBirimPayda.FieldName = "BirimPayda";
            this.colBirimPayda.Name = "colBirimPayda";
            this.colBirimPayda.OptionsColumn.AllowEdit = false;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 7;
            this.colAciklama.Width = 234;
            // 
            // colRevizyonNo
            // 
            this.colRevizyonNo.FieldName = "RevizyonNo";
            this.colRevizyonNo.Name = "colRevizyonNo";
            this.colRevizyonNo.OptionsColumn.AllowEdit = false;
            this.colRevizyonNo.Visible = true;
            this.colRevizyonNo.VisibleIndex = 8;
            this.colRevizyonNo.Width = 133;
            // 
            // colRevizyonTarihi
            // 
            this.colRevizyonTarihi.FieldName = "RevizyonTarihi";
            this.colRevizyonTarihi.Name = "colRevizyonTarihi";
            this.colRevizyonTarihi.OptionsColumn.AllowEdit = false;
            this.colRevizyonTarihi.Visible = true;
            this.colRevizyonTarihi.VisibleIndex = 9;
            this.colRevizyonTarihi.Width = 87;
            // 
            // colCarpan
            // 
            this.colCarpan.FieldName = "Carpan";
            this.colCarpan.Name = "colCarpan";
            this.colCarpan.OptionsColumn.AllowEdit = false;
            // 
            // colMakinaId
            // 
            this.colMakinaId.FieldName = "MakinaId";
            this.colMakinaId.Name = "colMakinaId";
            this.colMakinaId.OptionsColumn.AllowEdit = false;
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
            // colSirket
            // 
            this.colSirket.FieldName = "Sirket";
            this.colSirket.Name = "colSirket";
            this.colSirket.OptionsColumn.AllowEdit = false;
            // 
            // colStok
            // 
            this.colStok.FieldName = "Stok";
            this.colStok.Name = "colStok";
            this.colStok.OptionsColumn.AllowEdit = false;
            // 
            // colDepo
            // 
            this.colDepo.FieldName = "Depo";
            this.colDepo.Name = "colDepo";
            this.colDepo.OptionsColumn.AllowEdit = false;
            // 
            // colStokBirim
            // 
            this.colStokBirim.FieldName = "StokBirim";
            this.colStokBirim.Name = "colStokBirim";
            this.colStokBirim.OptionsColumn.AllowEdit = false;
            // 
            // colMakina
            // 
            this.colMakina.FieldName = "Makina";
            this.colMakina.Name = "colMakina";
            this.colMakina.OptionsColumn.AllowEdit = false;
            // 
            // colUrunReceteDetay
            // 
            this.colUrunReceteDetay.FieldName = "UrunReceteDetay";
            this.colUrunReceteDetay.Name = "colUrunReceteDetay";
            this.colUrunReceteDetay.OptionsColumn.AllowEdit = false;
            // 
            // FrmUrunAgaclari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 450);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmUrunAgaclari";
            this.Text = "FrmUrunAgaclari";
            this.Load += new System.EventHandler(this.FrmUrunAgaclari_Load);
            this.Shown += new System.EventHandler(this.FrmUrunAgaclari_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl)).EndInit();
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUrunAgaclari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUrunAgaclari)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcUrunAgaclari;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUrunAgaclari;
        private DevExpress.XtraBars.BarButtonItem btnGuncelle;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colSirketId;
        private DevExpress.XtraGrid.Columns.GridColumn colReceteKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoId;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimId;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimPay;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimPayda;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colRevizyonNo;
        private DevExpress.XtraGrid.Columns.GridColumn colRevizyonTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colCarpan;
        private DevExpress.XtraGrid.Columns.GridColumn colMakinaId;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colDegistirmeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colDegistirmeUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colSirket;
        private DevExpress.XtraGrid.Columns.GridColumn colStok;
        private DevExpress.XtraGrid.Columns.GridColumn colDepo;
        private DevExpress.XtraGrid.Columns.GridColumn colStokBirim;
        private DevExpress.XtraGrid.Columns.GridColumn colMakina;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunReceteDetay;
    }
}