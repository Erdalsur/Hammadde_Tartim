using Sanmark.Core.Aspects.Postsharp.CacheAspects;
using Sanmark.Core.Aspects.Postsharp.TransactionAspects;
using Sanmark.Core.CrossCuttingConcerns.Caching.Microsoft;
using Sanmark.Core.Utilities;
using Sanmark.Core.Utilities.Tipler;
using Sanmark.Core.Utilities.Win.Infrastructure;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Entities.ComplexTypes.Uretim;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Entities.Concrete.Uretim;
using Sanmark.Erp.Framework.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Concrete.Managers
{
    public class UretimEmirManager : IUretimService
    {
        IUretimEmirleriDal _uretimEmirleriDal;
        IUretimEmirDetaylariDal _uretimEmirDetaylariDal;
        IUretimTartimlariDal _uretimTartimlariDal;
        IUrunAgaciService _urunAgaciService;
        IMakinaDal _makinaDal;
        IStokKartService _stokKartService;
        IStokHareketService _stokHareketService;
        IDepoService _depoService;

        public UretimEmirManager(IUretimEmirleriDal uretimEmirleriDal, IUretimEmirDetaylariDal uretimEmirDetaylariDal, IMakinaDal makinaDal,
            IUretimTartimlariDal uretimTartimlariDal, IStokHareketService stokHareketService, IDepoService depoService,
            IUrunAgaciService urunAgaciService, IStokKartService stokKartService)
        {
            _urunAgaciService = urunAgaciService;
            _uretimEmirleriDal = uretimEmirleriDal;
            _uretimEmirDetaylariDal = uretimEmirDetaylariDal;
            _makinaDal = makinaDal;
            _uretimTartimlariDal = uretimTartimlariDal;
            _stokKartService = stokKartService;
            _stokHareketService = stokHareketService;
            _depoService = depoService;
        }

        //[FluentValidationAspect(typeof(StokKartValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [TransactionScopeAspect()]
        public void UretimEmri_Kayit(UretimEmirleri uretimEmirleri, int UstEmirNo = 0)
        {
            bool AltEmirVar = false;
            //Uretim Emrini Kayıt işlemleri
            if (UstEmirNo == 0)
                uretimEmirleri.Durumu = (int)Status.Yeni;
            else
                uretimEmirleri.Durumu = (int)Status.OtomatikYeni;
            uretimEmirleri.KayitTarihi =
            uretimEmirleri.Tarih = DateTime.Now;
            uretimEmirleri.KayitUserId = UserSession.CurrentUser.Id;
            //uretimEmirleri.AltUretimId = 0;
            uretimEmirleri.UstUretimId = UstEmirNo;
            uretimEmirleri.UretimTipi = 1;//Tartı için
            //Urun Reçetesi Okunacak
            UrunAgaclari UrunRecetesi = _urunAgaciService.GetById(_urunAgaciService.GetAll(u => u.StokId == uretimEmirleri.UrunId).OrderByDescending(u => u.RevizyonNo).FirstOrDefault().Id);
            if (uretimEmirleri.AltUretimId == 0 || uretimEmirleri.AltUretimId == null)
            {
                uretimEmirleri.AltUretimId = UrunRecetesi.Id;
            }

            //Urun Reçetesi İçeeriye aktarılacak
            UrunRecetesi = _urunAgaciService.GetById(uretimEmirleri.AltUretimId);
            foreach (UrunAgacSatirlari urunAgacSatirlari in UrunRecetesi.UrunAgacSatirlari)
            {

                if (_urunAgaciService.GetAll(u => u.StokId == urunAgacSatirlari.UrunId).OrderByDescending(u => u.RevizyonNo).Count() > 0)
                {
                    //Alt Reçete var Dikkat Yeni Bir İş Emri Aç
                    //Farklı bir çekirdekte yapılacak
                    AltEmirVar = true;
                }
                uretimEmirleri.UretimEmirDetaylari.Add(new UretimEmirDetaylari
                {
                    UrunId = urunAgacSatirlari.UrunId,
                    IslemBaslamaTarihi = DateTime.Now,
                    Miktar = MiktarHesapla(urunAgacSatirlari.Miktar, uretimEmirleri.Miktar, urunAgacSatirlari.UrunId),
                    KayitTarihi = DateTime.Now,
                    KayitUserId = UserSession.CurrentUser.Id,
                    UretimDurumu = 1//Hazirlanıyor


                });
            }
            var uretimEmirleri2 = _uretimEmirleriDal.Add(uretimEmirleri);
            if (AltEmirVar)
                UretimEmriAltKayit(uretimEmirleri2);
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [TransactionScopeAspect()]
        private void UretimEmriAltKayit(UretimEmirleri uretimEmirleri)
        {
            uretimEmirleri.KayitTarihi = DateTime.Now;
            uretimEmirleri.KayitUserId = UserSession.CurrentUser.Id;
            UrunAgaclari Recete;
            decimal uretilecekMiktar = 0;
            UrunAgaclari UrunRecetesi = null;
            foreach (UretimEmirDetaylari uretimEmirDetaylari in uretimEmirleri.UretimEmirDetaylari)
            {
                uretilecekMiktar = uretimEmirDetaylari.Miktar;
                //Reçete Satırındaki ürünün reçetesi olup olmadığı kontrol edilecek SON REÇETE BİLGİSİ ÇEKİLECEK
                var recetem = _urunAgaciService.GetAll(u => u.StokId == uretimEmirDetaylari.UrunId)
                    .OrderByDescending(u => u.RevizyonNo).FirstOrDefault();
                //int urunid = _urunAgaciService.GetAll(u => u.StokId == uretimEmirDetaylari.UrunId)
                //    .OrderByDescending(u => u.RevizyonNo).FirstOrDefault().Id;
                if (recetem != null)
                    UrunRecetesi = _urunAgaciService.GetById(recetem.Id);
                if (UrunRecetesi != null)
                {
                    var AltEmir = (new UretimEmirleri
                    {
                        DonemId = uretimEmirleri.DonemId,
                        Aciklama = uretimEmirleri.Aciklama + "  - OTOMATİK EMİR" + " - Ref:" + uretimEmirleri.Id,
                        MakinaId = UrunRecetesi.MakinaId,
                        UrunId = UrunRecetesi.StokId,
                        SeriNo = uretimEmirleri.SeriNo,
                        UstUretimId = uretimEmirleri.Id,
                        KayitTarihi = DateTime.Now,
                        KayitUserId = UserSession.CurrentUser.Id,
                        Miktar = uretimEmirDetaylari.Miktar

                    });
                    UretimEmri_Kayit(AltEmir, AltEmir.UstUretimId);

                }
                recetem =
                UrunRecetesi = null;
            }
        }
        private decimal MiktarHesapla(decimal UrunAgacMiktari, decimal UretimMiktari, int UrunId)
        {
            var Miktar = UrunAgacMiktari * UretimMiktari;
            //Stok Seviyesi Kontrolü Yapılacak
            var urunkart = _stokKartService.GetById(UrunId);
            if (urunkart.MevcutMiktar >= Miktar)
            {
                return Miktar;
            }
            return Miktar;
            //Hata verilecek
            throw new Exception("Yeterli Stok Yok!");
            //return Miktar;

        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(UretimEmirleri uretimEmirleri)
        {
            _uretimEmirleriDal.Delete(uretimEmirleri);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<UretimEmirleri> GetAll(Expression<Func<UretimEmirleri, bool>> filter = null)
        {
            return _uretimEmirleriDal.GetList(filter);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public UretimEmirleri GetById(int id)
        {
            return _uretimEmirleriDal.Get(i => i.Id == id);
        }
        //[FluentValidationAspect(typeof(StokKartValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Update(UretimEmirleri uretimEmirleri)
        {
            uretimEmirleri.DegistirmeTarihi = DateTime.Now;
            uretimEmirleri.DegistirmeUserId = UserSession.CurrentUser.Id;
            _uretimEmirleriDal.Update(uretimEmirleri);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Makina> GetMakinalar(Expression<Func<Makina, bool>> filter = null)
        {
            return _makinaDal.GetList(filter);
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [TransactionScopeAspect()]
        public void UretimEmir_Duzelt(UretimEmirleri uretimEmirleri)
        {
            var UretimEmriORJ = GetById(uretimEmirleri.Id);
            var UretimEmriDetayORJ = _uretimEmirDetaylariDal.GetList(f => f.UretimEmirId == uretimEmirleri.Id);
            foreach (UretimEmirDetaylari emirDetaylari in UretimEmriDetayORJ)
            {
                var YeniDetay = emirDetaylari;
                YeniDetay.Miktar = (emirDetaylari.Miktar / UretimEmriORJ.Miktar) * uretimEmirleri.Miktar;
                YeniDetay.DegistirmeTarihi = DateTime.Now;
                YeniDetay.DegistirmeUserId = UserSession.CurrentUser.Id;
                _uretimEmirDetaylariDal.Update(YeniDetay);
                var recetem = _urunAgaciService.GetAll(p => p.StokId == YeniDetay.UrunId).OrderByDescending(u => u.RevizyonNo).FirstOrDefault();
                if (recetem != null)
                    if (_urunAgaciService.GetById(recetem.Id) != null)
                    {
                        //Ürünün alt emiri var
                        var altemir = _uretimEmirleriDal.Get(p => p.UstUretimId == uretimEmirleri.Id);
                        if (YeniDetay.Miktar != altemir.Miktar)
                        {
                            altemir.Miktar = YeniDetay.Miktar;
                            if (altemir.UretimBaslangicTarihi != null)
                                altemir.Durumu = (int)Status.DegisiklikVar;
                            if (altemir.UretimBitisTarihi != null)
                            {
                                altemir.UretimBitisTarihi = null;
                                altemir.Durumu = (int)Status.EksikUretim;
                            }
                            altemir.DegistirmeTarihi = DateTime.Now;
                            altemir.DegistirmeUserId = UserSession.CurrentUser.Id;
                            UretimEmir_Duzelt(altemir);
                        }
                    }
            }
            if (uretimEmirleri.UretimBaslangicTarihi != null)
                uretimEmirleri.Durumu = (int)Status.DegisiklikVar;
            if (uretimEmirleri.UretimBitisTarihi != null)
            {
                uretimEmirleri.UretimBitisTarihi = null;
                uretimEmirleri.Durumu = (int)Status.EksikUretim;
            }
            uretimEmirleri.DegistirmeUserId = UserSession.CurrentUser.Id;
            uretimEmirleri.DegistirmeTarihi = DateTime.Now;
            Update(uretimEmirleri);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<UretimEmirDetaylari> UretimEmirDetaylari(int UretimId)
        {
            return _uretimEmirDetaylariDal.GetList(d => d.UretimEmirId == UretimId);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public UretimEmirDetaylari GetDetaylari(int id)
        {
            return _uretimEmirDetaylariDal.Get(d => d.Id == id);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<UretimTartimlari> GetTartimAll(Expression<Func<UretimTartimlari, bool>> filter = null)
        {
            return _uretimTartimlariDal.GetList(filter);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public UretimTartimlari GetTartimBy(int id)
        {
            return _uretimTartimlariDal.Get(f => f.Id == id);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<HammaddeKontrolFoyu> HammaddeKontrolFoyuOlustur(int id)
        {
            return _uretimEmirDetaylariDal.GetHammaddeKontrol(id);
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [TransactionScopeAspect()]
        public UretimEmirDetaylari UretimDetay_Kayit(UretimEmirDetaylari uretimEmirDetaylari)
        {
            if (uretimEmirDetaylari.Id == 0)
            {
                uretimEmirDetaylari.KayitTarihi = DateTime.Now;
                uretimEmirDetaylari.KayitUserId = UserSession.CurrentUser.Id;
                return _uretimEmirDetaylariDal.Add(uretimEmirDetaylari);
            }
            else
            {
                uretimEmirDetaylari.ReelMiktar = uretimEmirDetaylari.UretimTartimlari.Sum(f => f.Miktar);
                var Lots = uretimEmirDetaylari.UretimTartimlari.Select(l => l.LotNo).Distinct();
                uretimEmirDetaylari.LotNo = String.Join(", ", Lots.ToArray());
                var SKK = uretimEmirDetaylari.UretimTartimlari.Select(f => f.SKT).OrderBy(f => f.Value).FirstOrDefault();
                uretimEmirDetaylari.SonKullanimTarihi = SKK.Value;
                var Refs = uretimEmirDetaylari.UretimTartimlari.Select(l => l.ReferansNo).Distinct();
                uretimEmirDetaylari.ReferansNo = String.Join(", ", Refs.ToArray());
                if (uretimEmirDetaylari.ReelMiktar >= uretimEmirDetaylari.Miktar)
                {
                    uretimEmirDetaylari.IslemBitisTarihi = DateTime.Now;
                    uretimEmirDetaylari.UretimDurumu = (int)Status.Tamam;
                }
                else
                    uretimEmirDetaylari.UretimDurumu = (int)Status.Hazirlaniyor;
                uretimEmirDetaylari.DegistirmeTarihi = DateTime.Now;
                uretimEmirDetaylari.DegistirmeUserId = UserSession.CurrentUser.Id;
                return _uretimEmirDetaylariDal.Update(uretimEmirDetaylari);
            }
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [TransactionScopeAspect()]
        public UretimTartimlari Tartim_Kayit(UretimTartimlari uretimTartim)
        {
            if (uretimTartim.Id == 0)
            {
                uretimTartim.KayitTarihi = DateTime.Now;
                uretimTartim.KayitUserId = UserSession.CurrentUser.Id;
                var tartim = _uretimTartimlariDal.Add(uretimTartim);
                ////Stok Miktarını Düş
                //var StokKarti = _stokKartService.GetById(uretimTartim.UrunId);
                //StokKarti.MevcutMiktar -= uretimTartim.Miktar;
                //_stokKartService.Update(StokKarti);
                // Stok Hareket Yaz
                //StokHareket stokHareket = new StokHareket();
                //stokHareket.Tarih =
                //stokHareket.DegistirmeTarihi =
                //    stokHareket.KayitTarihi = DateTime.Now;
                //stokHareket.StokId = uretimTartim.UrunId;
                //stokHareket.SirketId = StokKarti.SirketId;
                //var sayi = _stokHareketService.GetAll(f => f.FisNo.StartsWith("T")).Count();
                //stokHareket.FisNo = string.Format("{0}{1:0000000}", "T", ++sayi); //"T" + (sayi+1).ToString();
                //stokHareket.HareketTuru = ((int)HareketTuru.HammaddeTartim).ToString();
                //stokHareket.KaliteKontrolNo = uretimTartim.ReferansNo;
                //stokHareket.GirisCikisMiktar = Convert.ToDouble(uretimTartim.Miktar);
                //stokHareket.GirisCikis = ((int)StokGirisCikis.Cikis).ToString();
                //var EmirDetayId = _uretimEmirDetaylariDal.Get(f => f.Id == uretimTartim.UretimEmirDetayId).UretimEmirId;
                //stokHareket.DonemId = _uretimEmirleriDal.Get(a => a.Id == EmirDetayId).DonemId;
                //stokHareket.BaglantiId = EmirDetayId;
                //stokHareket.BaglantiSatirId = tartim.Id;
                //stokHareket.DepoId = _depoService.GetAll(f => f.SirketId == StokKarti.SirketId).FirstOrDefault().Id;
                //stokHareket.KayitUserId = UserSession.CurrentUser.Id;
                //stokHareket.KayitTarihi = DateTime.Now;
                //_stokHareketService.Add(stokHareket);
                return tartim;
            }
            else
            {
                ////Stok Miktarını Düş
                //var StokKarti = _stokKartService.GetById(uretimTartim.UrunId);
                //var oncekiStokMiktar = _uretimEmirleriDal.Get(f => f.Id == uretimTartim.Id).Miktar;
                //StokKarti.MevcutMiktar += oncekiStokMiktar;
                //StokKarti.MevcutMiktar -= uretimTartim.Miktar;
                //_stokKartService.Update(StokKarti);

                //var _stokharekti = _stokHareketService.GetById(_stokHareketService.GetAll(g => g.BaglantiSatirId == uretimTartim.Id).FirstOrDefault().Id);
                //if (_stokharekti.GirisCikisMiktar != Convert.ToDouble(uretimTartim.Miktar))
                //{
                //    var oncekideger = _stokharekti.GirisCikisMiktar;
                //    var fark = oncekideger - Convert.ToDouble(uretimTartim.Miktar);
                //    _stokharekti.GirisCikisMiktar = Convert.ToDouble(uretimTartim.Miktar);
                //    _stokharekti.DegistirmeTarihi = DateTime.Now;
                //    _stokharekti.DegistirmeUserId = UserSession.CurrentUser.Id;

                //    _stokHareketService.Update(_stokharekti);
                //    var _stokKarti = _stokKartService.GetById(uretimTartim.UrunId);
                //    _stokKarti.MevcutMiktar += Convert.ToDecimal(fark);
                //    _stokKartService.Update(_stokKarti);
                //}
                uretimTartim.DegistirmeUserId = UserSession.CurrentUser.Id;
                uretimTartim.DegistirmeTarihi = DateTime.Now;
                return _uretimTartimlariDal.Update(uretimTartim);
            }
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [TransactionScopeAspect()]
        public void UretimBitir(UretimEmirleri uretimEmirleri)
        {
            if (uretimEmirleri.UretimBitisTarihi == null)
            {
                //Stok Kartı Sayısıda Arttırılacak
                //var stokKart = _stokKartService.GetById(uretimEmirleri.UrunId);
                //stokKart.MevcutMiktar += uretimEmirleri.Miktar;
                //_stokKartService.Update(stokKart);
                //Stok Hareketi Yeni Açılacak
                //StokHareket stokHareket = new StokHareket();
                //stokHareket.Tarih =
                //stokHareket.DegistirmeTarihi =
                //    stokHareket.KayitTarihi = DateTime.Now;
                //stokHareket.StokId = uretimEmirleri.UrunId;
                //stokHareket.SirketId = stokKart.SirketId;
                //var sayi = _stokHareketService.GetAll(f => f.FisNo.StartsWith("T")).Count();
                //stokHareket.FisNo = string.Format("{0}{1:0000000}", "T", ++sayi); //"T" + (sayi+1).ToString();
                //stokHareket.HareketTuru = ((int)HareketTuru.HammaddeTartim).ToString();
                ////stokHareket.KaliteKontrolNo =;
                //stokHareket.GirisCikisMiktar = Convert.ToDouble(uretimEmirleri.Miktar);
                //stokHareket.GirisCikis = ((int)StokGirisCikis.Giris).ToString();
                //stokHareket.DonemId = uretimEmirleri.DonemId;
                //stokHareket.BaglantiId = uretimEmirleri.Id;
                //stokHareket.BaglantiSatirId = 0;
                //stokHareket.DepoId = _depoService.GetAll(f => f.SirketId == stokKart.SirketId).FirstOrDefault().Id;
                //stokHareket.KayitUserId = UserSession.CurrentUser.Id;
                //stokHareket.KayitTarihi = DateTime.Now;
                //stokHareket.KaliteKontrolNo = uretimEmirleri.SeriNo;
                //_stokHareketService.Add(stokHareket);

                uretimEmirleri.UretimBitisTarihi = DateTime.Now;
                uretimEmirleri.Durumu = (int)Status.Tamam;
                uretimEmirleri.DegistirmeUserId = UserSession.CurrentUser.Id;
                uretimEmirleri.DegistirmeTarihi = DateTime.Now;
                _uretimEmirleriDal.Update(uretimEmirleri);
            }
            else
            {
                ////Stok Miktarını Düş
                //var StokKarti = _stokKartService.GetById(uretimEmirleri.UrunId);
                //var oncekiStokMiktar = _uretimEmirleriDal.Get(f => f.Id == uretimEmirleri.Id).Miktar;
                //StokKarti.MevcutMiktar += oncekiStokMiktar;
                //StokKarti.MevcutMiktar -= uretimEmirleri.Miktar;
                //_stokKartService.Update(StokKarti);
                //Stok HAreketi Değiştirme
                //var _stokharekti = _stokHareketService.GetById(_stokHareketService.GetAll(g => g.BaglantiId == uretimEmirleri.Id && g.BaglantiSatirId == 0).FirstOrDefault().Id);
                //if (_stokharekti.GirisCikisMiktar != Convert.ToDouble(uretimEmirleri.Miktar))
                //{
                //    var oncekideger = _stokharekti.GirisCikisMiktar;
                //    var fark = oncekideger - Convert.ToDouble(uretimEmirleri.Miktar);
                //    _stokharekti.GirisCikisMiktar = Convert.ToDouble(uretimEmirleri.Miktar);
                //    _stokharekti.DegistirmeTarihi = DateTime.Now;
                //    _stokharekti.DegistirmeUserId = UserSession.CurrentUser.Id;
                //    _stokharekti.KaliteKontrolNo = uretimEmirleri.SeriNo;
                //    _stokHareketService.Update(_stokharekti);
                //    var _stokKarti = _stokKartService.GetById(uretimEmirleri.UrunId);
                //    _stokKarti.MevcutMiktar += Convert.ToDecimal(fark);
                //    _stokKartService.Update(_stokKarti);
                //}

                uretimEmirleri.UretimBitisTarihi = DateTime.Now;
                uretimEmirleri.Durumu = (int)Status.Tamam;
                uretimEmirleri.DegistirmeUserId = UserSession.CurrentUser.Id;
                uretimEmirleri.DegistirmeTarihi = DateTime.Now;
                _uretimEmirleriDal.Update(uretimEmirleri);
            }
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [TransactionScopeAspect()]
        public void UretimBaslat(UretimEmirleri uretimEmirleri)
        {
            if (uretimEmirleri.UretimBaslangicTarihi == null)
            {
                uretimEmirleri.UretimBaslangicTarihi = DateTime.Now;
                uretimEmirleri.Durumu = (int)Status.Hazirlaniyor;
                uretimEmirleri.DegistirmeTarihi = DateTime.Now;
                uretimEmirleri.DegistirmeUserId = UserSession.CurrentUser.Id;
                _uretimEmirleriDal.Update(uretimEmirleri);
            }

        }
    }
}
