using Sanmark.Core.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanmark.Erp.Entities.Concrete.Depolar
{
    public class StokDepoHareket : IEntity
    {
        public StokDepoHareket()
        {
            DepoHareketSatirlaris = new Collection<DepoHareketSatirlari>();
            
        }
        public virtual int Id { get; set; }
        public virtual int SirketId { get; set; }
        public virtual int DonemId { get; set; }
        public virtual int? DepoId { get; set; }
        public virtual int FirmaId { get; set; }
        public virtual string FisNo { get; set; }
        public virtual DateTime Tarih { get; set; }        
        public virtual string Aciklama { get; set; }
        public virtual string HareketTuru { get; set; }
        public virtual int HammaddeDurumu { get; set; }
        public virtual string KaliteKontrolNo { get; set; }
        public virtual DateTime? KayitTarihi { get; set; }
        public virtual DateTime? DegistirmeTarihi { get; set; }
        public virtual int? KayitUserId { get; set; }
        public virtual int? DegistirmeUserId { get; set; }
        
        public virtual ICollection<DepoHareketSatirlari> DepoHareketSatirlaris { get; set; }


    }
    public class DepoHareketSatirlari : IEntity
    {
        public virtual int Id { get; set; }
        public virtual int DepoHareketId { get; set; }
        public StokDepoHareket StokDepoHareket { get; set; }
        public virtual int AmbalajId { get; set; }
        public virtual int StokId { get; set; }
        public virtual string HareketTuru { get; set; }
        public virtual decimal Adet { get; set; }
        public virtual decimal Miktar { get; set; }
        public virtual decimal Toplam { get; set; }
        public virtual string LotNo { get; set; }
        public virtual DateTime UretimTarihi { get; set; }
        public virtual DateTime SonTuketimTarihi { get; set; }
        public virtual string KaliteKontrolNo { get; set; }
        public virtual DateTime? KayitTarihi { get; set; }
        public virtual DateTime? DegistirmeTarihi { get; set; }
        public virtual int? KayitUserId { get; set; }
        public virtual int? DegistirmeUserId { get; set; }

    }
}
