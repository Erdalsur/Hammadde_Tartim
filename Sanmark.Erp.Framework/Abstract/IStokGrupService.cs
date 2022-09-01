using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Abstract
{
    public interface IStokGrupService
    {
        List<StokGrup> GetAll(Expression<Func<StokGrup, bool>> filter = null);
        StokGrup GetById(int id);
        void Add(StokGrup stokGrup);
        void Update(StokGrup stokGrup);
        void Delete(StokGrup stokGrup);
        void SaveAll(List<StokGrup> grups);
    }
}
