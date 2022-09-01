using Sanmark.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sanmark.Erp.Entities.Concrete.Uretim
{
    public partial class Makina:IEntity
    {
        public Makina()
        {
            UretimEmirleri = new HashSet<UretimEmirleri>();
        }

        public int Id { get; set; }
        public int SirketId { get; set; }
        public int DonemId { get; set; }
        public string MakinaAdi { get; set; }
        public bool IsTartim { get; set; }
        public virtual Donem Donem { get; set; }
        public virtual Sirket Sirket { get; set; }
        public virtual ICollection<UretimEmirleri> UretimEmirleri { get; set; }
        public DateTime? KayitTarihi { get ; set ; }
        public DateTime? DegistirmeTarihi { get ; set ; }
        public int? KayitUserId { get ; set ; }
        public int? DegistirmeUserId { get ; set ; }
    }
}
