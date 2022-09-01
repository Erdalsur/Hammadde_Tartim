namespace Sanmark.ERP.WinUI.Uretim
{
    partial class FrmIsEmri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIsEmri));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.bbiIhtiyacListesi = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnKod = new DevExpress.XtraEditors.DropDownButton();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txtMiktar = new DevExpress.XtraEditors.TextEdit();
            this.dateBitisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateBaslamaTarihi = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.label7 = new System.Windows.Forms.Label();
            this.gleBirim = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtStokKod = new DevExpress.XtraEditors.ButtonEdit();
            this.txtStokAd = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPartiNo = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKod = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslamaTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslamaTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleBirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartiNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
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
            this.bbiIhtiyacListesi});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiIhtiyacListesi)});
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
            // bbiIhtiyacListesi
            // 
            this.bbiIhtiyacListesi.Caption = "İhtiyaç Listesi";
            this.bbiIhtiyacListesi.Id = 1;
            this.bbiIhtiyacListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiIhtiyacListesi.ImageOptions.Image")));
            this.bbiIhtiyacListesi.Name = "bbiIhtiyacListesi";
            this.bbiIhtiyacListesi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiIhtiyacListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiIhtiyacListesi_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(445, 56);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 363);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(445, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 56);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 307);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(445, 56);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 307);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnKod);
            this.panelControl1.Controls.Add(this.txtAciklama);
            this.panelControl1.Controls.Add(this.txtMiktar);
            this.panelControl1.Controls.Add(this.dateBitisTarihi);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.dateBaslamaTarihi);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.gleBirim);
            this.panelControl1.Controls.Add(this.txtStokKod);
            this.panelControl1.Controls.Add(this.txtStokAd);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.txtPartiNo);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtKod);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 56);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(445, 307);
            this.panelControl1.TabIndex = 4;
            // 
            // btnKod
            // 
            this.btnKod.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.btnKod.Location = new System.Drawing.Point(366, 15);
            this.btnKod.MenuManager = this.barManager1;
            this.btnKod.Name = "btnKod";
            this.btnKod.Size = new System.Drawing.Size(38, 23);
            this.btnKod.TabIndex = 62;
            this.btnKod.Text = "Kod";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(132, 45);
            this.txtAciklama.MenuManager = this.barManager1;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(234, 67);
            this.txtAciklama.TabIndex = 1;
            // 
            // txtMiktar
            // 
            this.txtMiktar.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMiktar.Location = new System.Drawing.Point(132, 196);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMiktar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtMiktar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMiktar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMiktar.Properties.Mask.EditMask = "n6";
            this.txtMiktar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMiktar.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtMiktar.Size = new System.Drawing.Size(234, 20);
            this.txtMiktar.TabIndex = 5;
            // 
            // dateBitisTarihi
            // 
            this.dateBitisTarihi.EditValue = null;
            this.dateBitisTarihi.Location = new System.Drawing.Point(132, 274);
            this.dateBitisTarihi.Name = "dateBitisTarihi";
            this.dateBitisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBitisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBitisTarihi.Size = new System.Drawing.Size(234, 20);
            this.dateBitisTarihi.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 277);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 13);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Planlama Bitis Tarihi";
            // 
            // dateBaslamaTarihi
            // 
            this.dateBaslamaTarihi.EditValue = null;
            this.dateBaslamaTarihi.Location = new System.Drawing.Point(132, 248);
            this.dateBaslamaTarihi.MenuManager = this.barManager1;
            this.dateBaslamaTarihi.Name = "dateBaslamaTarihi";
            this.dateBaslamaTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBaslamaTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBaslamaTarihi.Size = new System.Drawing.Size(234, 20);
            this.dateBaslamaTarihi.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 251);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(113, 13);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Planlama Başlama Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Birimi";
            // 
            // gleBirim
            // 
            this.gleBirim.Location = new System.Drawing.Point(132, 222);
            this.gleBirim.Name = "gleBirim";
            this.gleBirim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleBirim.Properties.PopupView = this.gridView2;
            this.gleBirim.Size = new System.Drawing.Size(234, 20);
            this.gleBirim.TabIndex = 6;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // txtStokKod
            // 
            this.txtStokKod.Location = new System.Drawing.Point(132, 144);
            this.txtStokKod.MenuManager = this.barManager1;
            this.txtStokKod.Name = "txtStokKod";
            this.txtStokKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtStokKod.Size = new System.Drawing.Size(234, 20);
            this.txtStokKod.TabIndex = 3;
            this.txtStokKod.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtStokKod_ButtonClick);
            this.txtStokKod.Validated += new System.EventHandler(this.txtStokKod_Validated);
            // 
            // txtStokAd
            // 
            this.txtStokAd.Location = new System.Drawing.Point(132, 170);
            this.txtStokAd.Name = "txtStokAd";
            this.txtStokAd.Properties.AllowFocused = false;
            this.txtStokAd.Properties.ReadOnly = true;
            this.txtStokAd.Size = new System.Drawing.Size(234, 20);
            this.txtStokAd.TabIndex = 4;
            this.txtStokAd.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Stok Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Stok Kodu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Miktar";
            // 
            // txtPartiNo
            // 
            this.txtPartiNo.Location = new System.Drawing.Point(132, 118);
            this.txtPartiNo.Name = "txtPartiNo";
            this.txtPartiNo.Size = new System.Drawing.Size(234, 20);
            this.txtPartiNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Parti No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Açıklama";
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(132, 17);
            this.txtKod.MenuManager = this.barManager1;
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(234, 20);
            this.txtKod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İş Emri Kodu";
            // 
            // FrmIsEmri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 363);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmIsEmri";
            this.Text = "İş Emri";
            this.Load += new System.EventHandler(this.FrmIsEmri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslamaTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslamaTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleBirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartiNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtPartiNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtKod;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ButtonEdit txtStokKod;
        private DevExpress.XtraEditors.TextEdit txtStokAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.GridLookUpEdit gleBirim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.DateEdit dateBitisTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateBaslamaTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtMiktar;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.DropDownButton btnKod;
        private DevExpress.XtraBars.BarButtonItem bbiIhtiyacListesi;
    }
}