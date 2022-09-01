using Sanmark.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sanmark.Erp.Entities.Concrete.Stok
{
    public partial class UrunAgaclari : IEntity
    {
        public UrunAgaclari()
        {
            UrunAgacSatirlari = new HashSet<UrunAgacSatirlari>();
        }

        public int Id { get; set; }
        public int SirketId { get; set; }
        public int StokId { get; set; }
        public int BirimId { get; set; }
        public string Kod { get; set; }
        public string Aciklama { get; set; }
        public int RevizyonNo { get; set; }
        public DateTime? RevizyonTarihi { get; set; }
        public decimal? Carpan { get; set; }
        public int MakinaId { get; set; }
        public virtual Sirket Sirket { get; set; }
        public virtual StokKarti Stok { get; set; }
        public virtual ICollection<UrunAgacSatirlari> UrunAgacSatirlari { get; set; }
        public DateTime? KayitTarihi { get ; set ; }
        public DateTime? DegistirmeTarihi { get ; set ; }
        public int? KayitUserId { get ; set ; }
        public int? DegistirmeUserId { get ; set ; }
    }
}
