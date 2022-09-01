using System;
using System.Linq;

namespace Sanmark.Erp.Entities.ComplexTypes.Uretim
{
    public class StokHareketListe
    {
        public virtual int Id { get; set; }
        public virtual int SirketId { get; set; }
        public virtual int DonemId { get; set; }
        public virtual int DepoId { get; set; }
        public virtual int StokId { get; set; }
        public virtual Int16 StokTipi { get; set; }
        public virtual string FisNo { get; set; }
        public virtual DateTime? Tarih { get; set; }
        public virtual string GirisCikis { get; set; }
        public virtual string HareketTuru { get; set; }
        public virtual string KaliteKontrolNo { get; set; }
        public virtual int BaglantiId { get; set; }
        public virtual int BaglantiSatirId { get; set; }
        public virtual DateTime? KayitTarihi { get; set; }
        public virtual DateTime? DegistirmeTarihi { get; set; }
        public virtual int? KayitUserId { get; set; }
        public virtual int? DegistirmeUserId { get; set; }
        public string StokAdi { get; set; }
        public double StokGirisMiktari { get; set; }
        public double StokCikisMiktari { get; set; }
        public int StokBirimi { get; set; }
        public double StokBakiyesi { get; set; }        
        public int StokAnaBirimi { get; set; }
        public int FisId { get; set; }
        public string LotNo { get; set; }
        public string AnalizDurumu { get; set; }
        public int AnalizSertifikasiGeldimi { get; set; }
        public DateTime? SKT { get; set; }
    }
}
