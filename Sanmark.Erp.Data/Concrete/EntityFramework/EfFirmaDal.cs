using Sanmark.Core.DataAccess.EntityFramework;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Entities.Concrete.Cari;
using System;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework
{
    public class EfFirmaDal : EfEntityRepositoryBase<Firma, ErpContext>, IFirmaDal
    {
    }
}
