namespace Sanmark.ERP.WinUI.Uretim
{
    partial class FrmTartimOperasyonlar
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcIsEmirleri = new DevExpress.XtraGrid.GridControl();
            this.gvIsEmirleri = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.gcIsEmirOperasyonlari = new DevExpress.XtraGrid.GridControl();
            this.gvIsEmirOperasyonlari = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOperasyonId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonDonemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonIsEmriId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonStokKartiId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonReelMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonBirimId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonCarpan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonLotNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonReferansNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonGenelDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonIslemBaslamaTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonIslemBitisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonSonKullanimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonFireMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonMakinaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonDegistirmeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonKayitUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonDegistirmeUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonUrunReceteId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonUrunReceteDetayId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonIsEmriOperasyonIslem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonIsEmri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonDonem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonStokKarti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonMakina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonStokBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonUrunRecete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperasyonUrunReceteDetay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bbiGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnHammaddeFoyYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.btnUretimBitir = new DevExpress.XtraEditors.SimpleButton();
            this.btnUretimBaslat = new DevExpress.XtraEditors.SimpleButton();
            this.tsOtomatikYazdir = new DevExpress.XtraEditors.ToggleSwitch();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcIslemler = new DevExpress.XtraGrid.GridControl();
            this.gvIslemler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIslemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemDonemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemIsEmriOperasyonId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemTartimLotNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemTartimReferansNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemTartimTartan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemTartimKontrolEden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemTartimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemTartimMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemTartimDara = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemTartimBrut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemTartimBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemTartimUrunId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemSonKullanimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemDegistirmeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemKayitUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemDegistirmeUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemIsEmriOperasyon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemDonem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemStokKarti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtTartimBrut = new DevExpress.XtraEditors.SpinEdit();
            this.txtTartimDara = new DevExpress.XtraEditors.SpinEdit();
            this.txtSonKullanimTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtTartimKontrolEden = new DevExpress.XtraEditors.TextEdit();
            this.txtTartimTartan = new DevExpress.XtraEditors.TextEdit();
            this.txtTartimReferansNo = new DevExpress.XtraEditors.TextEdit();
            this.txtTartimBirim = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtTartimMiktar = new DevExpress.XtraEditors.SpinEdit();
            this.txtTartimLot = new DevExpress.XtraEditors.ButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnTartiOku = new DevExpress.XtraEditors.SimpleButton();
            this.btnTartimKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcIsEmirleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIsEmirleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcIsEmirOperasyonlari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIsEmirOperasyonlari)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsOtomatikYazdir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcIslemler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIslemler)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTartimBrut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTartimDara.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSonKullanimTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSonKullanimTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTartimKontrolEden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTartimTartan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTartimReferansNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTartimBirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTartimMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTartimLot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gcIsEmirleri);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gcIsEmirOperasyonlari);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.ShowSplitGlyph = DevExpress.Utils.DefaultBoolean.True;
            this.splitContainerControl1.Size = new System.Drawing.Size(1610, 230);
            this.splitContainerControl1.SplitterPosition = 395;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // gcIsEmirleri
            // 
            this.gcIsEmirleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcIsEmirleri.Location = new System.Drawing.Point(0, 0);
            this.gcIsEmirleri.MainView = this.gvIsEmirleri;
            this.gcIsEmirleri.Name = "gcIsEmirleri";
            this.gcIsEmirleri.Size = new System.Drawing.Size(395, 230);
            this.gcIsEmirleri.TabIndex = 0;
            this.gcIsEmirleri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvIsEmirleri});
            // 
            // gvIsEmirleri
            // 
            this.gvIsEmirleri.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.colIsEmriOperasyon});
            this.gvIsEmirleri.GridControl = this.gcIsEmirleri;
            this.gvIsEmirleri.Name = "gvIsEmirleri";
            this.gvIsEmirleri.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvIsEmirleri_RowCellClick);
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
            this.colIsEmriKodu.VisibleIndex = 0;
            this.colIsEmriKodu.Width = 144;
            // 
            // colIsEmriTipi
            // 
            this.colIsEmriTipi.FieldName = "IsEmriTipi";
            this.colIsEmriTipi.Name = "colIsEmriTipi";
            this.colIsEmriTipi.OptionsColumn.AllowEdit = false;
            // 
            // colGenelDurumu
            // 
            this.colGenelDurumu.FieldName = "GenelDurumu";
            this.colGenelDurumu.Name = "colGenelDurumu";
            this.colGenelDurumu.OptionsColumn.AllowEdit = false;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 1;
            this.colAciklama.Width = 226;
            // 
            // colPartiNo
            // 
            this.colPartiNo.FieldName = "PartiNo";
            this.colPartiNo.Name = "colPartiNo";
            this.colPartiNo.OptionsColumn.AllowEdit = false;
            // 
            // colStokKartiId
            // 
            this.colStokKartiId.FieldName = "StokKartiId";
            this.colStokKartiId.Name = "colStokKartiId";
            this.colStokKartiId.OptionsColumn.AllowEdit = false;
            // 
            // colMiktar
            // 
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            // 
            // colBirimId
            // 
            this.colBirimId.FieldName = "BirimId";
            this.colBirimId.Name = "colBirimId";
            this.colBirimId.OptionsColumn.AllowEdit = false;
            // 
            // colMakinaId
            // 
            this.colMakinaId.FieldName = "MakinaId";
            this.colMakinaId.Name = "colMakinaId";
            this.colMakinaId.OptionsColumn.AllowEdit = false;
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
            // 
            // colBaglantiId
            // 
            this.colBaglantiId.FieldName = "BaglantiId";
            this.colBaglantiId.Name = "colBaglantiId";
            this.colBaglantiId.OptionsColumn.AllowEdit = false;
            // 
            // colPlanlananBaslangicTarihi
            // 
            this.colPlanlananBaslangicTarihi.FieldName = "PlanlananBaslangicTarihi";
            this.colPlanlananBaslangicTarihi.Name = "colPlanlananBaslangicTarihi";
            this.colPlanlananBaslangicTarihi.OptionsColumn.AllowEdit = false;
            // 
            // colPlananBitisTarihi
            // 
            this.colPlananBitisTarihi.FieldName = "PlananBitisTarihi";
            this.colPlananBitisTarihi.Name = "colPlananBitisTarihi";
            this.colPlananBitisTarihi.OptionsColumn.AllowEdit = false;
            // 
            // colBaslamaTarihi
            // 
            this.colBaslamaTarihi.FieldName = "BaslamaTarihi";
            this.colBaslamaTarihi.Name = "colBaslamaTarihi";
            this.colBaslamaTarihi.OptionsColumn.AllowEdit = false;
            // 
            // colKapanisTarihi
            // 
            this.colKapanisTarihi.FieldName = "KapanisTarihi";
            this.colKapanisTarihi.Name = "colKapanisTarihi";
            this.colKapanisTarihi.OptionsColumn.AllowEdit = false;
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
            // gcIsEmirOperasyonlari
            // 
            this.gcIsEmirOperasyonlari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcIsEmirOperasyonlari.Location = new System.Drawing.Point(0, 0);
            this.gcIsEmirOperasyonlari.MainView = this.gvIsEmirOperasyonlari;
            this.gcIsEmirOperasyonlari.Name = "gcIsEmirOperasyonlari";
            this.gcIsEmirOperasyonlari.Size = new System.Drawing.Size(1205, 230);
            this.gcIsEmirOperasyonlari.TabIndex = 0;
            this.gcIsEmirOperasyonlari.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvIsEmirOperasyonlari});
            // 
            // gvIsEmirOperasyonlari
            // 
            this.gvIsEmirOperasyonlari.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOperasyonId,
            this.colOperasyonDonemId,
            this.colOperasyonIsEmriId,
            this.colOperasyonStokKartiId,
            this.colOperasyonMiktar,
            this.colOperasyonReelMiktar,
            this.colOperasyonBirimId,
            this.colOperasyonCarpan,
            this.colOperasyonLotNo,
            this.colOperasyonReferansNo,
            this.colOperasyonGenelDurum,
            this.colOperasyonIslemBaslamaTarihi,
            this.colOperasyonIslemBitisTarihi,
            this.colOperasyonSonKullanimTarihi,
            this.colOperasyonFireMiktari,
            this.colOperasyonMakinaId,
            this.colOperasyonKayitTarihi,
            this.colOperasyonDegistirmeTarihi,
            this.colOperasyonKayitUserId,
            this.colOperasyonDegistirmeUserId,
            this.colOperasyonUrunReceteId,
            this.colOperasyonUrunReceteDetayId,
            this.colOperasyonIsEmriOperasyonIslem,
            this.colOperasyonIsEmri,
            this.colOperasyonDonem,
            this.colOperasyonStokKarti,
            this.colOperasyonMakina,
            this.colOperasyonStokBirim,
            this.colOperasyonUrunRecete,
            this.colOperasyonUrunReceteDetay});
            this.gvIsEmirOperasyonlari.GridControl = this.gcIsEmirOperasyonlari;
            this.gvIsEmirOperasyonlari.Name = "gvIsEmirOperasyonlari";
            this.gvIsEmirOperasyonlari.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvIsEmirOperasyonlari_RowCellClick);
            // 
            // colOperasyonId
            // 
            this.colOperasyonId.FieldName = "Id";
            this.colOperasyonId.Name = "colOperasyonId";
            this.colOperasyonId.OptionsColumn.AllowEdit = false;
            // 
            // colOperasyonDonemId
            // 
            this.colOperasyonDonemId.FieldName = "DonemId";
            this.colOperasyonDonemId.Name = "colOperasyonDonemId";
            this.colOperasyonDonemId.OptionsColumn.AllowEdit = false;
            // 
            // colOperasyonIsEmriId
            // 
            this.colOperasyonIsEmriId.FieldName = "IsEmriId";
            this.colOperasyonIsEmriId.Name = "colOperasyonIsEmriId";
            this.colOperasyonIsEmriId.OptionsColumn.AllowEdit = false;
            // 
            // colOperasyonStokKartiId
            // 
            this.colOperasyonStokKartiId.FieldName = "StokKartiId";
            this.colOperasyonStokKartiId.Name = "colOperasyonStokKartiId";
            this.colOperasyonStokKartiId.OptionsColumn.AllowEdit = false;
            this.colOperasyonStokKartiId.Visible = true;
            this.colOperasyonStokKartiId.VisibleIndex = 1;
            this.colOperasyonStokKartiId.Width = 318;
            // 
            // colOperasyonMiktar
            // 
            this.colOperasyonMiktar.FieldName = "Miktar";
            this.colOperasyonMiktar.Name = "colOperasyonMiktar";
            this.colOperasyonMiktar.OptionsColumn.AllowEdit = false;
            this.colOperasyonMiktar.Visible = true;
            this.colOperasyonMiktar.VisibleIndex = 2;
            this.colOperasyonMiktar.Width = 76;
            // 
            // colOperasyonReelMiktar
            // 
            this.colOperasyonReelMiktar.FieldName = "ReelMiktar";
            this.colOperasyonReelMiktar.Name = "colOperasyonReelMiktar";
            this.colOperasyonReelMiktar.OptionsColumn.AllowEdit = false;
            this.colOperasyonReelMiktar.Visible = true;
            this.colOperasyonReelMiktar.VisibleIndex = 3;
            this.colOperasyonReelMiktar.Width = 64;
            // 
            // colOperasyonBirimId
            // 
            this.colOperasyonBirimId.FieldName = "BirimId";
            this.colOperasyonBirimId.Name = "colOperasyonBirimId";
            this.colOperasyonBirimId.OptionsColumn.AllowEdit = false;
            this.colOperasyonBirimId.Visible = true;
            this.colOperasyonBirimId.VisibleIndex = 4;
            this.colOperasyonBirimId.Width = 154;
            // 
            // colOperasyonCarpan
            // 
            this.colOperasyonCarpan.FieldName = "Carpan";
            this.colOperasyonCarpan.Name = "colOperasyonCarpan";
            this.colOperasyonCarpan.OptionsColumn.AllowEdit = false;
            // 
            // colOperasyonLotNo
            // 
            this.colOperasyonLotNo.FieldName = "LotNo";
            this.colOperasyonLotNo.Name = "colOperasyonLotNo";
            this.colOperasyonLotNo.OptionsColumn.AllowEdit = false;
            // 
            // colOperasyonReferansNo
            // 
            this.colOperasyonReferansNo.FieldName = "ReferansNo";
            this.colOperasyonReferansNo.Name = "colOperasyonReferansNo";
            this.colOperasyonReferansNo.OptionsColumn.AllowEdit = false;
            // 
            // colOperasyonGenelDurum
            // 
            this.colOperasyonGenelDurum.FieldName = "GenelDurum";
            this.colOperasyonGenelDurum.Name = "colOperasyonGenelDurum";
            this.colOperasyonGenelDurum.OptionsColumn.AllowEdit = false;
            this.colOperasyonGenelDurum.Visible = true;
            this.colOperasyonGenelDurum.VisibleIndex = 0;
            this.colOperasyonGenelDurum.Width = 132;
            // 
            // colOperasyonIslemBaslamaTarihi
            // 
            this.colOperasyonIslemBaslamaTarihi.FieldName = "IslemBaslamaTarihi";
            this.colOperasyonIslemBaslamaTarihi.Name = "colOperasyonIslemBaslamaTarihi";
            this.colOperasyonIslemBaslamaTarihi.OptionsColumn.AllowEdit = false;
            // 
            // colOperasyonIslemBitisTarihi
            // 
            this.colOperasyonIslemBitisTarihi.FieldName = "IslemBitisTarihi";
            this.colOperasyonIslemBitisTarihi.Name = "colOperasyonIslemBitisTarihi";
            this.colOperasyonIslemBitisTarihi.OptionsColumn.AllowEdit = false;
            // 
            // colOperasyonSonKullanimTarihi
            // 
            this.colOperasyonSonKullanimTarihi.FieldName = "SonKullanimTarihi";
            this.colOperasyonSonKullanimTarihi.Name = "colOperasyonSonKullanimTarihi";
            this.colOperasyonSonKullanimTarihi.OptionsColumn.AllowEdit = false;
            // 
            // colOperasyonFireMiktari
            // 
            this.colOperasyonFireMiktari.FieldName = "FireMiktari";
            this.colOperasyonFireMiktari.Name = "colOperasyonFireMiktari";
            this.colOperasyonFireMiktari.OptionsColumn.AllowEdit = false;
            // 
            // colOperasyonMakinaId
            // 
            this.colOperasyonMakinaId.FieldName = "MakinaId";
            this.colOperasyonMakinaId.Name = "colOperasyonMakinaId";
            this.colOperasyonMakinaId.OptionsColumn.AllowEdit = false;
            // 
            // colOperasyonKayitTarihi
            // 
            this.colOperasyonKayitTarihi.FieldName = "KayitTarihi";
            this.colOperasyonKayitTarihi.Name = "colOperasyonKayitTarihi";
            this.colOperasyonKayitTarihi.OptionsColumn.AllowEdit = false;
            // 
            // colOperasyonDegistirmeTarihi
            // 
            this.colOperasyonDegistirmeTarihi.FieldName = "DegistirmeTarihi";
            this.colOperasyonDegistirmeTarihi.Name = "colOperasyonDegistirmeTarihi";
            this.colOperasyonDegistirmeTarihi.OptionsColumn.AllowEdit = false;
            // 
            // colOperasyonKayitUserId
            // 
            this.colOperasyonKayitUserId.FieldName = "KayitUserId";
            this.colOperasyonKayitUserId.Name = "colOperasyonKayitUserId";
            this.colOperasyonKayitUserId.OptionsColumn.AllowEdit = false;
            // 
            // colOperasyonDegistirmeUserId
            // 
            this.colOperasyonDegistirmeUserId.FieldName = "DegistirmeUserId";
            this.colOperasyonDegistirmeUserId.Name = "colOperasyonDegistirmeUserId";
            this.colOperasyonDegistirmeUserId.OptionsColumn.AllowEdit = false;
            // 
            // colOperasyonUrunReceteId
            // 
            this.colOperasyonUrunReceteId.FieldName = "UrunReceteId";
            this.colOperasyonUrunReceteId.Name = "colOperasyonUrunReceteId";
            this.colOperasyonUrunReceteId.OptionsColumn.AllowEdit = false;
            // 
            // colOperasyonUrunReceteDetayId
            // 
            this.colOperasyonUrunReceteDetayId.FieldName = "UrunReceteDetayId";
            this.colOperasyonUrunReceteDetayId.Name = "colOperasyonUrunReceteDetayId";
            this.colOperasyonUrunReceteDetayId.OptionsColumn.AllowEdit = false;
            // 
            // colOperasyonIsEmriOperasyonIslem
            // 
            this.colOperasyonIsEmriOperasyonIslem.FieldName = "IsEmriOperasyonIslem";
            this.colOperasyonIsEmriOperasyonIslem.Name = "colOperasyonIsEmriOperasyonIslem";
            this.colOperasyonIsEmriOperasyonIslem.OptionsColumn.AllowEdit = false;
            this.colOperasyonIsEmriOperasyonIslem.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colOperasyonIsEmri
            // 
            this.colOperasyonIsEmri.FieldName = "IsEmri";
            this.colOperasyonIsEmri.Name = "colOperasyonIsEmri";
            this.colOperasyonIsEmri.OptionsColumn.AllowEdit = false;
            this.colOperasyonIsEmri.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colOperasyonDonem
            // 
            this.colOperasyonDonem.FieldName = "Donem";
            this.colOperasyonDonem.Name = "colOperasyonDonem";
            this.colOperasyonDonem.OptionsColumn.AllowEdit = false;
            this.colOperasyonDonem.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colOperasyonStokKarti
            // 
            this.colOperasyonStokKarti.FieldName = "StokKarti";
            this.colOperasyonStokKarti.Name = "colOperasyonStokKarti";
            this.colOperasyonStokKarti.OptionsColumn.AllowEdit = false;
            this.colOperasyonStokKarti.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colOperasyonMakina
            // 
            this.colOperasyonMakina.FieldName = "Makina";
            this.colOperasyonMakina.Name = "colOperasyonMakina";
            this.colOperasyonMakina.OptionsColumn.AllowEdit = false;
            this.colOperasyonMakina.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colOperasyonStokBirim
            // 
            this.colOperasyonStokBirim.FieldName = "StokBirim";
            this.colOperasyonStokBirim.Name = "colOperasyonStokBirim";
            this.colOperasyonStokBirim.OptionsColumn.AllowEdit = false;
            this.colOperasyonStokBirim.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colOperasyonUrunRecete
            // 
            this.colOperasyonUrunRecete.FieldName = "UrunRecete";
            this.colOperasyonUrunRecete.Name = "colOperasyonUrunRecete";
            this.colOperasyonUrunRecete.OptionsColumn.AllowEdit = false;
            this.colOperasyonUrunRecete.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colOperasyonUrunReceteDetay
            // 
            this.colOperasyonUrunReceteDetay.FieldName = "UrunReceteDetay";
            this.colOperasyonUrunReceteDetay.Name = "colOperasyonUrunReceteDetay";
            this.colOperasyonUrunReceteDetay.OptionsColumn.AllowEdit = false;
            this.colOperasyonUrunReceteDetay.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bbiGuncelle);
            this.panel1.Controls.Add(this.btnHammaddeFoyYazdir);
            this.panel1.Controls.Add(this.btnUretimBitir);
            this.panel1.Controls.Add(this.btnUretimBaslat);
            this.panel1.Controls.Add(this.tsOtomatikYazdir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1610, 71);
            this.panel1.TabIndex = 1;
            // 
            // bbiGuncelle
            // 
            this.bbiGuncelle.Location = new System.Drawing.Point(4, 6);
            this.bbiGuncelle.Name = "bbiGuncelle";
            this.bbiGuncelle.Size = new System.Drawing.Size(87, 43);
            this.bbiGuncelle.TabIndex = 2;
            this.bbiGuncelle.Text = "Güncelle";
            this.bbiGuncelle.Click += new System.EventHandler(this.bbiGuncelle_Click);
            // 
            // btnHammaddeFoyYazdir
            // 
            this.btnHammaddeFoyYazdir.Location = new System.Drawing.Point(97, 6);
            this.btnHammaddeFoyYazdir.Name = "btnHammaddeFoyYazdir";
            this.btnHammaddeFoyYazdir.Size = new System.Drawing.Size(176, 43);
            this.btnHammaddeFoyYazdir.TabIndex = 2;
            this.btnHammaddeFoyYazdir.Text = "Hammadde Kontrol Föyü Yazdır";
            this.btnHammaddeFoyYazdir.Click += new System.EventHandler(this.btnHammaddeFoyYazdir_Click);
            // 
            // btnUretimBitir
            // 
            this.btnUretimBitir.Location = new System.Drawing.Point(495, 6);
            this.btnUretimBitir.Name = "btnUretimBitir";
            this.btnUretimBitir.Size = new System.Drawing.Size(75, 43);
            this.btnUretimBitir.TabIndex = 0;
            this.btnUretimBitir.Text = "Üretim Bitir";
            this.btnUretimBitir.Click += new System.EventHandler(this.btnUretimBitir_Click);
            // 
            // btnUretimBaslat
            // 
            this.btnUretimBaslat.Location = new System.Drawing.Point(405, 6);
            this.btnUretimBaslat.Name = "btnUretimBaslat";
            this.btnUretimBaslat.Size = new System.Drawing.Size(75, 43);
            this.btnUretimBaslat.TabIndex = 0;
            this.btnUretimBaslat.Text = "Üretim Başlat";
            this.btnUretimBaslat.Click += new System.EventHandler(this.btnUretimBaslat_Click);
            // 
            // tsOtomatikYazdir
            // 
            this.tsOtomatikYazdir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tsOtomatikYazdir.Location = new System.Drawing.Point(1243, 47);
            this.tsOtomatikYazdir.Name = "tsOtomatikYazdir";
            this.tsOtomatikYazdir.Properties.AutoWidth = true;
            this.tsOtomatikYazdir.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.tsOtomatikYazdir.Properties.OffText = "Yazdırma Kapalı";
            this.tsOtomatikYazdir.Properties.OnText = "Otomatik Yazdırma Açık";
            this.tsOtomatikYazdir.Size = new System.Drawing.Size(164, 18);
            this.tsOtomatikYazdir.TabIndex = 1;
            this.tsOtomatikYazdir.TabStop = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.panel2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 301);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1610, 423);
            this.panelControl1.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcIslemler);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1235, 419);
            this.panelControl2.TabIndex = 1;
            // 
            // gcIslemler
            // 
            this.gcIslemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcIslemler.Location = new System.Drawing.Point(2, 2);
            this.gcIslemler.MainView = this.gvIslemler;
            this.gcIslemler.Name = "gcIslemler";
            this.gcIslemler.Size = new System.Drawing.Size(1231, 415);
            this.gcIslemler.TabIndex = 0;
            this.gcIslemler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvIslemler});
            // 
            // gvIslemler
            // 
            this.gvIslemler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIslemId,
            this.colIslemDonemId,
            this.colIslemIsEmriOperasyonId,
            this.colIslemTartimLotNo,
            this.colIslemTartimReferansNo,
            this.colIslemTartimTartan,
            this.colIslemTartimKontrolEden,
            this.colIslemTartimTarihi,
            this.colIslemTartimMiktar,
            this.colIslemTartimDara,
            this.colIslemTartimBrut,
            this.colIslemTartimBirim,
            this.colIslemTartimUrunId,
            this.colIslemSonKullanimTarihi,
            this.colIslemKayitTarihi,
            this.colIslemDegistirmeTarihi,
            this.colIslemKayitUserId,
            this.colIslemDegistirmeUserId,
            this.colIslemIsEmriOperasyon,
            this.colIslemDonem,
            this.colIslemStokKarti});
            this.gvIslemler.GridControl = this.gcIslemler;
            this.gvIslemler.Name = "gvIslemler";
            // 
            // colIslemId
            // 
            this.colIslemId.FieldName = "Id";
            this.colIslemId.Name = "colIslemId";
            this.colIslemId.OptionsColumn.AllowEdit = false;
            // 
            // colIslemDonemId
            // 
            this.colIslemDonemId.FieldName = "DonemId";
            this.colIslemDonemId.Name = "colIslemDonemId";
            this.colIslemDonemId.OptionsColumn.AllowEdit = false;
            // 
            // colIslemIsEmriOperasyonId
            // 
            this.colIslemIsEmriOperasyonId.FieldName = "IsEmriOperasyonId";
            this.colIslemIsEmriOperasyonId.Name = "colIslemIsEmriOperasyonId";
            this.colIslemIsEmriOperasyonId.OptionsColumn.AllowEdit = false;
            // 
            // colIslemTartimLotNo
            // 
            this.colIslemTartimLotNo.FieldName = "TartimLotNo";
            this.colIslemTartimLotNo.Name = "colIslemTartimLotNo";
            this.colIslemTartimLotNo.OptionsColumn.AllowEdit = false;
            this.colIslemTartimLotNo.Visible = true;
            this.colIslemTartimLotNo.VisibleIndex = 1;
            this.colIslemTartimLotNo.Width = 385;
            // 
            // colIslemTartimReferansNo
            // 
            this.colIslemTartimReferansNo.FieldName = "TartimReferansNo";
            this.colIslemTartimReferansNo.Name = "colIslemTartimReferansNo";
            this.colIslemTartimReferansNo.OptionsColumn.AllowEdit = false;
            this.colIslemTartimReferansNo.Visible = true;
            this.colIslemTartimReferansNo.VisibleIndex = 2;
            this.colIslemTartimReferansNo.Width = 407;
            // 
            // colIslemTartimTartan
            // 
            this.colIslemTartimTartan.FieldName = "TartimTartan";
            this.colIslemTartimTartan.Name = "colIslemTartimTartan";
            this.colIslemTartimTartan.OptionsColumn.AllowEdit = false;
            // 
            // colIslemTartimKontrolEden
            // 
            this.colIslemTartimKontrolEden.FieldName = "TartimKontrolEden";
            this.colIslemTartimKontrolEden.Name = "colIslemTartimKontrolEden";
            this.colIslemTartimKontrolEden.OptionsColumn.AllowEdit = false;
            // 
            // colIslemTartimTarihi
            // 
            this.colIslemTartimTarihi.FieldName = "TartimTarihi";
            this.colIslemTartimTarihi.Name = "colIslemTartimTarihi";
            this.colIslemTartimTarihi.OptionsColumn.AllowEdit = false;
            this.colIslemTartimTarihi.Visible = true;
            this.colIslemTartimTarihi.VisibleIndex = 0;
            this.colIslemTartimTarihi.Width = 121;
            // 
            // colIslemTartimMiktar
            // 
            this.colIslemTartimMiktar.FieldName = "TartimMiktar";
            this.colIslemTartimMiktar.Name = "colIslemTartimMiktar";
            this.colIslemTartimMiktar.OptionsColumn.AllowEdit = false;
            this.colIslemTartimMiktar.Visible = true;
            this.colIslemTartimMiktar.VisibleIndex = 3;
            this.colIslemTartimMiktar.Width = 104;
            // 
            // colIslemTartimDara
            // 
            this.colIslemTartimDara.FieldName = "TartimDara";
            this.colIslemTartimDara.Name = "colIslemTartimDara";
            this.colIslemTartimDara.OptionsColumn.AllowEdit = false;
            this.colIslemTartimDara.Visible = true;
            this.colIslemTartimDara.VisibleIndex = 4;
            this.colIslemTartimDara.Width = 70;
            // 
            // colIslemTartimBrut
            // 
            this.colIslemTartimBrut.FieldName = "TartimBrut";
            this.colIslemTartimBrut.Name = "colIslemTartimBrut";
            this.colIslemTartimBrut.OptionsColumn.AllowEdit = false;
            this.colIslemTartimBrut.Visible = true;
            this.colIslemTartimBrut.VisibleIndex = 5;
            this.colIslemTartimBrut.Width = 70;
            // 
            // colIslemTartimBirim
            // 
            this.colIslemTartimBirim.FieldName = "TartimBirim";
            this.colIslemTartimBirim.Name = "colIslemTartimBirim";
            this.colIslemTartimBirim.OptionsColumn.AllowEdit = false;
            this.colIslemTartimBirim.Visible = true;
            this.colIslemTartimBirim.VisibleIndex = 6;
            this.colIslemTartimBirim.Width = 52;
            // 
            // colIslemTartimUrunId
            // 
            this.colIslemTartimUrunId.FieldName = "TartimUrunId";
            this.colIslemTartimUrunId.Name = "colIslemTartimUrunId";
            this.colIslemTartimUrunId.OptionsColumn.AllowEdit = false;
            // 
            // colIslemSonKullanimTarihi
            // 
            this.colIslemSonKullanimTarihi.FieldName = "SonKullanimTarihi";
            this.colIslemSonKullanimTarihi.Name = "colIslemSonKullanimTarihi";
            this.colIslemSonKullanimTarihi.OptionsColumn.AllowEdit = false;
            this.colIslemSonKullanimTarihi.Visible = true;
            this.colIslemSonKullanimTarihi.VisibleIndex = 7;
            this.colIslemSonKullanimTarihi.Width = 85;
            // 
            // colIslemKayitTarihi
            // 
            this.colIslemKayitTarihi.FieldName = "KayitTarihi";
            this.colIslemKayitTarihi.Name = "colIslemKayitTarihi";
            this.colIslemKayitTarihi.OptionsColumn.AllowEdit = false;
            // 
            // colIslemDegistirmeTarihi
            // 
            this.colIslemDegistirmeTarihi.FieldName = "DegistirmeTarihi";
            this.colIslemDegistirmeTarihi.Name = "colIslemDegistirmeTarihi";
            this.colIslemDegistirmeTarihi.OptionsColumn.AllowEdit = false;
            // 
            // colIslemKayitUserId
            // 
            this.colIslemKayitUserId.FieldName = "KayitUserId";
            this.colIslemKayitUserId.Name = "colIslemKayitUserId";
            this.colIslemKayitUserId.OptionsColumn.AllowEdit = false;
            // 
            // colIslemDegistirmeUserId
            // 
            this.colIslemDegistirmeUserId.FieldName = "DegistirmeUserId";
            this.colIslemDegistirmeUserId.Name = "colIslemDegistirmeUserId";
            this.colIslemDegistirmeUserId.OptionsColumn.AllowEdit = false;
            // 
            // colIslemIsEmriOperasyon
            // 
            this.colIslemIsEmriOperasyon.FieldName = "IsEmriOperasyon";
            this.colIslemIsEmriOperasyon.Name = "colIslemIsEmriOperasyon";
            this.colIslemIsEmriOperasyon.OptionsColumn.AllowEdit = false;
            // 
            // colIslemDonem
            // 
            this.colIslemDonem.FieldName = "Donem";
            this.colIslemDonem.Name = "colIslemDonem";
            this.colIslemDonem.OptionsColumn.AllowEdit = false;
            // 
            // colIslemStokKarti
            // 
            this.colIslemStokKarti.FieldName = "StokKarti";
            this.colIslemStokKarti.Name = "colIslemStokKarti";
            this.colIslemStokKarti.OptionsColumn.AllowEdit = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.layoutControl1);
            this.panel2.Controls.Add(this.panelControl3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1237, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 419);
            this.panel2.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtTartimBrut);
            this.layoutControl1.Controls.Add(this.txtTartimDara);
            this.layoutControl1.Controls.Add(this.txtSonKullanimTarihi);
            this.layoutControl1.Controls.Add(this.txtTartimKontrolEden);
            this.layoutControl1.Controls.Add(this.txtTartimTartan);
            this.layoutControl1.Controls.Add(this.txtTartimReferansNo);
            this.layoutControl1.Controls.Add(this.txtTartimBirim);
            this.layoutControl1.Controls.Add(this.txtTartimMiktar);
            this.layoutControl1.Controls.Add(this.txtTartimLot);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(647, 290, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(371, 382);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtTartimBrut
            // 
            this.txtTartimBrut.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTartimBrut.Location = new System.Drawing.Point(77, 180);
            this.txtTartimBrut.Name = "txtTartimBrut";
            this.txtTartimBrut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTartimBrut.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTartimBrut.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTartimBrut.Size = new System.Drawing.Size(282, 20);
            this.txtTartimBrut.StyleController = this.layoutControl1;
            this.txtTartimBrut.TabIndex = 12;
            // 
            // txtTartimDara
            // 
            this.txtTartimDara.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTartimDara.Location = new System.Drawing.Point(77, 156);
            this.txtTartimDara.Name = "txtTartimDara";
            this.txtTartimDara.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTartimDara.Size = new System.Drawing.Size(282, 20);
            this.txtTartimDara.StyleController = this.layoutControl1;
            this.txtTartimDara.TabIndex = 11;
            // 
            // txtSonKullanimTarihi
            // 
            this.txtSonKullanimTarihi.EditValue = null;
            this.txtSonKullanimTarihi.Location = new System.Drawing.Point(77, 108);
            this.txtSonKullanimTarihi.Name = "txtSonKullanimTarihi";
            this.txtSonKullanimTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSonKullanimTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSonKullanimTarihi.Size = new System.Drawing.Size(282, 20);
            this.txtSonKullanimTarihi.StyleController = this.layoutControl1;
            this.txtSonKullanimTarihi.TabIndex = 9;
            // 
            // txtTartimKontrolEden
            // 
            this.txtTartimKontrolEden.Location = new System.Drawing.Point(77, 84);
            this.txtTartimKontrolEden.Name = "txtTartimKontrolEden";
            this.txtTartimKontrolEden.Size = new System.Drawing.Size(282, 20);
            this.txtTartimKontrolEden.StyleController = this.layoutControl1;
            this.txtTartimKontrolEden.TabIndex = 8;
            // 
            // txtTartimTartan
            // 
            this.txtTartimTartan.Location = new System.Drawing.Point(77, 60);
            this.txtTartimTartan.Name = "txtTartimTartan";
            this.txtTartimTartan.Size = new System.Drawing.Size(282, 20);
            this.txtTartimTartan.StyleController = this.layoutControl1;
            this.txtTartimTartan.TabIndex = 7;
            // 
            // txtTartimReferansNo
            // 
            this.txtTartimReferansNo.Location = new System.Drawing.Point(77, 36);
            this.txtTartimReferansNo.Name = "txtTartimReferansNo";
            this.txtTartimReferansNo.Size = new System.Drawing.Size(282, 20);
            this.txtTartimReferansNo.StyleController = this.layoutControl1;
            this.txtTartimReferansNo.TabIndex = 6;
            // 
            // txtTartimBirim
            // 
            this.txtTartimBirim.Location = new System.Drawing.Point(77, 204);
            this.txtTartimBirim.Name = "txtTartimBirim";
            this.txtTartimBirim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTartimBirim.Properties.NullText = "";
            this.txtTartimBirim.Properties.PopupView = this.gridLookUpEdit1View;
            this.txtTartimBirim.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtTartimBirim.Size = new System.Drawing.Size(282, 20);
            this.txtTartimBirim.StyleController = this.layoutControl1;
            this.txtTartimBirim.TabIndex = 13;
            this.txtTartimBirim.EditValueChanged += new System.EventHandler(this.txtTartimBirim_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtTartimMiktar
            // 
            this.txtTartimMiktar.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTartimMiktar.Location = new System.Drawing.Point(77, 132);
            this.txtTartimMiktar.Name = "txtTartimMiktar";
            this.txtTartimMiktar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTartimMiktar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTartimMiktar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTartimMiktar.Size = new System.Drawing.Size(282, 20);
            this.txtTartimMiktar.StyleController = this.layoutControl1;
            this.txtTartimMiktar.TabIndex = 10;
            // 
            // txtTartimLot
            // 
            this.txtTartimLot.Location = new System.Drawing.Point(77, 12);
            this.txtTartimLot.Name = "txtTartimLot";
            this.txtTartimLot.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtTartimLot.Size = new System.Drawing.Size(282, 20);
            this.txtTartimLot.StyleController = this.layoutControl1;
            this.txtTartimLot.TabIndex = 5;
            this.txtTartimLot.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtTartimLot_ButtonClick);
            this.txtTartimLot.Click += new System.EventHandler(this.txtTartimLot_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(371, 382);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtTartimLot;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(351, 24);
            this.layoutControlItem2.Text = "Lot Numarası";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtTartimReferansNo;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(351, 24);
            this.layoutControlItem3.Text = "Referans No";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtTartimTartan;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(351, 24);
            this.layoutControlItem4.Text = "Kim Tarttı";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtTartimKontrolEden;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(351, 24);
            this.layoutControlItem5.Text = "Kontrol Eden";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtSonKullanimTarihi;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(351, 24);
            this.layoutControlItem6.Text = "SKT / TETT";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtTartimMiktar;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(351, 24);
            this.layoutControlItem7.Text = "Net";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtTartimDara;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(351, 24);
            this.layoutControlItem8.Text = "Dara";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtTartimBrut;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(351, 24);
            this.layoutControlItem9.Text = "Brüt";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtTartimBirim;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(351, 170);
            this.layoutControlItem10.Text = "Tartim Birimi";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(62, 13);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnTartiOku);
            this.panelControl3.Controls.Add(this.btnTartimKaydet);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 382);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(371, 37);
            this.panelControl3.TabIndex = 1;
            // 
            // btnTartiOku
            // 
            this.btnTartiOku.Location = new System.Drawing.Point(267, 9);
            this.btnTartiOku.Name = "btnTartiOku";
            this.btnTartiOku.Size = new System.Drawing.Size(92, 23);
            this.btnTartiOku.TabIndex = 0;
            this.btnTartiOku.Text = "Tartı Oku";
            this.btnTartiOku.Click += new System.EventHandler(this.btnTartiOku_Click);
            // 
            // btnTartimKaydet
            // 
            this.btnTartimKaydet.Location = new System.Drawing.Point(6, 9);
            this.btnTartimKaydet.Name = "btnTartimKaydet";
            this.btnTartimKaydet.Size = new System.Drawing.Size(92, 23);
            this.btnTartimKaydet.TabIndex = 0;
            this.btnTartimKaydet.Text = "Tartim Kaydet";
            this.btnTartimKaydet.Click += new System.EventHandler(this.btnTartimKaydet_Click);
            // 
            // FrmTartimOperasyonlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1610, 724);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmTartimOperasyonlar";
            this.Text = "Tartım İşlemleri";
            this.Load += new System.EventHandler(this.FrmOperasyonlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcIsEmirleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIsEmirleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcIsEmirOperasyonlari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIsEmirOperasyonlari)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsOtomatikYazdir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcIslemler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIslemler)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTartimBrut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTartimDara.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSonKullanimTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSonKullanimTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTartimKontrolEden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTartimTartan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTartimReferansNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTartimBirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTartimMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTartimLot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gcIsEmirleri;
        private DevExpress.XtraGrid.Views.Grid.GridView gvIsEmirleri;
        private DevExpress.XtraGrid.GridControl gcIsEmirOperasyonlari;
        private DevExpress.XtraGrid.Views.Grid.GridView gvIsEmirOperasyonlari;
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
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonId;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonDonemId;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonIsEmriId;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonStokKartiId;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonReelMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonBirimId;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonCarpan;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonLotNo;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonReferansNo;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonGenelDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonIslemBaslamaTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonIslemBitisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonSonKullanimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonFireMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonMakinaId;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonKayitTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonDegistirmeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonKayitUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonDegistirmeUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonUrunReceteId;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonUrunReceteDetayId;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonIsEmriOperasyonIslem;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonIsEmri;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonDonem;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonStokKarti;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonMakina;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonStokBirim;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonUrunRecete;
        private DevExpress.XtraGrid.Columns.GridColumn colOperasyonUrunReceteDetay;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcIslemler;
        private DevExpress.XtraGrid.Views.Grid.GridView gvIslemler;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SpinEdit txtTartimBrut;
        private DevExpress.XtraEditors.SpinEdit txtTartimDara;
        private DevExpress.XtraEditors.DateEdit txtSonKullanimTarihi;
        private DevExpress.XtraEditors.TextEdit txtTartimKontrolEden;
        private DevExpress.XtraEditors.TextEdit txtTartimTartan;
        private DevExpress.XtraEditors.TextEdit txtTartimReferansNo;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemId;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemDonemId;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemIsEmriOperasyonId;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemTartimLotNo;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemTartimReferansNo;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemTartimTartan;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemTartimKontrolEden;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemTartimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemTartimMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemTartimDara;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemTartimBrut;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemTartimBirim;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemTartimUrunId;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemSonKullanimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemKayitTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemDegistirmeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemKayitUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemDegistirmeUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemIsEmriOperasyon;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemDonem;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemStokKarti;
        private DevExpress.XtraEditors.SimpleButton btnTartiOku;
        private DevExpress.XtraEditors.SimpleButton btnTartimKaydet;
        private DevExpress.XtraEditors.SimpleButton btnUretimBaslat;
        private DevExpress.XtraEditors.SimpleButton btnUretimBitir;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.GridLookUpEdit txtTartimBirim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.SpinEdit txtTartimMiktar;
        private DevExpress.XtraEditors.ToggleSwitch tsOtomatikYazdir;
        private DevExpress.XtraEditors.SimpleButton btnHammaddeFoyYazdir;
        private DevExpress.XtraEditors.SimpleButton bbiGuncelle;
        private DevExpress.XtraEditors.ButtonEdit txtTartimLot;
    }
}