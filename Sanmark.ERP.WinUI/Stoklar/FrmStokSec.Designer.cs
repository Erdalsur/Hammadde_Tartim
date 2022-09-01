namespace Sanmark.ERP.WinUI.Stoklar
{
    partial class FrmStokSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokSec));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbCokluSecim = new DevExpress.XtraEditors.LabelControl();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSirketId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokGrupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokBirimId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMevcutMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmbalajId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegistirmeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegistirmeUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbCokluSecim);
            this.groupControl1.Controls.Add(this.btnSec);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 378);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(800, 72);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Menu";
            // 
            // lbCokluSecim
            // 
            this.lbCokluSecim.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCokluSecim.Appearance.Options.UseFont = true;
            this.lbCokluSecim.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbCokluSecim.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbCokluSecim.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCokluSecim.ImageOptions.ImageIndex = 2;
            this.lbCokluSecim.ImageOptions.Images = this.ımageList1;
            this.lbCokluSecim.Location = new System.Drawing.Point(5, 28);
            this.lbCokluSecim.Name = "lbCokluSecim";
            this.lbCokluSecim.Size = new System.Drawing.Size(556, 36);
            this.lbCokluSecim.TabIndex = 2;
            this.lbCokluSecim.Text = "Çoklu seçim yapabilmek için CTRL tuşuna basık tutarak seçiminizi yapınız";
            this.lbCokluSecim.Visible = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "check.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            this.ımageList1.Images.SetKeyName(2, "information.png");
            // 
            // btnSec
            // 
            this.btnSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSec.ImageOptions.ImageIndex = 0;
            this.btnSec.ImageOptions.ImageList = this.ımageList1;
            this.btnSec.Location = new System.Drawing.Point(639, 27);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(75, 40);
            this.btnSec.TabIndex = 1;
            this.btnSec.Text = "Seç";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(720, 27);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 40);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcData);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 378);
            this.panelControl1.TabIndex = 1;
            // 
            // gcData
            // 
            this.gcData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcData.Location = new System.Drawing.Point(2, 2);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(796, 374);
            this.gcData.TabIndex = 0;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSirketId,
            this.colStokGrupId,
            this.colStokBirimId,
            this.colTip,
            this.colKod,
            this.colAd,
            this.colMevcutMiktar,
            this.colBarkod,
            this.colAmbalajId,
            this.colKayitTarihi,
            this.colDegistirmeTarihi,
            this.colKayitUserId,
            this.colDegistirmeUserId});
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsView.ShowAutoFilterRow = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colSirketId
            // 
            this.colSirketId.FieldName = "SirketId";
            this.colSirketId.Name = "colSirketId";
            this.colSirketId.OptionsColumn.AllowEdit = false;
            // 
            // colStokGrupId
            // 
            this.colStokGrupId.FieldName = "StokGrupId";
            this.colStokGrupId.Name = "colStokGrupId";
            this.colStokGrupId.OptionsColumn.AllowEdit = false;
            this.colStokGrupId.Visible = true;
            this.colStokGrupId.VisibleIndex = 0;
            this.colStokGrupId.Width = 110;
            // 
            // colStokBirimId
            // 
            this.colStokBirimId.FieldName = "StokBirimId";
            this.colStokBirimId.Name = "colStokBirimId";
            this.colStokBirimId.OptionsColumn.AllowEdit = false;
            this.colStokBirimId.Visible = true;
            this.colStokBirimId.VisibleIndex = 5;
            this.colStokBirimId.Width = 55;
            // 
            // colTip
            // 
            this.colTip.FieldName = "Tip";
            this.colTip.Name = "colTip";
            this.colTip.OptionsColumn.AllowEdit = false;
            this.colTip.Visible = true;
            this.colTip.VisibleIndex = 1;
            this.colTip.Width = 110;
            // 
            // colKod
            // 
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 2;
            this.colKod.Width = 110;
            // 
            // colAd
            // 
            this.colAd.FieldName = "Ad";
            this.colAd.Name = "colAd";
            this.colAd.OptionsColumn.AllowEdit = false;
            this.colAd.Visible = true;
            this.colAd.VisibleIndex = 3;
            this.colAd.Width = 186;
            // 
            // colMevcutMiktar
            // 
            this.colMevcutMiktar.FieldName = "MevcutMiktar";
            this.colMevcutMiktar.Name = "colMevcutMiktar";
            this.colMevcutMiktar.OptionsColumn.AllowEdit = false;
            this.colMevcutMiktar.Visible = true;
            this.colMevcutMiktar.VisibleIndex = 4;
            this.colMevcutMiktar.Width = 84;
            // 
            // colBarkod
            // 
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 6;
            this.colBarkod.Width = 116;
            // 
            // colAmbalajId
            // 
            this.colAmbalajId.FieldName = "AmbalajId";
            this.colAmbalajId.Name = "colAmbalajId";
            this.colAmbalajId.OptionsColumn.AllowEdit = false;
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
            // FrmStokSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmStokSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Seç";
            this.Load += new System.EventHandler(this.FrmStokSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSirketId;
        private DevExpress.XtraGrid.Columns.GridColumn colStokGrupId;
        private DevExpress.XtraGrid.Columns.GridColumn colStokBirimId;
        private DevExpress.XtraGrid.Columns.GridColumn colTip;
        private DevExpress.XtraGrid.Columns.GridColumn colKod;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colMevcutMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colAmbalajId;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colDegistirmeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colDegistirmeUserId;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.LabelControl lbCokluSecim;
    }
}