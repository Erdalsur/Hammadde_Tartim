using Sanmark.Core.Aspects.Postsharp.CacheAspects;
using Sanmark.Core.Aspects.Postsharp.ValidationAspects;
using Sanmark.Core.CrossCuttingConcerns.Caching.Microsoft;
using Sanmark.Core.Utilities;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Framework.Abstract;
using Sanmark.Erp.Framework.ValidationRules.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Concrete.Managers
{
    public class UrunAgaciManager : IUrunAgaciService
    {
        IUrunAgacDal _urunAgacDal;
        IUrunAgacSatirlariDal _urunAgacSatirlari;
        public UrunAgaciManager(IUrunAgacDal urunAgacDal, IUrunAgacSatirlariDal urunAgacSatirlari)
        {
            _urunAgacDal = urunAgacDal;
            _urunAgacSatirlari = urunAgacSatirlari;
        }
        //[FluentValidationAspect(typeof(StokKartValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Add(UrunAgaclari urunAgaclari)
        {
            urunAgaclari.KayitTarihi = DateTime.Now;
            urunAgaclari.KayitUserId = UserSession.CurrentUser.Id;
            _urunAgacDal.Add(urunAgaclari);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<UrunAgaclari> GetAll(Expression<Func<UrunAgaclari, bool>> filter = null)
        {
            return _urunAgacDal.GetList(filter);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public UrunAgaclari GetById(int id)
        {
            var Urun = _urunAgacDal.Get(s => s.Id == id);
            Urun.UrunAgacSatirlari = _urunAgacSatirlari.GetList(s => s.UrunAgacId == id);
            return Urun;
        }
    }
}
