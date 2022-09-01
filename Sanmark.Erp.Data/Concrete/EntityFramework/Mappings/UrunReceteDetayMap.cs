using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class UrunReceteDetayMap : EntityTypeConfiguration<UrunReceteDetay>
    {
        public UrunReceteDetayMap()
        {
            ToTable(@"UrunReceteDetaylar", @"dbo");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(s => s.Miktar).HasPrecision(12, 6);
            Property(s => s.Not).HasMaxLength(100);
            HasRequired(s => s.UrunRecete).WithMany(s => s.UrunReceteDetay).HasForeignKey(s => s.UrunReceteId);
            Property(s => s.Id).HasColumnName("Id");
            Property(s => s.UrunReceteId).HasColumnName("UrunReceteId");
            Property(s => s.AnaStokKartiId).HasColumnName("AnaStokKartiId");
            Property(s => s.StokBirimId).HasColumnName("StokBirimId");
            Property(s => s.Miktar).HasColumnName("Miktar");
            Property(s => s.StokBirimId).HasColumnName("StokBirimId");
            Property(s => s.FireOrani).HasColumnName("FireOrani");
            Property(s => s.DepoId).HasColumnName("DepoId");
            Property(s => s.Not).HasColumnName("Not");
            Property(s => s.KayitTarihi).HasColumnName("KayitTarihi");
            Property(s => s.DegistirmeTarihi).HasColumnName("DegistirmeTarihi");
            Property(s => s.KayitUserId).HasColumnName("KayitUserId");
            Property(s => s.DegistirmeUserId).HasColumnName("DegistirmeUserId");
        }
    }
}
