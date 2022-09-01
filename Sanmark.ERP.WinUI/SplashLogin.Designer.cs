namespace Sanmark.ERP.WinUI
{
    partial class SplashLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashLogin));
            this.labelCopyright = new DevExpress.XtraEditors.LabelControl();
            this.images = new DevExpress.Utils.ImageCollection(this.components);
            this.progressBar = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.slider = new DevExpress.XtraEditors.Controls.ImageSlider();
            ((System.ComponentModel.ISupportInitialize)(this.images)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCopyright
            // 
            this.labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelCopyright.Location = new System.Drawing.Point(1, 306);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(47, 13);
            this.labelCopyright.TabIndex = 6;
            this.labelCopyright.Text = "Copyright";
            // 
            // images
            // 
            this.images.ImageSize = new System.Drawing.Size(300, 300);
            this.images.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("images.ImageStream")));
            this.images.Images.SetKeyName(0, "1.jpg");
            this.images.Images.SetKeyName(1, "2.jpg");
            this.images.Images.SetKeyName(2, "3.jpg");
            this.images.Images.SetKeyName(3, "4.jpg");
            this.images.Images.SetKeyName(4, "5.jpg");
            this.images.Images.SetKeyName(5, "6.jpg");
            this.images.Images.SetKeyName(6, "7.jpg");
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.EditValue = 0;
            this.progressBar.Location = new System.Drawing.Point(1, 292);
            this.progressBar.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            this.progressBar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.progressBar.Size = new System.Drawing.Size(448, 14);
            this.progressBar.TabIndex = 11;
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            // 
            // slider
            // 
            this.slider.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slider.Location = new System.Drawing.Point(1, 1);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(448, 305);
            this.slider.TabIndex = 12;
            // 
            // SplashLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.labelCopyright);
            this.Name = "SplashLogin";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "SplashLogin";
            ((System.ComponentModel.ISupportInitialize)(this.images)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelCopyright;
        private DevExpress.Utils.ImageCollection images;
        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBar;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraEditors.Controls.ImageSlider slider;
    }
}
