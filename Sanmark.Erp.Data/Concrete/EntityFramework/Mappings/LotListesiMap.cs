using Sanmark.Erp.Entities.ComplexTypes.Uretim;
using System;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class LotListesiMap : EntityTypeConfiguration<LotListesi>
    {
        public LotListesiMap()
        {
            
            ToTable(@"LotNumbers", @"dbo");
            this.HasKey(t => t.Id);
        }
    }
}
