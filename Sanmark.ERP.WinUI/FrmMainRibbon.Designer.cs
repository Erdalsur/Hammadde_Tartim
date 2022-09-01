namespace Sanmark.ERP.WinUI
{
    partial class FrmMainRibbon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainRibbon));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSirket = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDonem = new DevExpress.XtraBars.BarButtonItem();
            this.bsiSirket = new DevExpress.XtraBars.BarStaticItem();
            this.bsiDonem = new DevExpress.XtraBars.BarStaticItem();
            this.bsiUser = new DevExpress.XtraBars.BarStaticItem();
            this.bsiInfo = new DevExpress.XtraBars.BarStaticItem();
            this.bbiStokKartlari = new DevExpress.XtraBars.BarButtonItem();
            this.bbiStokGruplar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBirimler = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDepoGiris = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDepolar = new DevExpress.XtraBars.BarButtonItem();
            this.bbDepoCikis = new DevExpress.XtraBars.BarButtonItem();
            this.bbiStokHareket = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFirmalar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUrunRecetesi = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUretimEmirleri = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnTest = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTartimOperasyonlari = new DevExpress.XtraBars.BarButtonItem();
            this.rpTanimlar = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.bbiSirket,
            this.bbiDonem,
            this.bsiSirket,
            this.bsiDonem,
            this.bsiUser,
            this.bsiInfo,
            this.bbiStokKartlari,
            this.bbiStokGruplar,
            this.bbiBirimler,
            this.bbiDepoGiris,
            this.bbiDepolar,
            this.bbDepoCikis,
            this.bbiStokHareket,
            this.bbiFirmalar,
            this.bbiUrunRecetesi,
            this.bbiUretimEmirleri,
            this.bbiAyarlar,
            this.btnTest,
            this.bbiTartimOperasyonlari});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 20;
            this.ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpTanimlar,
            this.ribbonPage3,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(925, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiSirket
            // 
            this.bbiSirket.Caption = "Şirketler";
            this.bbiSirket.Id = 1;
            this.bbiSirket.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.factory;
            this.bbiSirket.Name = "bbiSirket";
            this.bbiSirket.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiSirket.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiSirket_ItemClick);
            // 
            // bbiDonem
            // 
            this.bbiDonem.Caption = "Dönemler";
            this.bbiDonem.Id = 2;
            this.bbiDonem.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.Appointment_32x32;
            this.bbiDonem.Name = "bbiDonem";
            this.bbiDonem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bbiDonem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiDonem_ItemClick);
            // 
            // bsiSirket
            // 
            this.bsiSirket.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiSirket.Caption = "Şirket";
            this.bsiSirket.Id = 3;
            this.bsiSirket.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.factory;
            this.bsiSirket.Name = "bsiSirket";
            this.bsiSirket.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bsiDonem
            // 
            this.bsiDonem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiDonem.Caption = "Dönem";
            this.bsiDonem.Id = 4;
            this.bsiDonem.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.Appointment_32x32;
            this.bsiDonem.Name = "bsiDonem";
            this.bsiDonem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bsiUser
            // 
            this.bsiUser.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiUser.Caption = "Kullanıcı";
            this.bsiUser.Id = 5;
            this.bsiUser.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.user_166;
            this.bsiUser.Name = "bsiUser";
            this.bsiUser.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bsiInfo
            // 
            this.bsiInfo.Caption = "İnfo";
            this.bsiInfo.Id = 6;
            this.bsiInfo.Name = "bsiInfo";
            // 
            // bbiStokKartlari
            // 
            this.bbiStokKartlari.Caption = "Stok Kartları";
            this.bbiStokKartlari.Id = 7;
            this.bbiStokKartlari.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.boxes;
            this.bbiStokKartlari.Name = "bbiStokKartlari";
            this.bbiStokKartlari.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiStokKartlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiStokKartlari_ItemClick);
            // 
            // bbiStokGruplar
            // 
            this.bbiStokGruplar.Caption = "Stok Grupları";
            this.bbiStokGruplar.Id = 8;
            this.bbiStokGruplar.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.Shipping8;
            this.bbiStokGruplar.Name = "bbiStokGruplar";
            this.bbiStokGruplar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiStokGruplar_ItemClick);
            // 
            // bbiBirimler
            // 
            this.bbiBirimler.Caption = "Stok Birimleri";
            this.bbiBirimler.Id = 9;
            this.bbiBirimler.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.inbox_full_mail_email_documents_3209324;
            this.bbiBirimler.Name = "bbiBirimler";
            this.bbiBirimler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiBirimler_ItemClick);
            // 
            // bbiDepoGiris
            // 
            this.bbiDepoGiris.Caption = "Depo Giriş Fişi";
            this.bbiDepoGiris.Id = 10;
            this.bbiDepoGiris.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.Yukleme;
            this.bbiDepoGiris.Name = "bbiDepoGiris";
            this.bbiDepoGiris.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiDepoGiris.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiStokGiris_ItemClick);
            // 
            // bbiDepolar
            // 
            this.bbiDepolar.Caption = "Depolar";
            this.bbiDepolar.Id = 11;
            this.bbiDepolar.ImageOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.Import;
            this.bbiDepolar.Name = "bbiDepolar";
            this.bbiDepolar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiDepolar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiDepolar_ItemClick);
            // 
            // bbDepoCikis
            // 
            this.bbDepoCikis.Caption = "Depo Çıkış Fişi";
            this.bbDepoCikis.Id = 12;
            this.bbDepoCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbDepoCikis.ImageOptions.Image")));
            this.bbDepoCikis.Name = "bbDepoCikis";
            this.bbDepoCikis.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbDepoCikis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbDepoCikis_ItemClick);
            // 
            // bbiStokHareket
            // 
            this.bbiStokHareket.Caption = "Stok Hareketleri";
            this.bbiStokHareket.Id = 13;
            this.bbiStokHareket.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiStokHareket.ImageOptions.Image")));
            this.bbiStokHareket.Name = "bbiStokHareket";
            this.bbiStokHareket.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiStokHareket.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiStokHareket_ItemClick);
            // 
            // bbiFirmalar
            // 
            this.bbiFirmalar.Caption = "Firmalar";
            this.bbiFirmalar.Id = 14;
            this.bbiFirmalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiFirmalar.ImageOptions.Image")));
            this.bbiFirmalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiFirmalar.ImageOptions.LargeImage")));
            this.bbiFirmalar.Name = "bbiFirmalar";
            this.bbiFirmalar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.bbiFirmalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiFirmalar_ItemClick);
            // 
            // bbiUrunRecetesi
            // 
            this.bbiUrunRecetesi.Caption = "Ürün Reçeteleri";
            this.bbiUrunRecetesi.Id = 15;
            this.bbiUrunRecetesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiUrunRecetesi.ImageOptions.Image")));
            this.bbiUrunRecetesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiUrunRecetesi.ImageOptions.LargeImage")));
            this.bbiUrunRecetesi.Name = "bbiUrunRecetesi";
            this.bbiUrunRecetesi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiUrunRecetesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUrunRecetesi_ItemClick);
            // 
            // bbiUretimEmirleri
            // 
            this.bbiUretimEmirleri.Caption = "Üretim Emirleri";
            this.bbiUretimEmirleri.Id = 16;
            this.bbiUretimEmirleri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiUretimEmirleri.ImageOptions.SvgImage")));
            this.bbiUretimEmirleri.Name = "bbiUretimEmirleri";
            this.bbiUretimEmirleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUretimEmirleri_ItemClick);
            // 
            // bbiAyarlar
            // 
            this.bbiAyarlar.Caption = "Ayarlar";
            this.bbiAyarlar.Id = 17;
            this.bbiAyarlar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiAyarlar.ImageOptions.SvgImage")));
            this.bbiAyarlar.Name = "bbiAyarlar";
            this.bbiAyarlar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiAyarlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAyarlar_ItemClick);
            // 
            // btnTest
            // 
            this.btnTest.Caption = "test";
            this.btnTest.Id = 18;
            this.btnTest.Name = "btnTest";
            this.btnTest.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTest_ItemClick);
            // 
            // bbiTartimOperasyonlari
            // 
            this.bbiTartimOperasyonlari.Caption = "Tartım İşlemleri";
            this.bbiTartimOperasyonlari.Id = 19;
            this.bbiTartimOperasyonlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiTartimOperasyonlari.ImageOptions.Image")));
            this.bbiTartimOperasyonlari.Name = "bbiTartimOperasyonlari";
            this.bbiTartimOperasyonlari.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiTartimOperasyonlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTartimOperasyonlari_ItemClick);
            // 
            // rpTanimlar
            // 
            this.rpTanimlar.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5});
            this.rpTanimlar.Name = "rpTanimlar";
            this.rpTanimlar.Text = "Tanımlar";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSirket);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDonem);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDepolar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiStokKartlari);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiUrunRecetesi);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiStokGruplar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiBirimler);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiFirmalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTest);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tanımlar";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.bbiAyarlar);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Ayarlar";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Tartı";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiUretimEmirleri);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiTartimOperasyonlari);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Üretim";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Depo";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiStokHareket);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiDepoGiris);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbDepoCikis);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Depo Hareketler";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiSirket);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiDonem);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiUser);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiInfo);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 474);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(925, 24);
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // dockManager1
            // 
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // FrmMainRibbon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 498);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.accounting__1_;
            this.IsMdiContainer = true;
            this.Name = "FrmMainRibbon";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "FrmMainRibbon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainRibbon_FormClosing);
            this.Load += new System.EventHandler(this.FrmMainRibbon_Load);
            this.MdiChildActivate += new System.EventHandler(this.FrmMainRibbon_MdiChildActivate);
            this.Shown += new System.EventHandler(this.FrmMainRibbon_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbiSirket;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiDonem;
        private DevExpress.XtraBars.BarStaticItem bsiSirket;
        private DevExpress.XtraBars.BarStaticItem bsiDonem;
        private DevExpress.XtraBars.BarStaticItem bsiUser;
        private DevExpress.XtraBars.BarStaticItem bsiInfo;
        private DevExpress.XtraBars.BarButtonItem bbiStokKartlari;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem bbiStokGruplar;
        private DevExpress.XtraBars.BarButtonItem bbiBirimler;
        private DevExpress.XtraBars.BarButtonItem bbiDepoGiris;
        private DevExpress.XtraBars.BarButtonItem bbiDepolar;
        private DevExpress.XtraBars.BarButtonItem bbDepoCikis;
        private DevExpress.XtraBars.BarButtonItem bbiStokHareket;
        private DevExpress.XtraBars.BarButtonItem bbiFirmalar;
        private DevExpress.XtraBars.BarButtonItem bbiUrunRecetesi;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bbiUretimEmirleri;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpTanimlar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem bbiAyarlar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnTest;
        private DevExpress.XtraBars.BarButtonItem bbiTartimOperasyonlari;
    }
}