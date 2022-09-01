using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Abstract
{
    public interface IAmbalajService
    {
        List<Ambalaj> GetAll(Expression<Func<Ambalaj, bool>> filter = null);
        Ambalaj GetById(int id);
        void Add(Ambalaj ambalaj);
        void Update(Ambalaj ambalaj);
        void Delete(Ambalaj ambalaj);
    }
}
