using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class StokKartiMap : EntityTypeConfiguration<StokKarti>
    {
        /// <summary>
        /// Stok Kartı Tablosu Maping
        /// </summary>
        public StokKartiMap()
        {
            ToTable(@"StokKartlar", @"dbo");
            HasKey(s => s.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(p => p.Birim2Pay).HasPrecision(12, 6);
            Property(p => p.Birim2Payda).HasPrecision(12, 6);
            Property(p => p.Birim3Pay).HasPrecision(12, 6);
            Property(p => p.Birim3Payda).HasPrecision(12, 6);
            Property(p => p.MevcutMiktar).HasPrecision(12, 6);
            Property(s => s.SirketId).HasColumnName("SirketId");
            Property(s => s.StokGrupId).HasColumnName("StokGrupId");
            Property(s => s.StokBirimId).HasColumnName("StokBirimId");
            Property(s => s.Tip).HasColumnName("Tip");
            Property(s => s.Kod).HasColumnName("Kod");
            Property(s => s.Ad).HasColumnName("Ad");
            Property(s => s.MevcutMiktar).HasColumnName("MevcutMiktar");
            Property(s => s.Barkod).HasColumnName("Barkod");
            Property(s => s.AmbalajId).HasColumnName("AmbalajId");
            Property(s => s.Birim2Id).HasColumnName("Birim2Id");
            Property(s => s.Birim2Pay).HasColumnName("Birim2Pay");
            Property(s => s.Birim2Payda).HasColumnName("Birim2Payda");
            Property(s => s.Birim3Id).HasColumnName("Birim3Id");
            Property(s => s.Birim3Pay).HasColumnName("Birim3Pay");
            Property(s => s.Birim3Payda).HasColumnName("Birim3Payda");


        }
    }
}
