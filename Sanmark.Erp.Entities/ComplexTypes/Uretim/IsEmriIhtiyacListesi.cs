using System;
using System.Linq;

namespace Sanmark.Erp.Entities.ComplexTypes.Uretim
{
    public class IsEmriIhtiyacListesi
    {
        public int Id { get; set; }
        public string StokKodu { get; set; }
        public string StokAd { get; set; }
        public decimal StokMiktari { get; set; }
        public int StokBirimi { get; set; }
        public decimal StokReceteIhtiyaci { get; set; }
        public int StokReceteBirimi { get; set; }
        public decimal Ihtiyac { get; set; }
        public int StokId { get; set; }
    }
}
