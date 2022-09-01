using Sanmark.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanmark.Erp.Entities.Concrete.Cari
{
    public class Firma:IEntity
    {
        public virtual int Id { get; set; }
        public virtual int SirketId { get; set; }
        public virtual Int16 FirmaKartTip { get; set; }
        public virtual Int16 FirmaTip { get; set; }
        public virtual string Kod { get; set; }
        public virtual string Ad { get; set; }
        public virtual string Soyad { get; set; }
        public virtual string VergiDairesi { get; set; }
        public virtual string VergiNo { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? DegistirmeTarihi { get ; set ; }
        public int? KayitUserId { get ; set ; }
        public int? DegistirmeUserId { get; set ; }
    }
}
