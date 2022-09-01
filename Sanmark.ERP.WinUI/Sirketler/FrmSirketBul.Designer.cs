namespace Sanmark.ERP.WinUI.Sirketler
{
    partial class FrmSirketBul
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcSirketler = new DevExpress.XtraGrid.GridControl();
            this.gvSirketler = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSirketler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSirketler)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcSirketler);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(395, 393);
            this.panelControl1.TabIndex = 0;
            // 
            // gcSirketler
            // 
            this.gcSirketler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSirketler.Location = new System.Drawing.Point(2, 2);
            this.gcSirketler.MainView = this.gvSirketler;
            this.gcSirketler.Name = "gcSirketler";
            this.gcSirketler.Size = new System.Drawing.Size(391, 389);
            this.gcSirketler.TabIndex = 1;
            this.gcSirketler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSirketler});
            // 
            // gvSirketler
            // 
            this.gvSirketler.GridControl = this.gcSirketler;
            this.gvSirketler.Name = "gvSirketler";
            this.gvSirketler.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GvSirketler_RowClick);
            this.gvSirketler.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GvSirketler_FocusedRowChanged);
            // 
            // FrmSirketBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 393);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Image = global::Sanmark.ERP.WinUI.Properties.Resources.search_24;
            this.Name = "FrmSirketBul";
            this.Text = "Şirket Bul";
            this.Load += new System.EventHandler(this.FrmSirketBul_Load);
            this.Shown += new System.EventHandler(this.FrmSirketBul_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSirketler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSirketler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcSirketler;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSirketler;
    }
}