using Sanmark.Core.Aspects.Postsharp.CacheAspects;
using Sanmark.Core.Aspects.Postsharp.ValidationAspects;
using Sanmark.Core.CrossCuttingConcerns.Caching.Microsoft;
using Sanmark.Core.Utilities;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Framework.Abstract;
using Sanmark.Erp.Framework.ValidationRules.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Concrete.Managers
{
    public class DonemManager : IDonemService
    {
        IDonemDal _donemDal;
        public DonemManager(IDonemDal donemDal)
        {
            _donemDal = donemDal;
        }
        [FluentValidationAspect(typeof(DonemValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Add(Donem donem)
        {
            donem.KayitTarihi = DateTime.Now;
            donem.KayitUserId = UserSession.CurrentUser.Id;
            _donemDal.Add(donem);
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(Donem donem)
        {
            _donemDal.Delete(donem);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Donem> GetAll(Expression<Func<Donem, bool>> filter = null)
        {
            return _donemDal.GetList(filter);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public Donem GetById(int id)
        {
            return _donemDal.Get(s => s.Id == id);
        }
        [FluentValidationAspect(typeof(DonemValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Update(Donem donem)
        {
            donem.DegistirmeTarihi = DateTime.Now;
            donem.DegistirmeUserId = UserSession.CurrentUser.Id;
            _donemDal.Update(donem);
        }
    }
}
