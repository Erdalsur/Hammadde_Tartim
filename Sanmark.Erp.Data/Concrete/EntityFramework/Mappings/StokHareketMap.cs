using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class StokHareketMap : EntityTypeConfiguration<StokHareket>
    {
        /// <summary>
        /// Stok Hareket Tablosu Maping
        /// </summary>
        public StokHareketMap()
        {
            ToTable(@"StokHareketleri", @"dbo");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(s => s.SirketId).HasColumnName("SirketId");
            Property(s => s.DonemId).HasColumnName("DonemId");
            Property(s => s.DepoId).HasColumnName("DepoId");
            Property(s => s.StokId).HasColumnName("StokId");
            Property(s => s.FisNo).HasColumnName("FisNo");
            Property(s => s.Tarih).HasColumnName("Tarih");
            Property(s => s.GirisCikisMiktar).HasColumnName("GirisCikisMiktar");
            Property(s => s.GirisCikisMiktar2).HasColumnName("GirisCikisMiktar2");
            Property(s => s.GirisCikis).HasColumnName("GirisCikis");
            Property(s => s.HareketTuru).HasColumnName("HareketTuru");
            Property(s => s.KaliteKontrolNo).HasColumnName("KaliteKontrolNo");
            Property(s => s.BaglantiId).HasColumnName("BaglantiId");
            Property(s => s.BaglantiSatirId).HasColumnName("BaglantiSatirId");
            Property(s => s.KayitTarihi).HasColumnName("KayitTarihi");
            Property(s => s.DegistirmeTarihi).HasColumnName("DegistirmeTarihi");
            Property(s => s.KayitUserId).HasColumnName("KayitUserId");
            Property(s => s.DegistirmeUserId).HasColumnName("DegistirmeUserId");
            this.HasRequired(s => s.Fis).WithMany(s => s.StokHareket).HasForeignKey(c => c.FisId);
            Property(s => s.LotNo).HasColumnName("LotNo");
            Property(s => s.UretimTarihi).HasColumnName("UretimTarihi");
            Property(s => s.SKT).HasColumnName("SKT");
            Property(s => s.PaketlemeTuru).HasColumnName("PaketlemeTuru");
            Property(s => s.PaketlemeSayisi).HasColumnName("PaketlemeSayisi");
            Property(s => s.AnalizSertifikasiGeldimi).HasColumnName("AnalizSertifikasiGeldimi");
            Property(s => s.AnalizDurumu).HasColumnName("AnalizDurumu");
            Property(s => s.Aciklama).HasColumnName("Aciklama");
            Property(s=>s.AnalizSertifikasiGeldimi).HasColumnAnnotation("DefaultValue", 0);
            Property(s => s.BirimId).HasColumnName("BirimId");
        }
    }
}
