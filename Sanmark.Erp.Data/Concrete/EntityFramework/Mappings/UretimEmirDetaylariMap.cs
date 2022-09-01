using Sanmark.Erp.Entities.Concrete.Uretim;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class UretimEmirDetaylariMap : EntityTypeConfiguration<UretimEmirDetaylari>
    {
        public UretimEmirDetaylariMap()
        {
            ToTable(@"UretimEmirDetaylari", @"dbo");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(s => s.Miktar).HasPrecision(12, 6);
            Property(s => s.ReelMiktar).HasPrecision(12, 6);
            Property(s => s.FireMiktari).HasPrecision(12, 6);
            this.HasRequired(s => s.UretimEmir).WithMany(s => s.UretimEmirDetaylari).HasForeignKey(c => c.UretimEmirId);
        }
    }
}
