using Sanmark.Core.Entities;
using System;
using System.Linq;

namespace Sanmark.Erp.Entities.Concrete
{
    public class Depo : IEntity
    {
        public int Id { get; set; }
        public int SirketId { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public DateTime? KayitTarihi { get ; set ; }
        public DateTime? DegistirmeTarihi { get ; set ; }
        public int? KayitUserId { get ; set ; }
        public int? DegistirmeUserId { get ; set ; }
    }
}
