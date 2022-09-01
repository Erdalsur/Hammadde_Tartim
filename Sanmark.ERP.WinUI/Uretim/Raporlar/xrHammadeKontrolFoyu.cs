using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Sanmark.Core.Utilities.Win.Infrastructure;

namespace Sanmark.ERP.WinUI.Uretim.Raporlar
{
    public partial class xrHammadeKontrolFoyu : DevExpress.XtraReports.UI.XtraReport
    {
        
        public xrHammadeKontrolFoyu()
        {
            InitializeComponent();
        }

        private void xrHammadeKontrolFoyu_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrpicLogo.ImageUrl = SettingsTool.AyarOku(SettingsTool.Ayarlar.Genel_LogoYolu);
        }
    }
}
