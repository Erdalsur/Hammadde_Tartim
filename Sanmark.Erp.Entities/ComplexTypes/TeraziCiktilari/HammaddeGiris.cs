using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanmark.Erp.Entities.ComplexTypes.TeraziCiktilari
{
    public class HammaddeGiris
    {
        public virtual int Id { get; set; }
        public virtual int DepoHareketId { get; set; }
        public virtual int DepoHareketSatirlariId { get; set; }
        public virtual DateTime Tarihi { get; set; }
        public virtual string UrunAdi { get; set; }
        public virtual string LotNo { get; set; }
        public virtual DateTime UretimTarihi { get; set; }
        public virtual DateTime SonTuketimTarihi { get; set; }
        public virtual string AmbalajSekli { get; set; }
        public virtual decimal Brut { get; set; }
        public virtual decimal Dara { get; set; }
        public virtual decimal Net { get; set; }
        public virtual string Birim { get; set; }        
    }
    public class HammaddeCikis
    {
        public virtual int Id { get; set; }
        public virtual int DepoHareketId { get; set; }
        public virtual int DepoHareketSatirlariId { get; set; }
        public virtual DateTime Tarihi { get; set; }
        public virtual string UrunAdi { get; set; } 
        public virtual string UrunSeriNo { get; set; }
        public virtual string HammaddeAdi { get; set; }
        public virtual string HammaddeLotNo { get; set; }
        public virtual string HammaddeKaliteNo { get; set; }
        public virtual string KontrolEden { get; set; }
        public virtual decimal Brut { get; set; }
        public virtual decimal Dara { get; set; }
        public virtual decimal Net { get; set; }
        public virtual string Birim { get; set; }
    }
}
