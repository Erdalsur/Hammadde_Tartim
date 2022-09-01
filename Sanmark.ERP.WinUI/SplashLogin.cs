using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace Sanmark.ERP.WinUI
{
    public partial class SplashLogin : SplashScreen
    {
        const string STR_SUR = " Developer by Erdal SUR";
        public SplashLogin()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 2020 - " + DateTime.Now.Year.ToString()+STR_SUR;
            //önemli resim gösterme süresi
            timer.Interval = 4000;
            //onemliResimSayisi = 3;
            timer.Enabled = true;

            List<int> img = new List<int>();
            for (int i = 0; i < images.Images.Count; i++)
                img.Add(i);

            var shuffled = img.OrderBy(a => Guid.NewGuid());

            foreach (var i in shuffled)
                slider.Images.Add((Image)images.Images[i]);

            //foreach (var image in images.Images)
            //    slider.Images.Add((Image)image);

            slider.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch;

            slider.MouseDown += new MouseEventHandler(Form_MouseDown);
            slider.MouseUp += new MouseEventHandler(Form_MouseUp);
            slider.MouseMove += new MouseEventHandler(Form_MouseMove);
        }
        public bool Draggable
        {
            set
            {
                this.draggable = value;
            }
            get
            {
                return this.draggable;
            }
        }

        void Form_MouseDown(object sender, MouseEventArgs e)
        {
            //
            //On Mouse Down set the flag drag=true and 
            //Store the clicked point to the start_point variable
            //
            this.drag = true;
            this.start_point = new Point(e.X, e.Y);
        }

        void Form_MouseUp(object sender, MouseEventArgs e)
        {
            //
            //Set the drag flag = false;
            //
            this.drag = false;
        }

        void Form_MouseMove(object sender, MouseEventArgs e)
        {
            //
            //If drag = true, drag the form
            //
            if (this.drag)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.start_point.X,
                                     p2.Y - this.start_point.Y);
                this.Location = p3;
            }
        }

        private bool drag = false;
        private Point start_point = new Point(0, 0);
        private bool draggable = true;

        int imageIndex = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            imageIndex++;
            //if (imageIndex == onemliResimSayisi)
            //{
            //önemsiz resim gösterme süresi
            //timer.Interval = 1500;
            //}
            slider.SlideNext();
        }

        private void slider_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}