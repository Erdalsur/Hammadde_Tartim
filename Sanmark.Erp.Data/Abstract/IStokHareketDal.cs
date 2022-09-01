using Sanmark.Core.DataAccess;
using Sanmark.Erp.Entities.ComplexTypes.Uretim;
using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Sanmark.Erp.Data.Abstract
{
    public interface IStokHareketDal : IEntityRepository<StokHareket>
    {
        List<StokHareketListe> StokHarketListesi(Expression<Func<StokHareket, bool>> filter = null);
        List<LotListesi> LotListesi(Expression<Func<LotListesi, bool>> filter = null);
    }
}
