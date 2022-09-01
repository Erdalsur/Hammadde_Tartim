using Sanmark.Erp.Entities.ComplexTypes.Uretim;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Entities.Concrete.Uretim;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Abstract
{
    public interface IIsEmirService
    {
        List<Makina> GetMakinalar(Expression<Func<Makina, bool>> filter = null);
        List<IsEmri> GetAll(Expression<Func<IsEmri, bool>> filter = null);
        List<IsEmriOperasyon> GetOperasyonlarAll(Expression<Func<IsEmriOperasyon, bool>> filter = null);
        List<IsEmriOperasyonIslem> GetOperasyonIslemelerAll(Expression<Func<IsEmriOperasyonIslem, bool>> filter = null);
        IsEmri GetById(int id);
        void Update(IsEmri ısEmri);
        void Delete(IsEmri ısEmri);
        void IsEmri_Add(IsEmri ısEmri, int UstEmirNo = 0);
        void UretimBaslat(IsEmriOperasyon secili_Operasyon);
        void UretimBitir(IsEmriOperasyon secili_Operasyon);
        decimal TartimCarpaniBul(int stokKartiId, int TartiBirimi, int HedefBirim);
        IsEmriOperasyonIslem OperasyonEkle(IsEmriOperasyonIslem operasyonIslem, bool Update = false);
        List<HammaddeKontrolFoyu> HammaddeKontrolFoyuOlustur(int emirId);
        List<IsEmriIhtiyacListesi> IsEmriIhtiyacListesiHazirla(int StokId, int HedefBirimId, decimal Miktar);
        List<LotListesi> LotListesi(Expression<Func<LotListesi, bool>> filter = null);
    }
}
