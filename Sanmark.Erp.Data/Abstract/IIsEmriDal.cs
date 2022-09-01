using Sanmark.Core.DataAccess;
using Sanmark.Erp.Entities.ComplexTypes.Uretim;
using Sanmark.Erp.Entities.Concrete.Uretim;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Sanmark.Erp.Data.Abstract
{
    public interface IIsEmriDal : IEntityRepository<IsEmri>
    {
        List<IsEmri> GetMasterList(Expression<Func<IsEmri, bool>> filter = null);
        List<HammaddeKontrolFoyu> HammaddeKontrolFoyuOlustur(int emirId);
        List<IsEmriIhtiyacListesi> IsEmriIhtiyacListesiOlustur(int ReceteId, decimal Carpan);
    }
    public interface IIsEmriOperasyonDal : IEntityRepository<IsEmriOperasyon>
    {
        void TopluSil(List<IsEmriOperasyon> OperasyonListesi);
    }
    public interface IIsEmriOperasyonIslemDal : IEntityRepository<IsEmriOperasyonIslem>
    {

    }
}
