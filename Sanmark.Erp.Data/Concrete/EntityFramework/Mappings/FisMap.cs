using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class FisMap : EntityTypeConfiguration<Fis>
    {
        public FisMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(12);
            this.Property(p => p.FisTuru).HasMaxLength(12);
            this.Property(p => p.BelgeNo).HasMaxLength(20);
            this.Property(p => p.IskontoOrani).HasPrecision(5, 2);
            this.Property(p => p.IskontoTutar).HasPrecision(12, 6);
            this.Property(p => p.ToplamTutar).HasPrecision(12, 6);
            this.Property(p => p.Aciklama).HasMaxLength(200);
            Property(s => s.TeslimEden).HasMaxLength(50);

            this.ToTable(@"Fisler", @"dbo");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.FisTuru).HasColumnName("FisTuru");
            this.Property(p => p.CariId).HasColumnName("CariId");
            this.Property(p => p.BelgeNo).HasColumnName("BelgeNo");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.PlasiyerId).HasColumnName("PlasiyerId");
            this.Property(p => p.IskontoOrani).HasColumnName("IskontoOrani");
            this.Property(p => p.IskontoTutar).HasColumnName("IskontoTutar");
            this.Property(p => p.ToplamTutar).HasColumnName("ToplamTutar");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
            Property(s => s.KayitTarihi).HasColumnName("KayitTarihi");
            Property(s => s.DegistirmeTarihi).HasColumnName("DegistirmeTarihi");
            Property(s => s.KayitUserId).HasColumnName("KayitUserId");
            Property(s => s.DegistirmeUserId).HasColumnName("DegistirmeUserId");
            Property(s => s.TeslimEden).HasColumnName("TeslimEden");
            Property(s => s.DonemId).HasColumnName("DonemId");
            Property(s => s.SirketId).HasColumnName("SirketId");

        }
    }
}
