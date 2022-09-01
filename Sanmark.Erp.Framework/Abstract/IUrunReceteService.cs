using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Abstract
{
    public interface IUrunReceteService
    {
        List<UrunRecete> GetAll(Expression<Func<UrunRecete, bool>> filter = null);
        UrunRecete GetById(int id);
        void Add(UrunRecete urunRecete);
        UrunReceteDetay GetDetayById(int id);
    }
}
