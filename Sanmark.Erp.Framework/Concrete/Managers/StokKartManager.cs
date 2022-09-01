using Sanmark.Core.Aspects.Postsharp.CacheAspects;
using Sanmark.Core.Aspects.Postsharp.ValidationAspects;
using Sanmark.Core.CrossCuttingConcerns.Caching.Microsoft;
using Sanmark.Core.Utilities;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Entities.Concrete.Uretim;
using Sanmark.Erp.Framework.Abstract;
using Sanmark.Erp.Framework.ValidationRules.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Concrete.Managers
{
    public class StokKartManager : IStokKartService
    {
        IStokKartiDal _stokKartDal;
        public StokKartManager(IStokKartiDal stokKartDal)
        {
            _stokKartDal = stokKartDal;
        }

        [FluentValidationAspect(typeof(StokKartValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Add(StokKarti stokKarti)
        {
            stokKarti.KayitTarihi = DateTime.Now;
            stokKarti.KayitUserId = UserSession.CurrentUser.Id;
            _stokKartDal.Add(stokKarti);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(StokKarti stokKarti)
        {
            _stokKartDal.Delete(stokKarti);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StokKarti> GetAll(Expression<Func<StokKarti, bool>> filter = null)
        {

            return _stokKartDal.GetList(filter);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public StokKarti GetById(int id)
        {
            return _stokKartDal.Get(i => i.Id == id);
        }

        [FluentValidationAspect(typeof(StokKartValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Update(StokKarti stokKarti)
        {
            stokKarti.DegistirmeTarihi = DateTime.Now;
            stokKarti.DegistirmeUserId = UserSession.CurrentUser.Id;
            _stokKartDal.Update(stokKarti);
        }
    }
}
