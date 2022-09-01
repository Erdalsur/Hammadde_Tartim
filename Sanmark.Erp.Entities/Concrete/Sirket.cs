using Sanmark.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanmark.Erp.Entities.Concrete
{
    public class Sirket : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Kod { get; set; }
        public virtual string Ad { get; set; }
        public virtual string Email { get; set; }
        public DateTime? KayitTarihi { get ; set ; }
        public DateTime? DegistirmeTarihi { get; set; }
        public int? KayitUserId { get ; set ; }
        public int? DegistirmeUserId { get ; set ; }
    }
}
