using Sanmark.Core.Aspects.Postsharp.CacheAspects;
using Sanmark.Core.Aspects.Postsharp.TransactionAspects;
using Sanmark.Core.CrossCuttingConcerns.Caching.Microsoft;
using Sanmark.Core.Utilities;
using Sanmark.Core.Utilities.Tipler;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Entities.ComplexTypes.Uretim;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Framework.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Concrete.Managers
{
    public class StokHareketManager : IStokHareketService
    {
        IStokHareketDal _stokHareketDal;
        IFisDal _fisDal;
        IKodService _kodService;
        IStokKartService _stokKartService;
        public StokHareketManager(IStokHareketDal stokHareketDal, IFisDal fisDal, IKodService kodService, IStokKartService stokKartService)
        {
            _stokHareketDal = stokHareketDal;
            _fisDal = fisDal;
            _kodService = kodService;
            _stokKartService = stokKartService;
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Add(StokHareket stokHareket)
        {
            stokHareket.KayitTarihi = DateTime.Now;
            stokHareket.KayitUserId = UserSession.CurrentUser.Id;
            _stokHareketDal.Add(stokHareket);
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [TransactionScopeAspect()]
        public Fis AddFis(Fis fis, HareketTuru hareketTuru = HareketTuru.GirisFisi)
        {
            fis.KayitTarihi = DateTime.Now;
            fis.KayitUserId = UserSession.CurrentUser.Id;
            if (hareketTuru == HareketTuru.GirisFisi)
                fis.FisKodu = _kodService.SabitKodVer("DepoFisi");
            if (hareketTuru == HareketTuru.HammaddeTartim)
                fis.FisKodu = _kodService.SabitKodVer("TartimFisi");
            if (hareketTuru == HareketTuru.DepoTransfer)
                fis.FisKodu = _kodService.SabitKodVer("TransferFisi");
            fis.StokHareket.ToList().ForEach(c => c.FisNo = fis.FisKodu);
            fis=_fisDal.Add(fis);
            if (hareketTuru == HareketTuru.GirisFisi)
                _kodService.KodArttirma("DepoFisi", fis.FisKodu);
            if (hareketTuru == HareketTuru.HammaddeTartim)
                _kodService.KodArttirma("TartimFisi", fis.FisKodu);
            if (hareketTuru == HareketTuru.DepoTransfer)
                _kodService.KodArttirma("TransferFisi", fis.FisKodu);
            var GirisCikisCarpan = 1;
            decimal carpan = 1;
            foreach (var item in fis.StokHareket)
            {
                var stok = _stokKartService.GetById(item.StokId);
                if (item.GirisCikis == ((int)StokGirisCikis.Giris).ToString())
                {
                    //Giriş ise Stok Artacak
                    GirisCikisCarpan = 1;
                }
                else
                    GirisCikisCarpan = -1;
                if (stok.StokBirimId == item.BirimId)
                {
                    carpan = 1;
                }
                else
                {
                    //Birim Çevrimi Yapılacak
                    if (stok.Birim2Id == item.BirimId)
                    {
                        carpan = stok.Birim2Pay / stok.Birim2Payda;
                    }
                    else if (stok.Birim3Id == item.BirimId)
                    {
                        carpan = stok.Birim3Pay / stok.Birim3Payda;
                    }
                    else
                    {
                        carpan = 1;
                    }
                }
                stok.MevcutMiktar += Convert.ToDecimal(item.GirisCikisMiktar * Convert.ToDouble(carpan) * GirisCikisCarpan);
                _stokKartService.Update(stok);
            }

            return fis;
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [TransactionScopeAspect()]
        public void Delete(StokHareket stokHareket)
        {
            //Stok Bakiyesi Düzeltmesi Yapılacak
            decimal carpan = 1;
            decimal oncekiCarpan = 1;
            var GirisCikisCarpan = 1;
            if (stokHareket.GirisCikis == ((int)StokGirisCikis.Giris).ToString())
            {
                //Giriş ise Stok Artacak
                GirisCikisCarpan = 1;
            }
            else
                GirisCikisCarpan = -1;

            var stok = _stokKartService.GetById(stokHareket.StokId);
            if (stok.StokBirimId == stokHareket.BirimId)
            {
                oncekiCarpan = 1;
            }
            else
            {
                //Birim Çevrimi Yapılacak
                if (stok.Birim2Id == stokHareket.BirimId)
                {
                    oncekiCarpan = stok.Birim2Pay / stok.Birim2Payda;
                }
                else if (stok.Birim3Id == stokHareket.BirimId)
                {
                    oncekiCarpan = stok.Birim3Pay / stok.Birim3Payda;
                }
                else
                {
                    oncekiCarpan = 1;
                }
            }
            stok.MevcutMiktar += Convert.ToDecimal(stokHareket.GirisCikisMiktar * Convert.ToDouble(oncekiCarpan) * GirisCikisCarpan * -1);
            _stokKartService.Update(stok);
            _stokHareketDal.Delete(stokHareket);
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void DeleteFis(Fis fis)
        {
            _fisDal.Delete(fis);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<StokHareket> GetAll(Expression<Func<StokHareket, bool>> filter = null)
        {
            return _stokHareketDal.GetList(filter);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Fis> GetAllFis(Expression<Func<Fis, bool>> filter = null)
        {
            return _fisDal.GetList(filter);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public StokHareket GetById(int id)
        {
            return _stokHareketDal.Get(s => s.Id == id);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public Fis GetByIdFis(int id)
        {
            return _fisDal.Get(s => s.Id == id);
        }

        public List<StokHareketListe> StokHareketListesi(Expression<Func<StokHareket, bool>> filter = null)
        {
            return _stokHareketDal.StokHarketListesi(filter);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Update(StokHareket stokHareket)
        {
            stokHareket.DegistirmeTarihi = DateTime.Now;
            stokHareket.DegistirmeUserId = UserSession.CurrentUser.Id;
            _stokHareketDal.Update(stokHareket);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [TransactionScopeAspect()]
        public void UpdateFis(Fis fis)
        {
            fis.DegistirmeTarihi = DateTime.Now;
            fis.DegistirmeUserId = UserSession.CurrentUser.Id;
            fis.StokHareket.ToList().ForEach(c => c.FisNo = fis.FisKodu);
            fis.StokHareket.ToList().ForEach(c => c.FisId = fis.Id);

            _fisDal.Update(fis);
            var GirisCikisCarpan = 1;
            decimal carpan = 1;
            decimal oncekiCarpan = 1;
            foreach (var item in fis.StokHareket)
            {
                var stok = _stokKartService.GetById(item.StokId);
                var oncekiHareket = _stokHareketDal.Get(f => f.Id == item.Id);
                if (item.GirisCikis == ((int)StokGirisCikis.Giris).ToString())
                {
                    //Giriş ise Stok Artacak
                    GirisCikisCarpan = 1;
                }
                else
                    GirisCikisCarpan = -1;

                //Önceki Stok Değerini Düş
                if (item.Id > 0)
                {
                    if (stok.StokBirimId == oncekiHareket.BirimId)
                    {
                        oncekiCarpan = 1;
                    }
                    else
                    {
                        //Birim Çevrimi Yapılacak
                        if (stok.Birim2Id == oncekiHareket.BirimId)
                        {
                            oncekiCarpan = stok.Birim2Pay / stok.Birim2Payda;
                        }
                        else if (stok.Birim3Id == oncekiHareket.BirimId)
                        {
                            oncekiCarpan = stok.Birim3Pay / stok.Birim3Payda;
                        }
                        else
                        {
                            oncekiCarpan = 1;
                        }
                    }
                    stok.MevcutMiktar += Convert.ToDecimal(oncekiHareket.GirisCikisMiktar * Convert.ToDouble(oncekiCarpan) * GirisCikisCarpan * -1);
                }
                //Yeni Stok Değerini Ekle

                if (stok.StokBirimId == item.BirimId)
                {
                    carpan = 1;
                }
                else
                {
                    //Birim Çevrimi Yapılacak
                    if (stok.Birim2Id == item.BirimId)
                    {
                        carpan = stok.Birim2Pay / stok.Birim2Payda;
                    }
                    else if (stok.Birim3Id == item.BirimId)
                    {
                        carpan = stok.Birim3Pay / stok.Birim3Payda;
                    }
                    else
                    {
                        carpan = 1;
                    }
                }
                stok.MevcutMiktar += Convert.ToDecimal(item.GirisCikisMiktar * Convert.ToDouble(carpan) * GirisCikisCarpan);
                _stokKartService.Update(stok);

                //item.Fis = null;
                if (item.Id > 0)
                    Update(item);
                else
                {
                    var fish = item;
                    fish.Fis = null;
                    Add(fish);
                }
            }

            // Silinen Kayıtları Sileceğiz.....
            var kayitliListe = _stokHareketDal.GetList(f => f.FisId == fis.Id).Select(f => f.Id).ToList();
            var silinecekler = kayitliListe.Except(fis.StokHareket.Select(f => f.Id).ToList()).ToList();
            foreach (var item in silinecekler)
            {
                Delete(GetById(item));
            }


        }

        public List<LotListesi> LotListesi(Expression<Func<LotListesi, bool>> filter = null)
        {
            return _stokHareketDal.LotListesi(filter);
        }
    }
}
