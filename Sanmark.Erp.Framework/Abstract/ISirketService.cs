using Sanmark.Erp.Entities.Concrete;
using System.Collections.Generic;

namespace Sanmark.Erp.Framework.Abstract
{
    public interface ISirketService
    {
        List<Sirket> GetAll();
        Sirket GetById(int id);
        void Add(Sirket sirket);
        void Update(Sirket sirket);
        void Delete(Sirket sirket);
    }
}
