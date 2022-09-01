namespace Sanmark.ERP.WinUI.Uretim
{
    partial class FrmUretimEmir
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
            this.gcDetayListe = new DevExpress.XtraGrid.GridControl();
            this.gvDetayListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtAciklama = new DevExpress.XtraEditors.TextEdit();
            this.txtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gleMakina = new DevExpress.XtraEditors.GridLookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnlControl = new DevExpress.XtraEditors.PanelControl();
            this.dateBaslamaTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtMiktar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gleUrun = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetayListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetayListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleMakina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl)).BeginInit();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslamaTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslamaTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleUrun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDetayListe
            // 
            this.gcDetayListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDetayListe.Location = new System.Drawing.Point(2, 172);
            this.gcDetayListe.MainView = this.gvDetayListe;
            this.gcDetayListe.Name = "gcDetayListe";
            this.gcDetayListe.Size = new System.Drawing.Size(744, 0);
            this.gcDetayListe.TabIndex = 27;
            this.gcDetayListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetayListe});
            this.gcDetayListe.Visible = false;
            // 
            // gvDetayListe
            // 
            this.gvDetayListe.GridControl = this.gcDetayListe;
            this.gvDetayListe.Name = "gvDetayListe";
            // 
            // txtAciklama
            // 
            this.txtAciklama.EnterMoveNextControl = true;
            this.txtAciklama.Location = new System.Drawing.Point(83, 15);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(632, 20);
            this.txtAciklama.TabIndex = 6;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.EnterMoveNextControl = true;
            this.txtSeriNo.Location = new System.Drawing.Point(83, 95);
            this.txtSeriNo.MenuManager = this.barManager1;
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(310, 20);
            this.txtSeriNo.TabIndex = 9;
            this.txtSeriNo.EditValueChanged += new System.EventHandler(this.txtAd_EditValueChanged);
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
            this.barDockControlTop.Size = new System.Drawing.Size(748, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 213);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(748, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 173);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(748, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 173);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 98);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Parti No";
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gleMakina
            // 
            this.gleMakina.Location = new System.Drawing.Point(83, 43);
            this.gleMakina.Name = "gleMakina";
            this.gleMakina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleMakina.Properties.PopupView = this.gridView2;
            this.gleMakina.Size = new System.Drawing.Size(632, 20);
            this.gleMakina.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 46);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Makina";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Açıklama";
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.dateBaslamaTarihi);
            this.pnlControl.Controls.Add(this.txtMiktar);
            this.pnlControl.Controls.Add(this.labelControl6);
            this.pnlControl.Controls.Add(this.labelControl5);
            this.pnlControl.Controls.Add(this.gleUrun);
            this.pnlControl.Controls.Add(this.labelControl2);
            this.pnlControl.Controls.Add(this.gcDetayListe);
            this.pnlControl.Controls.Add(this.gleMakina);
            this.pnlControl.Controls.Add(this.txtAciklama);
            this.pnlControl.Controls.Add(this.txtSeriNo);
            this.pnlControl.Controls.Add(this.labelControl4);
            this.pnlControl.Controls.Add(this.labelControl3);
            this.pnlControl.Controls.Add(this.labelControl1);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(0, 40);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(748, 173);
            this.pnlControl.TabIndex = 0;
            // 
            // dateBaslamaTarihi
            // 
            this.dateBaslamaTarihi.EditValue = null;
            this.dateBaslamaTarihi.Location = new System.Drawing.Point(120, 150);
            this.dateBaslamaTarihi.MenuManager = this.barManager1;
            this.dateBaslamaTarihi.Name = "dateBaslamaTarihi";
            this.dateBaslamaTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBaslamaTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBaslamaTarihi.Size = new System.Drawing.Size(273, 20);
            this.dateBaslamaTarihi.TabIndex = 11;
            // 
            // txtMiktar
            // 
            this.txtMiktar.EnterMoveNextControl = true;
            this.txtMiktar.Location = new System.Drawing.Point(83, 121);
            this.txtMiktar.MenuManager = this.barManager1;
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMiktar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMiktar.Size = new System.Drawing.Size(310, 20);
            this.txtMiktar.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 153);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(102, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Üretim Başlama Tarihi";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 124);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Üretim Miktarı";
            // 
            // gleUrun
            // 
            this.gleUrun.Location = new System.Drawing.Point(83, 69);
            this.gleUrun.Name = "gleUrun";
            this.gleUrun.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleUrun.Properties.PopupView = this.gridView1;
            this.gleUrun.Size = new System.Drawing.Size(632, 20);
            this.gleUrun.TabIndex = 8;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ürün";
            // 
            // FrmUretimEmir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 213);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmUretimEmir";
            this.Text = "Üretim Emri";
            this.Load += new System.EventHandler(this.FrmUretimEmir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDetayListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetayListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleMakina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslamaTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslamaTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleUrun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDetayListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetayListe;
        private DevExpress.XtraEditors.TextEdit txtAciklama;
        private DevExpress.XtraEditors.TextEdit txtSeriNo;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiKaydet;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl pnlControl;
        private DevExpress.XtraEditors.TextEdit txtMiktar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GridLookUpEdit gleUrun;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit gleMakina;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateBaslamaTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}