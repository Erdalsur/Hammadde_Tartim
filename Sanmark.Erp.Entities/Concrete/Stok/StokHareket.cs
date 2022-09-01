using Sanmark.Core.Entities;
using System;
using System.Linq;

namespace Sanmark.Erp.Entities.Concrete.Stok
{
    public class StokHareket : IEntity
    {
        public virtual int Id { get; set; }
        public virtual int SirketId { get; set; }
        public virtual int DonemId { get; set; }
        public virtual int DepoId { get; set; }
        public virtual int StokId { get; set; }
        public virtual int FisId { get; set; }
        public virtual string FisNo { get; set; }
        public virtual DateTime? Tarih { get; set; }
        public virtual double GirisCikisMiktar { get; set; }
        public virtual double GirisCikisMiktar2 { get; set; }
        public virtual string GirisCikis { get; set; }
        public virtual string HareketTuru { get; set; }
        public virtual string KaliteKontrolNo { get; set; }
        public virtual int BaglantiId { get; set; }
        public virtual int BaglantiSatirId { get; set; }
        public virtual DateTime? KayitTarihi { get; set; }
        public virtual DateTime? DegistirmeTarihi { get; set; }
        public virtual int? KayitUserId { get; set; }
        public virtual int? DegistirmeUserId { get; set; }
        public virtual Fis Fis { get; set; }
        public virtual string LotNo { get; set; }
        public virtual DateTime? UretimTarihi { get; set; }
        public virtual DateTime? SKT { get; set; }
        public virtual string PaketlemeTuru { get; set; }
        public virtual int? PaketlemeSayisi { get; set; }
        public virtual int AnalizSertifikasiGeldimi { get; set; }
        public virtual string AnalizDurumu { get; set; }
        public virtual string Aciklama { get; set; }
        public virtual int BirimId { get; set; }


    }
}
