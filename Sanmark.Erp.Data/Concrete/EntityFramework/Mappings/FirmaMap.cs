using Sanmark.Erp.Entities.Concrete.Cari;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class FirmaMap : EntityTypeConfiguration<Firma>
    {
        /// <summary>
        /// Firmalar Tablosu Maping
        /// </summary>
        public FirmaMap()
        {
            ToTable(@"Firmalar", @"dbo");
            HasKey(x => x.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(s => s.SirketId).HasColumnName("SirketId");
            Property(x => x.Kod).HasColumnName("Kod");
            Property(x => x.FirmaTip).HasColumnName("FirmaTip");
            Property(x => x.FirmaKartTip).HasColumnName("FirmaKartTip");
            Property(x => x.Ad).HasColumnName("Ad");
            Property(x => x.Soyad).HasColumnName("Soyad");
            Property(x => x.VergiDairesi).HasColumnName("VergiDairesi");
            Property(x => x.VergiNo).HasColumnName("VergiNo");
            Property(s => s.KayitTarihi).HasColumnName("KayitTarihi");
            Property(s => s.DegistirmeTarihi).HasColumnName("DegistirmeTarihi");
            Property(s => s.KayitUserId).HasColumnName("KayitUserId");
            Property(s => s.DegistirmeUserId).HasColumnName("DegistirmeUserId");
        }


    }
}
