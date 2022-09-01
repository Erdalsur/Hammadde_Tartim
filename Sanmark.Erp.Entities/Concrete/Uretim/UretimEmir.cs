using Sanmark.Core.Entities;
using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanmark.Erp.Entities.Concrete.Uretim
{
    public partial class UretimEmirleri : IEntity
    {
        public UretimEmirleri()
        {
            UretimEmirDetaylari = new HashSet<UretimEmirDetaylari>();
        }
        public int Id { get; set; }
        public int DonemId { get; set; }
        public int Durumu { get; set; }
        public int MakinaId { get; set; }
        public int UrunId { get; set; }
        public string Aciklama { get; set; }
        public string SeriNo { get; set; }
        public DateTime? Tarih { get; set; }
        public decimal Miktar { get; set; }
        public DateTime? UretimBaslangicTarihi { get; set; }
        public DateTime? UretimBitisTarihi { get; set; }
        public virtual Donem Donem { get; set; }
        public virtual Makina Makina { get; set; }
        public virtual StokKarti Urun { get; set; }
        public int AltUretimId { get; set; }
        public int UstUretimId { get; set; }
        public int UretimTipi { get; set; }
        public virtual ICollection<UretimEmirDetaylari> UretimEmirDetaylari { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? DegistirmeTarihi { get; set; }
        public int? KayitUserId { get; set; }
        public int? DegistirmeUserId { get; set; }
    }
}
