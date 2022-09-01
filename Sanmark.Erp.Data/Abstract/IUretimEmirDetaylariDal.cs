using Sanmark.Core.DataAccess;
using Sanmark.Erp.Entities.ComplexTypes.Uretim;
using Sanmark.Erp.Entities.Concrete.Uretim;
using System.Collections.Generic;

namespace Sanmark.Erp.Data.Abstract
{
    public interface IUretimEmirDetaylariDal : IEntityRepository<UretimEmirDetaylari>
    {
        List<HammaddeKontrolFoyu> GetHammaddeKontrol(int id);
        
    }
}
