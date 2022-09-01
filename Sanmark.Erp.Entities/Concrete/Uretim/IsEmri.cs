using Sanmark.Core.Entities;
using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sanmark.Erp.Entities.Concrete.Uretim
{
    public class IsEmri : IEntity
    {
        public IsEmri()
        {
            IsEmriOperasyon = new HashSet<IsEmriOperasyon>();
        }
        public int Id { get; set; }
        public int DonemId { get; set; }
        public string IsEmriKodu { get; set; }
        public int IsEmriTipi { get; set; }
        public int GenelDurumu { get; set; }
        public string Aciklama { get; set; }
        public string PartiNo { get; set; }
        public int StokKartiId { get; set; }
        public decimal Miktar { get; set; }
        public int BirimId { get; set; }
        public int MakinaId { get; set; }
        public decimal Carpan { get; set; }
        public string BaglantiAdres { get; set; }
        public int? BaglantiId { get; set; }
        public int? FisId { get; set; }
        public DateTime? PlanlananBaslangicTarihi { get; set; }
        public DateTime? PlananBitisTarihi { get; set; }
        public DateTime? BaslamaTarihi { get; set; }
        public DateTime? KapanisTarihi { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? DegistirmeTarihi { get; set; }
        public int? KayitUserId { get; set; }
        public int? DegistirmeUserId { get; set; }
        public virtual ICollection<IsEmriOperasyon> IsEmriOperasyon { get; set; }
    }
    public class IsEmriOperasyon : IEntity
    {
        public IsEmriOperasyon()
        {
            IsEmriOperasyonIslem = new HashSet<IsEmriOperasyonIslem>();
        }
        public int Id { get; set; }
        public int DonemId { get; set; }
        public int IsEmriId { get; set; }
        public int StokKartiId { get; set; }
        public decimal Miktar { get; set; }
        public decimal ReelMiktar { get; set; }
        public int BirimId { get; set; }
        public decimal Carpan { get; set; }
        public string LotNo { get; set; }
        public string ReferansNo { get; set; }
        public int GenelDurum { get; set; }
        public DateTime? IslemBaslamaTarihi { get; set; }
        public DateTime? IslemBitisTarihi { get; set; }
        public DateTime? SonKullanimTarihi { get; set; }
        public decimal FireMiktari { get; set; }
        public int MakinaId { get; set; }
        public int? SiraNo { get; set; }
        public int? FisId { get; set; }
        public int? FisSatirId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? DegistirmeTarihi { get; set; }
        public int? KayitUserId { get; set; }
        public int? DegistirmeUserId { get; set; }
        public int UrunReceteId { get; set; }
        public int UrunReceteDetayId { get; set; }
        public virtual ICollection<IsEmriOperasyonIslem> IsEmriOperasyonIslem { get; set; }
        public virtual IsEmri IsEmri { get; set; }
        public virtual Donem Donem { get; set; }
        public virtual StokKarti StokKarti { get; set; }
        public virtual Makina Makina { get; set; }
        public virtual StokBirim StokBirim { get; set; }
        public virtual UrunRecete UrunRecete { get; set; }
        public virtual UrunReceteDetay UrunReceteDetay { get; set; }


    }
    public class IsEmriOperasyonIslem : IEntity
    {
        public int Id { get; set; }
        public int DonemId { get; set; }
        public int IsEmriOperasyonId { get; set; }
        public string TartimLotNo { get; set; }
        public string TartimReferansNo { get; set; }
        public string TartimTartan { get; set; }
        public string TartimKontrolEden { get; set; }
        public DateTime? TartimTarihi { get; set; }
        public decimal TartimMiktar { get; set; }
        public decimal TartimDara { get; set; }
        public decimal TartimBrut { get; set; }
        public string TartimBirim { get; set; }
        public int? TartimUrunId { get; set; }
        public DateTime? SonKullanimTarihi { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? DegistirmeTarihi { get; set; }
        public int? KayitUserId { get; set; }
        public int? DegistirmeUserId { get; set; }
        public virtual IsEmriOperasyon IsEmriOperasyon { get; set; }
        public virtual Donem Donem { get; set; }
        public virtual StokKarti StokKarti { get; set; }


    }
}
