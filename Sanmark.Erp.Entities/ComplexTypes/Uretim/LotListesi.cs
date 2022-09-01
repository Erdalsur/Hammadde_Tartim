using System;
using System.Linq;

namespace Sanmark.Erp.Entities.ComplexTypes.Uretim
{
    public class LotListesi
    {
        public int Id { get; set; }
        public int SirketId { get; set; }
        public int DonemId { get; set; }
        public int StokId { get; set; }
        public int Birim { get; set; }
        public string LotNo { get; set; }

        public DateTime? Tarih { get; set; }
        DateTime? sKT;
        public DateTime? SKT
{ get => sKT; set
            {
                if (Convert.ToDateTime("01.01.0001") == value)
                {
                    value=null;
                }

                sKT = value;
            }
        }
        DateTime? uretimTarihi;
        public DateTime? UretimTarihi
{ get => uretimTarihi; set
            {
                if (Convert.ToDateTime("01.01.0001") == value)
                {
                    value = null;
                }

                uretimTarihi = value;
            }
        }
        public decimal Giris_Miktar { get; set; }
        public decimal Cikis_Miktar { get; set; }
        public int StokKartBirimId { get; set; }
    }
}
