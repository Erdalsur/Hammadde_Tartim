using Sanmark.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanmark.Erp.Entities.Concrete
{
    public class Kod:IEntity

    {
        public int Id { get; set; }
        public int SirketId { get; set; }
        public int DonemId { get; set; }
        public string Tablo { get; set; }
        public string OnEki { get; set; }
        public int SonDeger { get; set; }
        public int Uzunlugu { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? DegistirmeTarihi { get; set; }
        public int? KayitUserId { get; set; }
        public int? DegistirmeUserId { get; set; }

        public virtual Sirket Sirket { get; set; }
        public virtual Donem Donem { get; set; }
    }
}
