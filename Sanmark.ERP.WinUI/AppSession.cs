using Sanmark.Erp.Entities.Concrete;
using Sanmark.ERP.WinUI.BaseForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanmark.ERP.WinUI
{
    public class AppSession
    {
        public static FrmMainRibbon MainForm {get;set;}
        public static string Version { get; set; }
        public static DataSession DataSession { get; set; }
        public static XForm XForm;
        public static Sirket Sirket { get; set; }
        public static Donem Donem { get; set; }
        public static User CurrentUser { get; set; }
        public static int WhoAmI { get { return CurrentUser.Id; } }
        public static string ServerAddress { get; set; }
        public static string SkinName { get; set; }
        public static string ApplicationName { get; internal set; }
        public static string Kilogram { get; set;}
        public static string Gram { get; set; }
        public static string Ton { get; set; }
        
    }
}
