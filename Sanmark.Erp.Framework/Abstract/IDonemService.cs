using Sanmark.Erp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Abstract
{
    public interface IDonemService
    {
        List<Donem> GetAll(Expression<Func<Donem, bool>> filter = null);
        Donem GetById(int id);
        void Add(Donem donem);
        void Update(Donem donem);
        void Delete(Donem donem);
    }
}
