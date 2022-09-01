using Sanmark.Core.DataAccess;
using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Entities.Concrete.Depolar;

namespace Sanmark.Erp.Data.Abstract
{
    public interface IDepoDal : IEntityRepository<Depo>
    {
    }
    public interface IDepoHareketDal : IEntityRepository<StokDepoHareket>
    {
    }


}
