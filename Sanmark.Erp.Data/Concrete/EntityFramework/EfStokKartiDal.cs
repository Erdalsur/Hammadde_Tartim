using Sanmark.Core.DataAccess.EntityFramework;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Entities.Concrete.Uretim;
using System;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework
{
    public class EfStokKartiDal : EfEntityRepositoryBase<StokKarti, ErpContext>, IStokKartiDal
    {
    }
}
