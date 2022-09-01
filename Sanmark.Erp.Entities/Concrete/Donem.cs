using Sanmark.Core.Entities;
using System;
using System.Linq;

namespace Sanmark.Erp.Entities.Concrete
{
    public class Donem : IEntity
    {
        public virtual int Id { get; set; }
        public virtual int SirketId { get; set; }
        public virtual Int16 Yil { get; set; }
        public virtual DateTime Baslangic { get; set; }
        public virtual DateTime Bitis { get; set; }
        public virtual Int16 OncekiYilId { get; set; }
        public DateTime? KayitTarihi { get ; set; }
        public DateTime? DegistirmeTarihi { get; set ; }
        public int? KayitUserId { get ; set ; }
        public int? DegistirmeUserId { get ; set ; }
    }
}
