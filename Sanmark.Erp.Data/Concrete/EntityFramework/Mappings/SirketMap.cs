using Sanmark.Erp.Entities.Concrete;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class SirketMap : EntityTypeConfiguration<Sirket>
    {
        /// <summary>
        /// Sirketler Tablosu Maping
        /// </summary>
        public SirketMap()
        {
            ToTable(@"Sirketler", @"dbo");
            HasKey(x => x.Id);
            Property(x => x.Kod).HasMaxLength(12);
            Property(x => x.Ad).HasMaxLength(50);
            Property(x => x.Email).HasMaxLength(50);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(x => x.Ad).HasColumnName("Ad");
            Property(x => x.Email).HasColumnName("Email");
            Property(x => x.Kod).HasColumnName("Kod");
        }


    }
}
