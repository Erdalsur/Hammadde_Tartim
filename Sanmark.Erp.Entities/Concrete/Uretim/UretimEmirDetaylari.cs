using Sanmark.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sanmark.Erp.Entities.Concrete.Uretim
{
    public partial class UretimEmirDetaylari:IEntity
    {
        public UretimEmirDetaylari()
        {
            UretimTartimlari = new HashSet<UretimTartimlari>();
        }

        public int Id { get; set; }
        public int UretimEmirId { get; set; }
        public int UrunId { get; set; }
        public decimal Miktar { get; set; }
        decimal reelMiktar;
        public decimal ReelMiktar { get; set; }
        
        public string LotNo { get; set; }
        public string ReferansNo { get; set; }
        public DateTime? IslemBaslamaTarihi { get; set; }
        public DateTime? IslemBitisTarihi { get; set; }
        public int UretimDurumu { get; set; }
        public DateTime? SonKullanimTarihi { get; set; }
        public decimal FireMiktari { get; set; }


        public virtual UretimEmirleri UretimEmir { get; set; }
        public virtual ICollection<UretimTartimlari> UretimTartimlari { get; set; }
        public DateTime? KayitTarihi { get ; set ; }
        public DateTime? DegistirmeTarihi { get ; set ; }
        public int? KayitUserId { get; set ; }
        public int? DegistirmeUserId { get; set; }
    }
}
