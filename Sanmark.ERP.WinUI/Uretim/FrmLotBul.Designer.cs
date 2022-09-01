namespace Sanmark.ERP.WinUI.Uretim
{
    partial class FrmLotBul
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
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSirketId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLotNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUretimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiris_Miktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCikis_Miktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKartBirimId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.colKalan = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcData
            // 
            this.gcData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcData.Location = new System.Drawing.Point(0, 0);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(1126, 459);
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
            this.colStokId,
            this.colBirim,
            this.colLotNo,
            this.colTarih,
            this.colSKT,
            this.colUretimTarihi,
            this.colGiris_Miktar,
            this.colCikis_Miktar,
            this.colStokKartBirimId,
            this.colKalan});
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKalan, DevExpress.Data.ColumnSortOrder.Descending)});
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
            // colDonemId
            // 
            this.colDonemId.FieldName = "DonemId";
            this.colDonemId.Name = "colDonemId";
            this.colDonemId.OptionsColumn.AllowEdit = false;
            // 
            // colStokId
            // 
            this.colStokId.FieldName = "StokId";
            this.colStokId.Name = "colStokId";
            this.colStokId.OptionsColumn.AllowEdit = false;
            this.colStokId.Visible = true;
            this.colStokId.VisibleIndex = 0;
            this.colStokId.Width = 294;
            // 
            // colBirim
            // 
            this.colBirim.FieldName = "Birim";
            this.colBirim.Name = "colBirim";
            this.colBirim.OptionsColumn.AllowEdit = false;
            // 
            // colLotNo
            // 
            this.colLotNo.FieldName = "LotNo";
            this.colLotNo.Name = "colLotNo";
            this.colLotNo.OptionsColumn.AllowEdit = false;
            this.colLotNo.Visible = true;
            this.colLotNo.VisibleIndex = 1;
            this.colLotNo.Width = 205;
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 2;
            // 
            // colSKT
            // 
            this.colSKT.DisplayFormat.FormatString = "d";
            this.colSKT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSKT.FieldName = "SKT";
            this.colSKT.Name = "colSKT";
            this.colSKT.OptionsColumn.AllowEdit = false;
            this.colSKT.Visible = true;
            this.colSKT.VisibleIndex = 3;
            // 
            // colUretimTarihi
            // 
            this.colUretimTarihi.FieldName = "UretimTarihi";
            this.colUretimTarihi.Name = "colUretimTarihi";
            this.colUretimTarihi.OptionsColumn.AllowEdit = false;
            this.colUretimTarihi.Visible = true;
            this.colUretimTarihi.VisibleIndex = 4;
            // 
            // colGiris_Miktar
            // 
            this.colGiris_Miktar.FieldName = "Giris_Miktar";
            this.colGiris_Miktar.Name = "colGiris_Miktar";
            this.colGiris_Miktar.OptionsColumn.AllowEdit = false;
            this.colGiris_Miktar.Visible = true;
            this.colGiris_Miktar.VisibleIndex = 5;
            // 
            // colCikis_Miktar
            // 
            this.colCikis_Miktar.FieldName = "Cikis_Miktar";
            this.colCikis_Miktar.Name = "colCikis_Miktar";
            this.colCikis_Miktar.OptionsColumn.AllowEdit = false;
            this.colCikis_Miktar.Visible = true;
            this.colCikis_Miktar.VisibleIndex = 6;
            // 
            // colStokKartBirimId
            // 
            this.colStokKartBirimId.FieldName = "StokKartBirimId";
            this.colStokKartBirimId.Name = "colStokKartBirimId";
            this.colStokKartBirimId.OptionsColumn.AllowEdit = false;
            this.colStokKartBirimId.Visible = true;
            this.colStokKartBirimId.VisibleIndex = 8;
            this.colStokKartBirimId.Width = 103;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSec);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 459);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1126, 72);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Menu";
            // 
            // btnSec
            // 
            this.btnSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSec.ImageOptions.ImageIndex = 0;
            this.btnSec.Location = new System.Drawing.Point(965, 27);
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
            this.btnKapat.Location = new System.Drawing.Point(1046, 27);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 40);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // colKalan
            // 
            this.colKalan.Caption = "Kalan Stok";
            this.colKalan.FieldName = "colKalan";
            this.colKalan.Name = "colKalan";
            this.colKalan.UnboundExpression = "[Giris_Miktar] - [Cikis_Miktar]";
            this.colKalan.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colKalan.Visible = true;
            this.colKalan.VisibleIndex = 7;
            // 
            // FrmLotBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 531);
            this.Controls.Add(this.gcData);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmLotBul";
            this.Text = "Lot Numarası Bul";
            this.Load += new System.EventHandler(this.FrmLotBul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSirketId;
        private DevExpress.XtraGrid.Columns.GridColumn colDonemId;
        private DevExpress.XtraGrid.Columns.GridColumn colStokId;
        private DevExpress.XtraGrid.Columns.GridColumn colBirim;
        private DevExpress.XtraGrid.Columns.GridColumn colLotNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSKT;
        private DevExpress.XtraGrid.Columns.GridColumn colUretimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colGiris_Miktar;
        private DevExpress.XtraGrid.Columns.GridColumn colCikis_Miktar;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKartBirimId;
        private DevExpress.XtraGrid.Columns.GridColumn colKalan;
    }
}