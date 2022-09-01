using Sanmark.Core.DataAccess.EntityFramework;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Entities.Concrete.Depolar;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Sanmark.Erp.Data.Concrete.EntityFramework
{
    public class EfDepoDal : EfEntityRepositoryBase<Depo, ErpContext>, IDepoDal
    {
    }
    public class EfDepoHareketDal : EfEntityRepositoryBase<StokDepoHareket, ErpContext>, IDepoHareketDal
    {
        
        
        public StokDepoHareket GetByDolu(Expression<Func<StokDepoHareket, bool>> filter)
        {
            using (var context = new ErpContext())
            {
                //var node= context.StokDepoHarekets.Where(filter).FirstOrDefault();
                //node.DepoHareketSatirlaris=context.
                return null;
            }
        }
    }
}
