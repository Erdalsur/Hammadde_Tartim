using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanmark.Erp.Entities.Concrete.Stok;

namespace Sanmark.Erp.Entities.ComplexTypes.Uretim
{
    public class HammaddeKontrolFoyu
    {
        public int Id { get; set; }
        public string StokKodu { get; set; }
        public string HammaddeAdi { get; set; }
        //[Column("TeorikMiktar", TypeName = "decimal(12,6)")]
        public decimal TeorikMiktar { get; set; }
        public decimal ReelMiktar { get; set; }
        public string Birim { get; set;}
        public string LotNo { get; set; }
        public string RefNo { get; set; }
        public string Tartan { get; set; }
        public string KontrolEden { get; set; }
        public DateTime? Tarih { get; set; }
        public decimal Fark { get; set; }
        public StokKarti Stok { get; set; }
        public int BirimId { get; set; }
    }
}
