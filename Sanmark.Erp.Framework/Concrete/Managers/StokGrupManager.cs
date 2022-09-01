using Sanmark.Core.Aspects.Postsharp.CacheAspects;
using Sanmark.Core.Aspects.Postsharp.TransactionAspects;
using Sanmark.Core.Aspects.Postsharp.ValidationAspects;
using Sanmark.Core.CrossCuttingConcerns.Caching.Microsoft;
using Sanmark.Core.Utilities;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Framework.Abstract;
using Sanmark.Erp.Framework.ValidationRules.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Sanmark.Erp.Framework.Concrete.Managers
{
    public class StokGrupManager : IStokGrupService
    {
        IStokGrupDal _stokGrupDal;
        StokGrup _stokGrup;
        public StokGrupManager(IStokGrupDal stokGrupDal)
        {
            _stokGrupDal = stokGrupDal;
        }
        [FluentValidationAspect(typeof(StokGrupValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Add(StokGrup stokGrup)
        {
            stokGrup.KayitUserId = UserSession.CurrentUser.Id;
            stokGrup.KayitTarihi = DateTime.Now;
            _stokGrupDal.Add(stokGrup);
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(StokGrup stokGrup)
        {
            _stokGrupDal.Delete(stokGrup);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StokGrup> GetAll(Expression<Func<StokGrup, bool>> filter = null)
        {
            return _stokGrupDal.GetList(filter);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public StokGrup GetById(int id)
        {
            return _stokGrupDal.Get(g => g.Id == id);
        }
        [TransactionScopeAspect()]
        public void SaveAll(List<StokGrup> grups)
        {

            foreach(StokGrup stokGrup in grups)
            {
                _stokGrup=stokGrup;
                if (stokGrup.Id == 0)
                {
                    Add(_stokGrup);
                }
                else
                    Update(_stokGrup);
            }
        }

        [FluentValidationAspect(typeof(StokGrupValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Update(StokGrup stokGrup)
        {
            stokGrup.DegistirmeTarihi = DateTime.Now;
            stokGrup.DegistirmeUserId = UserSession.CurrentUser.Id;
            _stokGrupDal.Update(stokGrup);
        }
    }
}
