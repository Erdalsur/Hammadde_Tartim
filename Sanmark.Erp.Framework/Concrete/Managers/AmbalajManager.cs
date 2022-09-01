using Sanmark.Core.Aspects.Postsharp.CacheAspects;
using Sanmark.Core.Aspects.Postsharp.ValidationAspects;
using Sanmark.Core.CrossCuttingConcerns.Caching.Microsoft;
using Sanmark.Core.Utilities;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Entities.Concrete.Cari;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Framework.Abstract;
using Sanmark.Erp.Framework.ValidationRules.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Concrete.Managers
{
    public class AmbalajManager : IAmbalajService
    {
        IAmbalajDal _ambalajDal;

        public AmbalajManager(IAmbalajDal ambalajDal)
        {
            _ambalajDal = ambalajDal;
        }
        [FluentValidationAspect(typeof(AmbalajValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Add(Ambalaj ambalaj)
        {
            ambalaj.KayitTarihi = DateTime.Now;
            ambalaj.KayitUserId = UserSession.CurrentUser.Id;
            _ambalajDal.Add(ambalaj);
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(Ambalaj ambalaj)
        {
            _ambalajDal.Delete(ambalaj);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Ambalaj> GetAll(Expression<Func<Ambalaj, bool>> filter = null)
        {
            return _ambalajDal.GetList(filter);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public Ambalaj GetById(int id)
        {
            return _ambalajDal.Get(a => a.Id == id);
        }
        [FluentValidationAspect(typeof(AmbalajValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Update(Ambalaj ambalaj)
        {
            ambalaj.DegistirmeTarihi = DateTime.Now;
            ambalaj.DegistirmeUserId = UserSession.CurrentUser.Id;
            _ambalajDal.Update(ambalaj);
        }
    }
}
