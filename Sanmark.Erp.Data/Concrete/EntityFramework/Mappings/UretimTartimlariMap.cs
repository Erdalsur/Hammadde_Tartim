using Sanmark.Erp.Entities.Concrete.Uretim;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class UretimTartimlariMap : EntityTypeConfiguration<UretimTartimlari>
    {
        public UretimTartimlariMap()
        {
            ToTable(@"UretimTartimlari", @"dbo");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(s => s.Miktar).HasPrecision(12,6);//.HasColumnType("decimal(18,6)");
            this.HasRequired(s => s.UretimEmirDetay).WithMany(s => s.UretimTartimlari).HasForeignKey(c => c.UretimEmirDetayId);

        }
    }
}
