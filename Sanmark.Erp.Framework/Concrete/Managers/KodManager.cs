using Sanmark.Core.Aspects.Postsharp.CacheAspects;
using Sanmark.Core.Aspects.Postsharp.TransactionAspects;
using Sanmark.Core.Aspects.Postsharp.ValidationAspects;
using Sanmark.Core.CrossCuttingConcerns.Caching.Microsoft;
using Sanmark.Core.Utilities;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Framework.Abstract;
using Sanmark.Erp.Framework.ValidationRules.FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Concrete.Managers
{
    public class KodManager : IKodService
    {
        IKodDal _kodDal;

        public KodManager(IKodDal kodDal)
        {
            _kodDal = kodDal;
        }
        [FluentValidationAspect(typeof(KodValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Add(Kod kod)
        {
            kod.KayitTarihi = DateTime.Now;
            kod.KayitUserId = UserSession.CurrentUser.Id;
            _kodDal.Add(kod);
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(Kod kod)
        {
            _kodDal.Delete(kod);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Kod> GetAll(Expression<Func<Kod, bool>> filter = null)
        {
            return _kodDal.GetList(filter);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public Kod GetById(int id)
        {
            return _kodDal.Get(f => f.Id == id);
        }

        public string SabitKodVer(string tablo)
        {
            List<Kod> data = _kodDal.GetList(c => c.Tablo == tablo && c.DonemId == UserSession.Donem.Id && c.SirketId == UserSession.Sirket.Id);
            
            return KodOlustur(data[0].OnEki,data[0].SonDeger,data[0].Uzunlugu);
        }

        [TransactionScopeAspect()]
        public void SaveAll(BindingList<Kod> kodlar)
        {
            foreach (Kod _depo in kodlar)
            {
                if (_depo.Id == 0)
                {
                    Add(_depo);
                }
                else
                    Update(_depo);
            }
        }

        [FluentValidationAspect(typeof(DonemValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Update(Kod kod)
        {
            kod.DegistirmeTarihi = DateTime.Now;
            kod.DegistirmeUserId = UserSession.CurrentUser.Id;
            _kodDal.Update(kod);
        }

        private string KodOlustur(string onEki, int sonDeger, int kodUzunlugu)
        {
            int sifirSayisi = kodUzunlugu - (onEki.Length + sonDeger.ToString().Length);
            string sifirDizisi = new string('0', sifirSayisi);
            return onEki + sifirDizisi + sonDeger;
        }

        public void KodArttirma(string tablo,string verilenKod)
        {
            if (verilenKod==SabitKodVer(tablo))
            {
                List<Kod> data = _kodDal.GetList(c => c.Tablo == tablo && c.DonemId == UserSession.Donem.Id && c.SirketId == UserSession.Sirket.Id);
                data[0].SonDeger += 1;
                Update(data[0]);
            }
        }
    }
}
