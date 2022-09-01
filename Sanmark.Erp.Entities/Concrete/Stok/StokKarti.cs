using Sanmark.Core.Entities;
using System;
using System.Linq;

namespace Sanmark.Erp.Entities.Concrete.Stok
{
    public class StokKarti : IEntity
    {
        public virtual int Id { get; set; }
        public virtual int SirketId { get; set; }
        public virtual int StokGrupId { get; set; }
        public virtual int StokBirimId { get; set; }
        public virtual Int16 Tip { get; set; }
        public virtual string Kod { get; set; }
        public virtual string Ad { get; set; }
        public virtual decimal MevcutMiktar { get; set; }
        public virtual string Barkod { get; set; }
        public virtual int? AmbalajId { get; set; }
        public DateTime? KayitTarihi { get ; set ; }
        public DateTime? DegistirmeTarihi { get ; set ; }
        public int? KayitUserId { get ; set ; }
        public int? DegistirmeUserId { get ; set ; }
        public int Birim2Id { get; set; }
        public decimal Birim2Pay { get; set; }
        public decimal Birim2Payda { get; set; }
        public int Birim3Id { get; set; }
        public decimal Birim3Pay { get; set; }
        public decimal Birim3Payda { get; set; }


    }
}
