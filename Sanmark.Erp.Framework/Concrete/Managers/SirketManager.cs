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

namespace Sanmark.Erp.Framework.Concrete.Managers
{
    public class SirketManager : ISirketService
    {
        private ISirketDal _sirketDal;
        public SirketManager(ISirketDal sirketDal)
        {
            _sirketDal = sirketDal;
        }
        [FluentValidationAspect(typeof(SirketValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Add(Sirket sirket)
        {
            sirket.KayitTarihi = DateTime.Now;
            sirket.KayitUserId = UserSession.CurrentUser.Id;
            _sirketDal.Add(sirket);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(Sirket sirket)
        {
            //Silme Öncesi Kontroller Yapılacak

            _sirketDal.Delete(sirket);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Sirket> GetAll()
        {
            return _sirketDal.GetList();
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public Sirket GetById(int id)
        {
            return _sirketDal.Get(s => s.Id == id);
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [FluentValidationAspect(typeof(SirketValidator))]
        public void Update(Sirket sirket)
        {
            sirket.DegistirmeTarihi = DateTime.Now;
            sirket.DegistirmeUserId = UserSession.CurrentUser.Id;
            _sirketDal.Update(sirket);
        }
    }
}
