using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class AmbalajMap : EntityTypeConfiguration<Ambalaj>
    {
        /// <summary>
        /// Stok Kartı Tablosu Maping
        /// </summary>
        public AmbalajMap()
        {
            ToTable(@"Paketler", @"dbo");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(s => s.SirketId).HasColumnName("SirketId");
            Property(s => s.Ad).HasColumnName("Ad");
        }
    }
}
