using Sanmark.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Sanmark.Erp.Entities.Concrete.Uretim
{
    public partial class UretimTartimlari:IEntity
    {
        public int Id { get; set; }
        public int? UretimEmirDetayId { get; set; }
        public string LotNo { get; set; }
        public string ReferansNo { get; set; }
        public string Tartan { get; set; }
        public string KontrolEden { get; set; }
        public DateTime? TartimTarihi { get; set; }
        public DateTime? SKT { get; set; }
        
        public decimal Miktar { get; set; }
        public decimal Dara { get; set; }
        public decimal Brut { get; set; }
        public string Birim { get; set; }
        public int UrunId { get; set; }
        public virtual UretimEmirDetaylari UretimEmirDetay { get; set; }
        public DateTime? KayitTarihi { get ; set ; }
        public DateTime? DegistirmeTarihi { get ; set ; }
        public int? KayitUserId { get ; set; }
        public int? DegistirmeUserId { get ; set; }
    }
}
