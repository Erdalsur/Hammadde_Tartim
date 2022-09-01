using Sanmark.Core.Aspects.Postsharp.CacheAspects;
using Sanmark.Core.Aspects.Postsharp.TransactionAspects;
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
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Concrete.Managers
{
    public class StokBirimManager : IStokBirimService
    {
        IStokBirimDal _stokBirimDal;
        public StokBirimManager(IStokBirimDal stokBirimDal)
        {
            _stokBirimDal = stokBirimDal;
        }
        [FluentValidationAspect(typeof(StokBirimValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Add(StokBirim stokBirim)
        {
            stokBirim.KayitTarihi = DateTime.Now;
            stokBirim.KayitUserId = UserSession.CurrentUser.Id;
            _stokBirimDal.Add(stokBirim);
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(StokBirim stokBirim)
        {
            _stokBirimDal.Delete(stokBirim);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StokBirim> GetAll(Expression<Func<StokBirim, bool>> filter = null)
        {
            return _stokBirimDal.GetList(filter);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public StokBirim GetById(int id)
        {
            return _stokBirimDal.Get(b => b.Id == id);
        }
        [TransactionScopeAspect()]
        public void SaveAll(BindingList<StokBirim> stokBirims)
        {
            foreach (StokBirim stokBirim in stokBirims)
            {
                
                if (stokBirim.Id == 0)
                {
                    Add(stokBirim);
                }
                else
                    Update(stokBirim);
            }
        }

        [FluentValidationAspect(typeof(StokBirimValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Update(StokBirim stokBirim)
        {
            stokBirim.DegistirmeTarihi = DateTime.Now;
            stokBirim.DegistirmeUserId = UserSession.CurrentUser.Id;
            _stokBirimDal.Update(stokBirim);
        }
    }
}
