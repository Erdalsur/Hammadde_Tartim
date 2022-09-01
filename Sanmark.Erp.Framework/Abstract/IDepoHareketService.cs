using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Entities.Concrete.Depolar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Abstract
{
    public interface IDepoHareketService
    {
        List<StokDepoHareket> GetAll(Expression<Func<StokDepoHareket, bool>> filter = null);
        StokDepoHareket GetById(int id);
        void Add(StokDepoHareket depoHareket);
        void Update(StokDepoHareket depoHareket);
        void Delete(StokDepoHareket depoHareket);
        void SaveAll(BindingList<StokDepoHareket> depoHareketleri);
    }
}
