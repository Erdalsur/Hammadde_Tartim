using Sanmark.Core.Aspects.Postsharp.CacheAspects;
using Sanmark.Core.Aspects.Postsharp.TransactionAspects;
using Sanmark.Core.Aspects.Postsharp.ValidationAspects;
using Sanmark.Core.CrossCuttingConcerns.Caching.Microsoft;
using Sanmark.Core.Utilities;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Entities.Concrete.Depolar;
using Sanmark.Erp.Framework.Abstract;
using Sanmark.Erp.Framework.ValidationRules.FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Concrete.Managers
{
    public class DepoManager : IDepoService
    {
        IDepoDal _depoDal;
        public DepoManager(IDepoDal depoDal)
        {
            _depoDal = depoDal;
        }
        [FluentValidationAspect(typeof(DepoValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Add(Depo depo)
        {
            depo.KayitTarihi = DateTime.Now;
            depo.KayitUserId = UserSession.CurrentUser.Id;
            _depoDal.Add(depo);
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(Depo depo)
        {
            _depoDal.Delete(depo);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Depo> GetAll(Expression<Func<Depo, bool>> filter = null)
        {
            return _depoDal.GetList(filter);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public Depo GetById(int id)
        {
            return _depoDal.Get(d => d.Id == id);
        }
        [TransactionScopeAspect()]
        public void SaveAll(BindingList<Depo> depolar)
        {
            foreach (Depo _depo in depolar)
            {
                if (_depo.Id == 0)
                {
                    Add(_depo);
                }
                else
                    Update(_depo);
            }
        }
        [FluentValidationAspect(typeof(DepoValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Update(Depo depo)
        {
            depo.DegistirmeTarihi = DateTime.Now;
            depo.DegistirmeUserId = UserSession.CurrentUser.Id;
            _depoDal.Update(depo);
        }
    }
    public class DepoHareketManager : IDepoHareketService
    {
        IDepoHareketDal _depoHareketDal;
        public DepoHareketManager(IDepoHareketDal depoHareketDal)
        {
            _depoHareketDal = depoHareketDal;
        }

        //[FluentValidationAspect(typeof(DepoHareketValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Add(StokDepoHareket depoHareket)
        {
            depoHareket.KayitUserId = UserSession.CurrentUser.Id;
            depoHareket.KayitTarihi = DateTime.Now;
            _depoHareketDal.Add(depoHareket);
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(StokDepoHareket depoHareket)
        {
            _depoHareketDal.Delete(depoHareket);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StokDepoHareket> GetAll(Expression<Func<StokDepoHareket, bool>> filter = null)
        {
            return _depoHareketDal.GetList(filter);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public StokDepoHareket GetById(int id)
        {
            var hareket=_depoHareketDal.Get(d => d.Id == id);
            
            return hareket;
        }
        [TransactionScopeAspect()]
        public void SaveAll(BindingList<StokDepoHareket> depoHareketleri)
        {
            foreach (StokDepoHareket _depoHareket in depoHareketleri)
            {
                if (_depoHareket.Id == 0)
                {
                    Add(_depoHareket);
                }
                else
                    Update(_depoHareket);
            }
        }

        [FluentValidationAspect(typeof(DepoValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Update(StokDepoHareket depoHareket)
        {
            depoHareket.DegistirmeUserId = UserSession.CurrentUser.Id;
            depoHareket.DegistirmeTarihi = DateTime.Now;
            _depoHareketDal.Update(depoHareket);
        }
    }
}
