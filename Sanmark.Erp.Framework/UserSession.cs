using Sanmark.Erp.Data.Concrete.EntityFramework;
using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Entities.Concrete.Uretim;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Sanmark.Erp.Data.Migrations;
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;


namespace Sanmark.Core.Utilities
{
    public class UserSession
    {
        public static User CurrentUser { get; set; }
        public static Donem Donem { get; set; }
        public static Sirket Sirket { get; set; }
    }
}
