using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Entities.Concrete.Uretim;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class UrunAgacSatirlariMap : EntityTypeConfiguration<UrunAgacSatirlari>
    {
        public UrunAgacSatirlariMap()
        {
            ToTable(@"UrunAgacSatirlari", @"dbo");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(s => s.Miktar).HasPrecision(12, 6);

        }
    }
}
