using Sanmark.Core.Entities;
using Sanmark.Erp.Entities.Concrete.Uretim;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sanmark.Erp.Entities.Concrete.Stok
{
    public class UrunRecete : IEntity
    {
        public UrunRecete()
        {
            UrunReceteDetay = new HashSet<UrunReceteDetay>();
        }
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public int SirketId { get; set; }
        public string ReceteKodu { get; set; }
        public int StokId { get; set; }
        public int DepoId { get; set; }
        public decimal Miktar { get; set; }
        public int BirimId { get; set; }
        public decimal BirimPay { get; set; }
        public decimal BirimPayda { get; set; }
        public string Aciklama { get; set; }
        public int RevizyonNo { get; set; }
        public DateTime? RevizyonTarihi { get; set; }
        public decimal? Carpan { get; set; }
        public int MakinaId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? DegistirmeTarihi { get; set; }
        public int? KayitUserId { get; set; }
        public int? DegistirmeUserId { get; set; }
        public virtual Sirket Sirket { get; set; }
        public virtual StokKarti Stok { get; set; }
        public virtual Depo Depo { get; set; }
        public virtual StokBirim StokBirim { get; set; }
        public virtual Makina Makina { get; set; }
        public virtual ICollection<UrunReceteDetay> UrunReceteDetay { get; set; }

    }
}
