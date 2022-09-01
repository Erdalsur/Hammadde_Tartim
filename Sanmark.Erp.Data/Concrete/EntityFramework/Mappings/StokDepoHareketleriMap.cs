using Sanmark.Erp.Entities.Concrete.Depolar;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class StokDepoHareketleriMap : EntityTypeConfiguration<StokDepoHareket>
    {
        /// <summary>
        /// Stok Depo Hareketleri Birim Tablosu Maping
        /// </summary>
        public StokDepoHareketleriMap()
        {
            ToTable(@"DepoHareketleri", @"dbo");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            HasMany(s => s.DepoHareketSatirlaris);
            Property(s => s.SirketId).HasColumnName("SirketId");
            Property(s => s.DonemId).HasColumnName("DonemId");
            Property(s => s.DepoId).HasColumnName("DepoId");
            Property(s => s.FirmaId).HasColumnName("FirmaId");
            Property(s => s.FisNo).HasColumnName("FisNo");
            Property(s => s.Tarih).HasColumnName("Tarih");
            Property(s => s.Aciklama).HasColumnName("Aciklama");
            Property(s => s.HareketTuru).HasColumnName("HareketTuru");
            Property(s => s.HammaddeDurumu).HasColumnName("HammaddeDurumu");
            Property(s => s.KaliteKontrolNo).HasColumnName("KaliteKontrolNo");
            Property(s => s.KayitTarihi).HasColumnName("KayitTarihi");
            Property(s => s.DegistirmeTarihi).HasColumnName("DegistirmeTarihi");
            Property(s => s.KayitUserId).HasColumnName("KayitUserId");
            Property(s => s.DegistirmeUserId).HasColumnName("DegistirmeUserId");

        }
    }
    public class StokDepoHareketSatirlariMap:EntityTypeConfiguration<DepoHareketSatirlari>
    {
        public StokDepoHareketSatirlariMap()
        {
            ToTable(@"DepoHareketSatirlari", @"dbo");
            HasKey(s => s.Id);
            HasRequired(s => s.StokDepoHareket);
            

        }
    }
}
