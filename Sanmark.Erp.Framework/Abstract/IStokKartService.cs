using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Entities.Concrete.Uretim;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Abstract
{
    public interface IStokKartService
    {
        List<StokKarti> GetAll(Expression<Func<StokKarti, bool>> filter = null);
        StokKarti GetById(int id);
        void Add(StokKarti stokKarti);
        void Update(StokKarti stokKarti);
        void Delete(StokKarti stokKarti);
    }
}
