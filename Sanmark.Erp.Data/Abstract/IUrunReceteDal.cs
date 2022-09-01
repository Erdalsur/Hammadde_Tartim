using Sanmark.Core.DataAccess;
using Sanmark.Erp.Entities.Concrete.Stok;

namespace Sanmark.Erp.Data.Abstract
{
    public interface IUrunReceteDal : IEntityRepository<UrunRecete>
    {
    }
    public interface IUrunReceteDetayDal : IEntityRepository<UrunReceteDetay>
    {
    }
}
