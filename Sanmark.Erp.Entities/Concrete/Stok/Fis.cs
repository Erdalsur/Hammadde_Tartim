using Sanmark.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanmark.Erp.Entities.Concrete.Stok
{
    public class Fis:IEntity
    {
        public Fis()
        {
            StokHareket= new HashSet<StokHareket>();
        }
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string FisTuru { get; set; }
        public int? CariId { get; set; }
        public string BelgeNo { get; set; }
        public DateTime Tarih { get; set; }
        public int? PlasiyerId { get; set; }
        public string TeslimEden { get; set; }
        public decimal IskontoOrani { get; set; }
        public decimal IskontoTutar { get; set; }
        public decimal ToplamTutar { get; set; }
        public string Aciklama { get; set; }
        public DateTime? KayitTarihi { get; set ; }
        public DateTime? DegistirmeTarihi { get; set ; }
        public int? KayitUserId { get ; set; }
        public int? DegistirmeUserId { get ; set ; }
        public int SirketId { get; set; }
        public int DonemId { get; set; }

        public virtual ICollection<StokHareket> StokHareket { get; set; }
    }
}
