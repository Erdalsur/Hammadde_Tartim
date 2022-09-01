using Sanmark.Core.Entities;
using System;
using System.Linq;

namespace Sanmark.Erp.Entities.Concrete.Stok
{
    public partial class UrunAgacSatirlari : IEntity
    {
        public int Id { get; set; }
        public int UrunAgacId { get; set; }
        public int UrunId { get; set; }
        public int BirimId { get; set; }
        public decimal Miktar { get; set; }
        public virtual StokKarti Urun { get; set; }
        public virtual UrunAgaclari UrunAgac { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? DegistirmeTarihi { get ; set ; }
        public int? KayitUserId { get ; set; }
        public int? DegistirmeUserId { get ; set ; }
    }
}
