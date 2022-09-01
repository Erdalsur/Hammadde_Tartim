using Sanmark.Erp.Entities.Concrete.Uretim;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class UretimEmirleriMap : EntityTypeConfiguration<UretimEmirleri>
    {
        public UretimEmirleriMap()
        {
            ToTable(@"UretimEmirleri", @"dbo");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(s => s.MakinaId).IsOptional();
            Property(s => s.Miktar).HasPrecision(12, 6);
        }
    }
}
