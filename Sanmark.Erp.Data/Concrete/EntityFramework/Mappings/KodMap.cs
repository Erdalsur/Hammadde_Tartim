using Sanmark.Erp.Entities.Concrete;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class KodMap : EntityTypeConfiguration<Kod>
    {
        public KodMap()
        {
            ToTable(@"Kodlar", @"dbo");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(s => s.OnEki).HasMaxLength(6);
            Property(s => s.Tablo).HasMaxLength(15);

            Property(s => s.Id).HasColumnName("Id");
            Property(s => s.Tablo).HasColumnName("Tablo");
            Property(s => s.OnEki).HasColumnName("OnEki");
            Property(s => s.SonDeger).HasColumnName("SonDeger");
            Property(s => s.Uzunlugu).HasColumnName("Uzunlugu");
        }
    }
}
