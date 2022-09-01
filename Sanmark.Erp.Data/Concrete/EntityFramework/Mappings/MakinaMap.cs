using Sanmark.Erp.Entities.Concrete.Uretim;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class MakinaMap : EntityTypeConfiguration<Makina>
    {
        public MakinaMap()
        {
            ToTable(@"Makinalar", @"dbo");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            //Property(s => s.MakinaId).IsOptional();
            Property(s => s.IsTartim).HasColumnName("IsTartim");
    }
    }
}
