using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class StokBirimMap : EntityTypeConfiguration<StokBirim>
    {
        /// <summary>
        /// Stok Birim Tablosu Maping
        /// </summary>
        public StokBirimMap()
        {
            ToTable(@"StokBirimler", @"dbo");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(s => s.SirketId).HasColumnName("SirketId");
            Property(s => s.Kod).HasColumnName("Kod");
            Property(s => s.Ad).HasColumnName("Ad");
        }
    }
}
