using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Entities.Concrete.Depolar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Abstract
{
    public interface IDepoService
    {
        List<Depo> GetAll(Expression<Func<Depo, bool>> filter = null);
        Depo GetById(int id);
        void Add(Depo depo);
        void Update(Depo depo);
        void Delete(Depo depo);
        void SaveAll(BindingList<Depo> depolar);
    }
}
