using Sanmark.Core.DataAccess.EntityFramework;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Entities.Concrete;
using System;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework
{
    public class EfSirketDal : EfEntityRepositoryBase<Sirket, ErpContext>, ISirketDal
    {
    }
}
