using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Abstract
{
    public interface IUrunAgaciService
    {
        List<UrunAgaclari> GetAll(Expression<Func<UrunAgaclari, bool>> filter = null);
        UrunAgaclari GetById(int id);
        void Add(UrunAgaclari urunAgaclari);

    }
}
