using Sanmark.Core.Aspects.Postsharp.CacheAspects;
using Sanmark.Core.Aspects.Postsharp.ValidationAspects;
using Sanmark.Core.CrossCuttingConcerns.Caching.Microsoft;
using Sanmark.Core.Utilities;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Entities.Concrete.Cari;
using Sanmark.Erp.Framework.Abstract;
using Sanmark.Erp.Framework.ValidationRules.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Concrete.Managers
{
    public class FirmaManager : IFirmaService
    {
        IFirmaDal _firmaDal;
        public FirmaManager(IFirmaDal firmaDal)
        {
            _firmaDal = firmaDal;
        }
        [FluentValidationAspect(typeof(FirmaValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Add(Firma firma)
        {
            firma.KayitUserId = UserSession.CurrentUser.Id;
            firma.KayitTarihi = DateTime.Now;
            _firmaDal.Add(firma);
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(Firma firma)
        {
            _firmaDal.Delete(firma);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Firma> GetAll(Expression<Func<Firma, bool>> filter = null)
        {
            return _firmaDal.GetList(filter).OrderBy(f=>f.FirmaTip).ToList();
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public Firma GetById(int id)
        {
            return _firmaDal.Get(f => f.Id == id);
        }
        [FluentValidationAspect(typeof(FirmaValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Update(Firma firma)
        {
            firma.DegistirmeTarihi = DateTime.Now;
            firma.DegistirmeUserId = UserSession.CurrentUser.Id;
            _firmaDal.Update(firma);
        }
    }
}
