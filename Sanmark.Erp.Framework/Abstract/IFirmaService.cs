using Sanmark.Erp.Entities.Concrete.Cari;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Abstract
{
    public interface IFirmaService
    {
        List<Firma> GetAll(Expression<Func<Firma, bool>> filter = null);
        Firma GetById(int id);
        void Add(Firma firma);
        void Update(Firma firma);
        void Delete(Firma firma);
    }
}
