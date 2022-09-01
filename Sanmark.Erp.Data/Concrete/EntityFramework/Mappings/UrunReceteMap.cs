using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class UrunReceteMap : EntityTypeConfiguration<UrunRecete>
    {
        public UrunReceteMap()
        {
            ToTable(@"UrunReceteleri", @"dbo");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(s => s.ReceteKodu).HasMaxLength(25);
            Property(s => s.Miktar).HasPrecision(12, 6);
            Property(s => s.BirimPay).HasPrecision(12, 6);
            Property(s => s.BirimPayda).HasPrecision(12, 6);
            Property(s => s.Aciklama).HasMaxLength(100);
            Property(s => s.Carpan).HasPrecision(12, 6);

            Property(s => s.Id).HasColumnName("Id");
            Property(s => s.IsActive).HasColumnName("IsActive");
            Property(s => s.SirketId).HasColumnName("SirketId");
            Property(s => s.ReceteKodu).HasColumnName("ReceteKodu");
            Property(s => s.StokId).HasColumnName("StokId");
            Property(s => s.DepoId).HasColumnName("DepoId");
            Property(s => s.Miktar).HasColumnName("Miktar");
            Property(s => s.BirimId).HasColumnName("BirimId");
            Property(s => s.BirimPay).HasColumnName("BirimPay");
            Property(s => s.BirimPayda).HasColumnName("BirimPayda");
            Property(s => s.Aciklama).HasColumnName("Aciklama");
            Property(s => s.RevizyonNo).HasColumnName("RevizyonNo");
            Property(s => s.RevizyonTarihi).HasColumnName("RevizyonTarihi");
            Property(s => s.Carpan).HasColumnName("Carpan");
            Property(s => s.MakinaId).HasColumnName("MakinaId");
            Property(s => s.KayitTarihi).HasColumnName("KayitTarihi");
            Property(s => s.DegistirmeTarihi).HasColumnName("DegistirmeTarihi");
            Property(s => s.KayitUserId).HasColumnName("KayitUserId");
            Property(s => s.DegistirmeUserId).HasColumnName("DegistirmeUserId");
        }
    }
}
