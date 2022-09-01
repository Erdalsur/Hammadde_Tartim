using Sanmark.Erp.Entities.Concrete;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework.Mappings
{
    public class DonemMap : EntityTypeConfiguration<Donem>
    {
        /// <summary>
        /// Dönemler Tablosu Maping
        /// </summary>
        public DonemMap()
        {
            ToTable(@"Donemler", @"dbo");
            HasKey(x => x.Id);
            Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//Otomatik Artım
            Property(x => x.SirketId).HasColumnName("SirketId");
            Property(x => x.Yil).HasColumnName("Yil");
            Property(x => x.Baslangic).HasColumnName("Baslangic");
            Property(x => x.Bitis).HasColumnName("Bitis");
            Property(x => x.OncekiYilId).HasColumnName("OncekiYilId");
        }


    }
}
