using Sanmark.Core.Entities;
using System;
using System.Linq;

namespace Sanmark.Erp.Entities.Concrete.Stok
{
    public class UrunReceteDetay : IEntity
    {
        public int Id { get; set; }
        public int UrunReceteId { get; set; }
        public int AnaStokKartiId { get; set; }
        public int StokKartiId { get; set; }
        public decimal Miktar { get; set; }
        public int StokBirimId { get; set; }
        public int FireOrani { get; set; }
        public int DepoId { get; set; }
        public string Not { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? DegistirmeTarihi { get; set; }
        public int? KayitUserId { get; set; }
        public int? DegistirmeUserId { get; set; }
        public virtual UrunRecete UrunRecete { get; set; }
        public virtual StokKarti StokKarti { get; set; }
        public virtual StokBirim StokBirim { get; set; }
        public virtual Depo Depo { get; set; }

    }
}
