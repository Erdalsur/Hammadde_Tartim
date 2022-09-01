using Sanmark.Erp.Entities.ComplexTypes.Uretim;
using Sanmark.Erp.Entities.Concrete.Uretim;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Abstract
{
    public interface IUretimService
    {
        List<UretimEmirleri> GetAll(Expression<Func<UretimEmirleri, bool>> filter = null);
        UretimEmirleri GetById(int id);
        void UretimEmri_Kayit(UretimEmirleri uretimEmirleri, int UstEmirNo = 0);
        void Update(UretimEmirleri uretimEmirleri);
        void Delete(UretimEmirleri uretimEmirleri);
        List<Makina> GetMakinalar(Expression<Func<Makina, bool>> filter = null);
        void UretimEmir_Duzelt(UretimEmirleri uretimEmirleri);
        List<UretimEmirDetaylari> UretimEmirDetaylari(int UretimId);
        UretimEmirDetaylari UretimDetay_Kayit(UretimEmirDetaylari uretimEmirDetaylari);
        UretimEmirDetaylari GetDetaylari(int id);

        List<UretimTartimlari> GetTartimAll(Expression<Func<UretimTartimlari, bool>> filter = null);
        UretimTartimlari GetTartimBy(int id);
        void UretimBitir(UretimEmirleri uretimEmirleri);
        void UretimBaslat(UretimEmirleri uretimEmirleri);
        List<HammaddeKontrolFoyu> HammaddeKontrolFoyuOlustur(int id);
        UretimTartimlari Tartim_Kayit(UretimTartimlari uretimTartim);
    }
}
