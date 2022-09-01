using Sanmark.Erp.Entities.Concrete.Uretim;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class IsEmriMap : EntityTypeConfiguration<IsEmri>
    {
        public IsEmriMap()
        {
            ToTable(@"IsEmirleri", @"dbo");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(s => s.IsEmriKodu).HasMaxLength(25);
            Property(s => s.Aciklama).HasMaxLength(200);
            Property(s => s.PartiNo).HasMaxLength(100);
            Property(s => s.BaglantiAdres).HasMaxLength(25);
            Property(s => s.Miktar).HasPrecision(12, 6);
            Property(s => s.Carpan).HasPrecision(12, 6);
            Property(s => s.Id).HasColumnName("Id");
            Property(s => s.DonemId).HasColumnName("DonemId");
            Property(s => s.IsEmriKodu).HasColumnName("IsEmriKodu");
            Property(s => s.IsEmriTipi).HasColumnName("IsEmriTipi");
            Property(s => s.GenelDurumu).HasColumnName("GenelDurumu");
            Property(s => s.Aciklama).HasColumnName("Aciklama");
            Property(s => s.PartiNo).HasColumnName("PartiNo");
            Property(s => s.StokKartiId).HasColumnName("StokKartiId");
            Property(s => s.Miktar).HasColumnName("Miktar");
            Property(s => s.BirimId).HasColumnName("BirimId");
            Property(s => s.MakinaId).HasColumnName("MakinaId");
            Property(s => s.Carpan).HasColumnName("Carpan");
            Property(s => s.BaglantiAdres).HasColumnName("BaglantiAdres");
            Property(s => s.BaglantiId).HasColumnName("BaglantiId");
            Property(s => s.PlanlananBaslangicTarihi).HasColumnName("PlanlananBaslangicTarihi");
            Property(s => s.PlananBitisTarihi).HasColumnName("PlananBitisTarihi");
            Property(s => s.KapanisTarihi).HasColumnName("KapanisTarihi");
            Property(s => s.KayitTarihi).HasColumnName("KayitTarihi");
            Property(s => s.DegistirmeTarihi).HasColumnName("DegistirmeTarihi");
            Property(s => s.KayitUserId).HasColumnName("KayitUserId");
            Property(s => s.DegistirmeUserId).HasColumnName("DegistirmeUserId");
            Property(s => s.BaslamaTarihi).HasColumnName("BaslamaTarihi");


        }
    }
    public class IsEmriOperasyonMap:EntityTypeConfiguration<IsEmriOperasyon>
    {
        public IsEmriOperasyonMap()
        {
            ToTable(@"IsEmirOperasyonlari", @"dbo");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            //Property(s => s.LotNo).HasMaxLength(mz);
            Property(s => s.Miktar).HasPrecision(12, 6);
            Property(s => s.ReelMiktar).HasPrecision(12, 6);
            Property(s => s.Carpan).HasPrecision(12, 6);
            Property(s => s.FireMiktari).HasPrecision(12, 6);

            Property(s => s.Id).HasColumnName("Id");
            Property(s => s.DonemId).HasColumnName("DonemId");
            Property(s => s.IsEmriId).HasColumnName("IsEmriId");
            Property(s => s.StokKartiId).HasColumnName("StokKartiId");
            Property(s => s.Miktar).HasColumnName("Miktar");
            Property(s => s.ReelMiktar).HasColumnName("ReelMiktar");
            Property(s => s.BirimId).HasColumnName("BirimId");
            Property(s => s.Carpan).HasColumnName("Carpan");
            Property(s => s.LotNo).HasColumnName("LotNo");
            Property(s => s.ReferansNo).HasColumnName("ReferansNo");
            Property(s => s.GenelDurum).HasColumnName("GenelDurum");
            Property(s => s.IslemBaslamaTarihi).HasColumnName("IslemBaslamaTarihi");
            Property(s => s.IslemBitisTarihi).HasColumnName("IslemBitisTarihi");
            Property(s => s.SonKullanimTarihi).HasColumnName("SonKullanimTarihi");
            Property(s => s.FireMiktari).HasColumnName("FireMiktari");
            Property(s => s.MakinaId).HasColumnName("MakinaId");
            Property(s => s.KayitTarihi).HasColumnName("KayitTarihi");
            Property(s => s.DegistirmeTarihi).HasColumnName("DegistirmeTarihi");
            Property(s => s.KayitUserId).HasColumnName("KayitUserId");
            Property(s => s.DegistirmeUserId).HasColumnName("DegistirmeUserId");
        }
    }
    public class IsEmriOperasyonIslemMap:EntityTypeConfiguration<IsEmriOperasyonIslem>
    {
        public IsEmriOperasyonIslemMap()
        {
            ToTable(@"IsEmirOperasyonIslemleri", @"dbo");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(s => s.TartimLotNo).HasMaxLength(25);
            Property(s => s.TartimReferansNo).HasMaxLength(25);
            Property(s => s.TartimTartan).HasMaxLength(25);
            Property(s => s.TartimKontrolEden).HasMaxLength(25);
            Property(s => s.TartimBirim).HasMaxLength(25);
            Property(s => s.TartimBrut).HasPrecision(12, 6);
            Property(s => s.TartimDara).HasPrecision(12, 6);
            Property(s => s.TartimMiktar).HasPrecision(12, 6);

            Property(s => s.Id).HasColumnName("Id");
            Property(s => s.DonemId).HasColumnName("DonemId");
            Property(s => s.TartimLotNo).HasColumnName("TartimLotNo");
            Property(s => s.TartimReferansNo).HasColumnName("TartimReferansNo");
            Property(s => s.TartimTartan).HasColumnName("TartimTartan");
            Property(s => s.TartimKontrolEden).HasColumnName("TartimKontrolEden");
            Property(s => s.TartimTarihi).HasColumnName("TartimTarihi");
            Property(s => s.TartimMiktar).HasColumnName("TartimMiktar");
            Property(s => s.TartimDara).HasColumnName("TartimDara");
            Property(s => s.TartimBrut).HasColumnName("TartimBrut");
            Property(s => s.TartimBirim).HasColumnName("TartimBirim");
            Property(s => s.TartimUrunId).HasColumnName("TartimUrunId");
            Property(s => s.SonKullanimTarihi).HasColumnName("SonKullanimTarihi");
            Property(s => s.KayitTarihi).HasColumnName("KayitTarihi");
            Property(s => s.DegistirmeTarihi).HasColumnName("DegistirmeTarihi");
            Property(s => s.KayitUserId).HasColumnName("KayitUserId");
            Property(s => s.DegistirmeUserId).HasColumnName("DegistirmeUserId");

        }
    }
}
