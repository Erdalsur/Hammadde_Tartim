using Sanmark.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanmark.Erp.Entities.Concrete.Stok
{
    public class Ambalaj : IEntity
    {
        public virtual int Id { get; set; }
        public virtual int SirketId { get; set; }
        public virtual string Ad { get; set; }
        public DateTime? KayitTarihi { get ; set ; }
        public DateTime? DegistirmeTarihi { get ; set ; }
        public int? KayitUserId { get ; set; }
        public int? DegistirmeUserId { get ; set ; }
    }
}
