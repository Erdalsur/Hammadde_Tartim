using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Entities.Concrete.Uretim;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class UrunAgaclariMap : EntityTypeConfiguration<UrunAgaclari>
    {
        public UrunAgaclariMap()
        {
            ToTable(@"UrunAgaclari", @"dbo");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(s => s.SirketId).IsOptional();
            Property(s => s.Carpan).HasPrecision(12, 6);
            //HasOptional(s => s.Sirket).(s => s.Id).HasForeignKey(s => s.SirketId).WillCascadeOnDelete(true);
        }
    }
}
