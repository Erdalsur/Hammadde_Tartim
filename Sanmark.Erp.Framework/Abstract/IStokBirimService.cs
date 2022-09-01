using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Abstract
{
    public interface IStokBirimService
    {
        List<StokBirim> GetAll(Expression<Func<StokBirim, bool>> filter = null);
        StokBirim GetById(int id);
        void Add(StokBirim stokBirim);
        void Update(StokBirim stokBirim);
        void Delete(StokBirim stokBirim);
        void SaveAll(BindingList<StokBirim> stokBirims);
    }
}
