using Sanmark.Core.Aspects.Postsharp.CacheAspects;
using Sanmark.Core.CrossCuttingConcerns.Caching.Microsoft;
using Sanmark.Core.Utilities;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Framework.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Concrete.Managers
{
    public class ReceteManager : IUrunReceteService
    {
        IUrunReceteDal _urunReceteDal;
        IUrunReceteDetayDal _urunReceteDetayDal;
        IStokKartiDal _stokKartiDal;
        public ReceteManager(IUrunReceteDal urunReceteDal, IUrunReceteDetayDal urunReceteDetayDal, IStokKartiDal stokKartiDal)
        {
            _urunReceteDal = urunReceteDal;
            _urunReceteDetayDal = urunReceteDetayDal;
            _stokKartiDal = stokKartiDal;
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Add(UrunRecete urunRecete)
        {
            urunRecete.SirketId = UserSession.Sirket.Id;
            var _stokKarti = _stokKartiDal.Get(s => s.Id == urunRecete.StokId);
            decimal carpan = 1;
            if (urunRecete.Id > 0)
            {
                //Recete Mevcut önceki pasif et Yeni Revizyon Ekle
                var eskirecete = _urunReceteDal.Get(f => f.Id == urunRecete.Id);
                eskirecete.IsActive = false;
                eskirecete.RevizyonTarihi = urunRecete.DegistirmeTarihi = DateTime.Now;
                eskirecete.DegistirmeUserId = UserSession.CurrentUser.Id;
                _urunReceteDal.Update(eskirecete);
            }
            if (_stokKarti.StokBirimId == urunRecete.BirimId)
            {
                urunRecete.BirimPay = 1;
                urunRecete.BirimPayda = 1;
                urunRecete.Carpan = carpan;
            }
            else
            {
                if (_stokKarti.Birim2Id == urunRecete.BirimId)
                {
                    carpan = _stokKarti.Birim2Pay / _stokKarti.Birim2Payda;
                    urunRecete.BirimPay = _stokKarti.Birim2Pay;
                    urunRecete.BirimPayda = _stokKarti.Birim2Payda;
                    urunRecete.Carpan = carpan;
                }
                else if (_stokKarti.Birim3Id == urunRecete.BirimId)
                {
                    carpan = _stokKarti.Birim3Pay / _stokKarti.Birim3Payda;
                    urunRecete.BirimPay = _stokKarti.Birim3Pay;
                    urunRecete.BirimPayda = _stokKarti.Birim3Payda;
                    urunRecete.Carpan = carpan;
                }
                else
                {
                    urunRecete.BirimPay = 1;
                    urunRecete.BirimPayda = 1;
                    urunRecete.Carpan = carpan;
                }

            }
            urunRecete.RevizyonNo += 1;
            urunRecete.IsActive = true;            
            urunRecete.RevizyonTarihi = urunRecete.KayitTarihi = DateTime.Now;
            urunRecete.KayitUserId = UserSession.CurrentUser.Id;
            urunRecete.UrunReceteDetay.ToList().ForEach(s => s.KayitUserId=urunRecete.KayitUserId);
            urunRecete.UrunReceteDetay.ToList().ForEach(s => s.KayitTarihi = DateTime.Now);
            urunRecete.UrunReceteDetay.ToList().ForEach(s => s.AnaStokKartiId = urunRecete.StokId);
            urunRecete.DegistirmeTarihi = null;
            urunRecete.DegistirmeUserId = null;
            _urunReceteDal.Add(urunRecete);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<UrunRecete> GetAll(Expression<Func<UrunRecete, bool>> filter = null)
        {
            return _urunReceteDal.GetList(filter);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public UrunRecete GetById(int id)
        {
            var recete = _urunReceteDal.Get(s => s.Id == id);
            recete.UrunReceteDetay = (_urunReceteDetayDal.GetList(s => s.UrunReceteId == id));
            return recete;
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public UrunReceteDetay GetDetayById(int id)
        {
            return _urunReceteDetayDal.Get(s => s.Id == id);
        }

    }
}
