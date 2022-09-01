using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class StokGrupMap : EntityTypeConfiguration<StokGrup>
    {
        /// <summary>
        /// Stok Grup Tablosu Maping
        /// </summary>
        public StokGrupMap()
        {
            ToTable(@"StokGruplar", @"dbo");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(s => s.SirketId).HasColumnName("SirketId");
            Property(s => s.ParentId).HasColumnName("ParentId");
            Property(s => s.Ad).HasColumnName("Ad");
            Property(s => s.Aciklama).HasColumnName("Aciklama");
        }
    }
}
