using Sanmark.Erp.Entities.Concrete;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class DepoMap : EntityTypeConfiguration<Depo>
    {
        /// <summary>
        /// Stok Birim Tablosu Maping
        /// </summary>
        public DepoMap()
        {
            ToTable(@"Depolar", @"dbo");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(s => s.SirketId).HasColumnName("SirketId");
            Property(s => s.Kod).HasColumnName("Kod");
            Property(s => s.Ad).HasColumnName("Ad");
        }
    }
}
