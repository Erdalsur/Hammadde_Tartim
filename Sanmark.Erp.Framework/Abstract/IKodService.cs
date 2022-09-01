using Sanmark.Erp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Abstract
{
    public interface IKodService
    {
        List<Kod> GetAll(Expression<Func<Kod, bool>> filter = null);
        Kod GetById(int id);
        void Add(Kod kod);
        void Update(Kod kod);
        void Delete(Kod kod);
        void SaveAll(BindingList<Kod> kodlar);
        string SabitKodVer(string tablo);
        void KodArttirma(string tablo, string verilenKod);
    }
}
