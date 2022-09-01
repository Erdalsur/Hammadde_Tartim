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
    public class IsEmirManager : IIsEmirService
    {
        IMakinaDal _makinaDal;
        IIsEmriDal _isEmriDal;
        IIsEmriOperasyonDal _isEmriOperasyonDal;
        IIsEmriOperasyonIslemDal _isEmriOperasyonIslemDal;
        IUrunReceteService _urunReceteService;
        IStokKartService _stokKartService;
        IStokHareketService _stokHareketService;
        public IsEmirManager(IIsEmriDal isEmriDal, IIsEmriOperasyonDal isEmriOperasyonDal, IIsEmriOperasyonIslemDal isEmriOperasyonIslemDal, IMakinaDal makinaDal,
            IUrunReceteService urunReceteService, IStokKartService stokKartService, IStokHareketService stokHareketService)
        {
            _isEmriDal = isEmriDal;
            _isEmriOperasyonDal = isEmriOperasyonDal;
            _isEmriOperasyonIslemDal = isEmriOperasyonIslemDal;
            _makinaDal = makinaDal;
            _urunReceteService = urunReceteService;
            _stokKartService = stokKartService;
            _stokHareketService = stokHareketService;
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(IsEmri ısEmri)
        {
            _isEmriDal.Delete(ısEmri);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<IsEmri> GetAll(Expression<Func<IsEmri, bool>> filter = null)
        {
            return _isEmriDal.GetMasterList(filter);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public IsEmri GetById(int id)
        {
            return _isEmriDal.Get(i => i.Id == id);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Makina> GetMakinalar(Expression<Func<Makina, bool>> filter = null)
        {
            return _makinaDal.GetList(filter);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        private Makina GetMakina(Expression<Func<Makina, bool>> filter = null)
        {
            return _makinaDal.GetList(filter).SingleOrDefault();
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [TransactionScopeAspect()]
        public void IsEmri_Add(IsEmri isEmri, int UstEmirNo = 0)
        {
            //Urun Recetesi Oku
            UrunRecete urunRecete = _urunReceteService.GetById(_urunReceteService.GetAll(u => u.StokId == isEmri.StokKartiId && u.IsActive == true).OrderByDescending(u => u.RevizyonNo).FirstOrDefault().Id);
            var _makina = GetMakina(s => s.Id == urunRecete.MakinaId);
            StokKarti stokKarti = _stokKartService.GetById(isEmri.StokKartiId);
            //Çarpan Ürün Recetesine göre hesaplayıor toplam için Miktar*carpan
            var carpanlar = carpanDegeri(urunRecete, isEmri.BirimId, stokKarti);
            bool AltEmirVar = false;
            isEmri.DonemId = UserSession.Donem.Id;
            isEmri.GenelDurumu = (int)Status.Yeni;
            //Uretim Emrini Kayıt işlemleri
            if (UstEmirNo > 0)
            {
                isEmri.BaglantiAdres = "Uretim";
                isEmri.BaglantiId = UstEmirNo;
                isEmri.GenelDurumu = (int)Status.OtomatikYeni;
            }
            isEmri.MakinaId = _makina.Id;

            isEmri.KayitTarihi = DateTime.Now;
            isEmri.KayitUserId = UserSession.CurrentUser.Id;
            isEmri.Carpan = carpanlar[0];
            var toplamCarpim = isEmri.Miktar * isEmri.Carpan;
            if (_makina.IsTartim)
            {
                isEmri.IsEmriTipi = 1;//Tartı için
                //Tarti İçin Operasyon Oluşturulacak Reçeteden
                foreach (UrunReceteDetay _receteDetay in urunRecete.UrunReceteDetay)
                {
                    //Alt Reçete Varmi Kontrol Et
                    var altRecete = _urunReceteService.GetAll(f => f.StokId == _receteDetay.StokKartiId && f.IsActive == true).OrderByDescending(u => u.RevizyonNo).FirstOrDefault();
                    if (altRecete != null)
                    {
                        AltEmirVar = true;
                    }
                    isEmri.IsEmriOperasyon.Add(new IsEmriOperasyon
                    {
                        DonemId = isEmri.DonemId,
                        UrunReceteId = _receteDetay.UrunReceteId,
                        UrunReceteDetayId = _receteDetay.Id,
                        //UrunRecete = _receteDetay,
                        StokKartiId = _receteDetay.StokKartiId,
                        Miktar = _receteDetay.Miktar * isEmri.Carpan * isEmri.Miktar,
                        BirimId = _receteDetay.StokBirimId,
                        Carpan = StokKartCarpanBul(_receteDetay.StokKartiId, _receteDetay.StokBirimId),
                        GenelDurum = (int)Status.Yeni,
                        MakinaId = isEmri.MakinaId,
                        KayitTarihi = DateTime.Now,
                        KayitUserId = UserSession.CurrentUser.Id
                    });
                }

            }
            else
            {
                isEmri.IsEmriTipi = 0;
                // Harici Operasyon Oluşturulabilir.
            }

            //Console.WriteLine(toplamCarpim.ToString());
            //Uretim Emri Kayit Edilecek ve Alt Reçete Hazirliği için Otomatik Emir Oluşturulacak
            isEmri = _isEmriDal.Add(isEmri);
            if (AltEmirVar)
            {
                //Alt Emir Var Receteyi Gonder Otomatik Kayitları oluştur
                AltIsEmri_Add(isEmri);
            }
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [TransactionScopeAspect()]
        private void AltIsEmri_Add(IsEmri isEmri)
        {
            int i = 1;
            foreach (IsEmriOperasyon operasyon in isEmri.IsEmriOperasyon)
            {

                //Recete Varmi Kontrol Et
                var altRecetem = _urunReceteService.GetAll(f => f.StokId == operasyon.StokKartiId && f.IsActive == true)
                    .OrderByDescending(u => u.RevizyonNo).FirstOrDefault();
                if (altRecetem != null)
                {
                    //Yeni Bir Emir Oluştur ve IsEmri_Add procedure çalıştır.
                    var yeniEmir = isEmri;
                    yeniEmir.IsEmriKodu = String.Format("{0} - Alt {1}", isEmri.IsEmriKodu, i);
                    yeniEmir.Aciklama = String.Format("{0} - Otomatik Emir Ref:{1}", isEmri.Aciklama, isEmri.IsEmriKodu);
                    yeniEmir.StokKartiId = operasyon.StokKartiId;
                    yeniEmir.BirimId = operasyon.BirimId;
                    yeniEmir.Miktar = operasyon.Miktar;
                    IsEmri_Add(yeniEmir, isEmri.Id);
                    i += 1;
                }
                altRecetem = null;

            }
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [TransactionScopeAspect()]
        public void Update(IsEmri isEmri)
        {

            isEmri.DegistirmeTarihi = DateTime.Now;
            isEmri.DegistirmeUserId = UserSession.CurrentUser.Id;
            if (isEmri.GenelDurumu != (int)Status.Tamam)
            {
                //Urun Recetesi Oku
                UrunRecete urunRecete = _urunReceteService.GetById(_urunReceteService.GetAll(u => u.StokId == isEmri.StokKartiId && u.IsActive == true).OrderByDescending(u => u.RevizyonNo).FirstOrDefault().Id);
                var _makina = GetMakina(s => s.Id == urunRecete.MakinaId);
                StokKarti stokKarti = _stokKartService.GetById(isEmri.StokKartiId);
                //Çarpan hesaplanacak ve Miktar değişiklikleri yapılacak
                var yeniCarpan = carpanDegeri(urunRecete, isEmri.BirimId, stokKarti);
                //Üretim Tamamlanmış 
                var isEmir_ORJ = _isEmriDal.Get(f => f.Id == isEmri.Id);
                var isEmir_Operasyon_ORJ = _isEmriOperasyonDal.GetList(f => f.IsEmriId == isEmri.Id);
                isEmri.Carpan = yeniCarpan[0];
                bool AltEmirVar = false;
                if (isEmir_ORJ.StokKartiId == isEmri.StokKartiId)
                {
                    //Stok Karti Değişmemiş Diğer Bilgileri kontrol et
                    if (isEmir_ORJ.BirimId == isEmri.BirimId)
                    {
                        //Sadece Miktar değişecek carpan aynı kalacak
                        if (isEmir_ORJ.Miktar == isEmri.Miktar)
                        {
                            //Miktar Aynı Diğer değişiklikleri kabul edilecek
                            if (isEmri.GenelDurumu == (int)Status.Yeni)
                                isEmri.GenelDurumu = (int)Status.DegisiklikVar;
                        }
                        else
                        {
                            foreach (var detay in isEmir_Operasyon_ORJ)
                            {
                                var receteDetayi_ORJ = _urunReceteService.GetDetayById(detay.UrunReceteDetayId);
                                detay.Miktar = receteDetayi_ORJ.Miktar * isEmir_ORJ.Carpan * isEmri.Miktar;
                                detay.DegistirmeTarihi = DateTime.Now;
                                detay.Carpan = StokKartCarpanBul(detay.StokKartiId, receteDetayi_ORJ.StokBirimId);
                                detay.DegistirmeUserId = UserSession.CurrentUser.Id;
                                if (detay.GenelDurum == (int)Status.Tamam)
                                {
                                    detay.IslemBitisTarihi = null;
                                    detay.GenelDurum = (int)Status.DegisiklikVar;
                                }

                                _isEmriOperasyonDal.Update(detay);
                            }

                        }

                    }
                    else
                    {
                        //Yeni çarpanla değerleri Güncelle
                        foreach (var detay in isEmir_Operasyon_ORJ)
                        {
                            var receteDetayi_ORJ = _urunReceteService.GetDetayById(detay.UrunReceteDetayId);
                            //Alt Reçete Varmi Kontrol Et
                            var altRecete = _urunReceteService.GetAll(f => f.StokId == receteDetayi_ORJ.StokKartiId && f.IsActive == true).OrderByDescending(u => u.RevizyonNo).FirstOrDefault();
                            if (altRecete != null)
                            {
                                AltEmirVar = true;
                            }
                            detay.Miktar = isEmri.Miktar * isEmri.Carpan * receteDetayi_ORJ.Miktar;
                            detay.Carpan = StokKartCarpanBul(detay.StokKartiId, receteDetayi_ORJ.StokBirimId);
                            detay.DegistirmeTarihi = DateTime.Now;
                            detay.DegistirmeUserId = UserSession.CurrentUser.Id;
                            if (detay.GenelDurum == (int)Status.Tamam)
                            {
                                detay.IslemBitisTarihi = null;
                                detay.GenelDurum = (int)Status.DegisiklikVar;
                            }

                            _isEmriOperasyonDal.Update(detay);
                        }

                    }

                }
                else
                {
                    //Stok Karti Değişmiş Operasyon İşlemi Yok ise Devem Ettir varsa Hata Ver;

                    bool isEmir_Operasyon_Islemleri_durumu = false;
                    foreach (var item in isEmir_Operasyon_ORJ)
                    {
                        var islemSayisi = _isEmriOperasyonIslemDal.GetList(f => f.IsEmriOperasyonId == item.Id).Count();
                        if (islemSayisi > 0)
                            isEmir_Operasyon_Islemleri_durumu = true;
                    }
                    if (isEmir_Operasyon_Islemleri_durumu == false)
                    {
                        //Herhangi bir işlem yok operasyonları sil yeni operasyon ekle Stok Kartına Gore
                        _isEmriOperasyonDal.TopluSil(isEmir_Operasyon_ORJ);
                        if (isEmri.IsEmriTipi == 1)
                        {
                            isEmri.IsEmriTipi = 1;//Tartı için
                                                  //Tarti İçin Operasyon Oluşturulacak Reçeteden
                            foreach (UrunReceteDetay _receteDetay in urunRecete.UrunReceteDetay)
                            {
                                //Alt Reçete Varmi Kontrol Et
                                var altRecete = _urunReceteService.GetAll(f => f.StokId == _receteDetay.StokKartiId && f.IsActive == true).OrderByDescending(u => u.RevizyonNo).FirstOrDefault();
                                if (altRecete != null)
                                {
                                    AltEmirVar = true;
                                }
                                isEmri.IsEmriOperasyon.Add(new IsEmriOperasyon
                                {
                                    DonemId = isEmri.DonemId,
                                    UrunReceteId = _receteDetay.Id,
                                    StokKartiId = _receteDetay.StokKartiId,
                                    Miktar = _receteDetay.Miktar * isEmri.Carpan * isEmri.Miktar,
                                    BirimId = _receteDetay.StokBirimId,
                                    Carpan = StokKartCarpanBul(_receteDetay.StokKartiId, _receteDetay.StokBirimId),
                                    GenelDurum = (int)Status.Yeni,
                                    MakinaId = isEmri.MakinaId,
                                    KayitTarihi = DateTime.Now,
                                    KayitUserId = UserSession.CurrentUser.Id
                                });
                            }

                        }
                    }
                }

                isEmri.IsEmriOperasyon = null;
                _isEmriDal.Update(isEmri);

                //Alt Emir Güncellemesi
                if (AltEmirVar)
                    AltIsEmri_Update(isEmri);
            }
            else
            {
                //Hata Messajı ile iuyarı değişiklik yapılamaz
                throw new Exception("İş Emri Bitirilmiş Değişiklik Yapamazsınız");
            }
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [TransactionScopeAspect()]
        private void AltIsEmri_Update(IsEmri isEmri)
        {
            var liste = _isEmriDal.GetList(f => f.IsEmriKodu.Contains(isEmri.IsEmriKodu));
            foreach (IsEmriOperasyon operasyon in isEmri.IsEmriOperasyon)
            {
                //Recete Varmi Kontrol Et
                var altRecetem = _urunReceteService.GetAll(f => f.StokId == operasyon.StokKartiId && f.IsActive == true)
                    .OrderByDescending(u => u.RevizyonNo).FirstOrDefault();
                if (altRecetem != null)
                {
                    //Önce Alt Emirleri bul ve onların miktarlarını güncelle
                    foreach (var item in liste)
                    {
                        if (item.Id != isEmri.Id)
                        {
                            item.Miktar = isEmri.Miktar;
                            Update(item);
                        }
                    }
                }
                altRecetem = null;
            }
        }
        
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<IsEmriOperasyon> GetOperasyonlarAll(Expression<Func<IsEmriOperasyon, bool>> filter = null)
        {
            return _isEmriOperasyonDal.GetList(filter);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<IsEmriOperasyonIslem> GetOperasyonIslemelerAll(Expression<Func<IsEmriOperasyonIslem, bool>> filter = null)
        {
            return _isEmriOperasyonIslemDal.GetList(filter);
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [TransactionScopeAspect()]
        public void UretimBaslat(IsEmriOperasyon secili_Operasyon)
        {
            if (secili_Operasyon.IslemBaslamaTarihi == null)
            {
                secili_Operasyon.DegistirmeTarihi =
                secili_Operasyon.IslemBaslamaTarihi = DateTime.Now;
                secili_Operasyon.GenelDurum = (int)Status.Hazirlaniyor;
                secili_Operasyon.IsEmriOperasyonIslem = null;
                secili_Operasyon.DegistirmeUserId = UserSession.CurrentUser.Id;
                _isEmriOperasyonDal.Update(secili_Operasyon);
            }
            var seciliIsEmri = _isEmriDal.Get(f => f.Id == secili_Operasyon.IsEmriId);
            if (seciliIsEmri.BaslamaTarihi == null)
            {
                seciliIsEmri.BaslamaTarihi = DateTime.Now;
                seciliIsEmri.GenelDurumu = (int)Status.Hazirlaniyor;
                seciliIsEmri.IsEmriOperasyon = null;
                _isEmriDal.Update(seciliIsEmri);
            }
        }
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [TransactionScopeAspect()]
        public void UretimBitir(IsEmriOperasyon secili_Operasyon)
        {
            if (secili_Operasyon.IslemBaslamaTarihi != null)
            {
                secili_Operasyon.DegistirmeTarihi =
                secili_Operasyon.IslemBitisTarihi = DateTime.Now;
                secili_Operasyon.GenelDurum = (int)Status.Tamam;
                secili_Operasyon.DegistirmeUserId = UserSession.CurrentUser.Id;
                secili_Operasyon.IsEmriOperasyonIslem = null;
                _isEmriOperasyonDal.Update(secili_Operasyon);
            }
            var isEmri = _isEmriDal.Get(f => f.Id == secili_Operasyon.IsEmriId);
            var operasyonlar = _isEmriOperasyonDal.GetList(f => f.IsEmriId == secili_Operasyon.IsEmriId);
            DateTime? skt = Convert.ToDateTime(operasyonlar.OrderBy(f => f.SonKullanimTarihi).Select(f => f.SonKullanimTarihi).First());
            if (skt == Convert.ToDateTime("01.01.0001 00:00:00"))
                skt = null;
            bool isEmriKapat = false;
            var count = operasyonlar.Where(f => f.GenelDurum != (int)Status.Tamam).Count();
            Fis fis;
            if (count == 0)
            {
                //Stok Giriş Fişi Düzenlenecek
                if (isEmri.FisId != null)
                {
                    //Var olan Fiş bulunup Değiştirilecek
                    int fisID = Convert.ToInt32(isEmri.FisId);
                    fis = _stokHareketService.GetByIdFis(fisID);
                    var fisDetay = _stokHareketService.GetAll(f => f.FisId == fis.Id).First();
                    fisDetay.GirisCikisMiktar = Convert.ToDouble(isEmri.Miktar);
                    fisDetay.BirimId = isEmri.BirimId;
                    fisDetay.DegistirmeTarihi =
                    fis.DegistirmeTarihi = DateTime.Now;
                    fisDetay.DegistirmeUserId =
                    fis.DegistirmeUserId = UserSession.CurrentUser.Id;
                    fis.StokHareket = null;
                    fis.StokHareket.Add(fisDetay);
                    _stokHareketService.UpdateFis(fis);
                }
                else
                {
                    fis = new Fis
                    {
                        FisKodu = String.Format("HT-{0}", isEmri.IsEmriKodu),
                        FisTuru = "",
                        BelgeNo = String.Format("HT-{0}", isEmri.IsEmriKodu),
                        KayitTarihi = DateTime.Now,
                        Tarih = DateTime.Now,
                        SirketId = UserSession.Sirket.Id,
                        DonemId = UserSession.Donem.Id,
                        KayitUserId = UserSession.CurrentUser.Id,
                        TeslimEden = UserSession.CurrentUser.FirstName + " " + UserSession.CurrentUser.LastName,
                        IskontoOrani = 0,
                        IskontoTutar = 0,
                        ToplamTutar = 0,
                        Aciklama = String.Format("{0} Kodlu Emir İle Hammdde Tartım Girişi", isEmri.IsEmriKodu)
                    };
                    var fisDetay = new StokHareket
                    {
                        SirketId = UserSession.Sirket.Id,
                        DonemId = UserSession.Donem.Id,
                        DepoId = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.Depo_VarsayilanDepo)),
                        StokId = isEmri.StokKartiId,
                        FisNo = String.Format("HT-{0}", isEmri.IsEmriKodu),
                        Tarih = DateTime.Now,
                        BaglantiId = isEmri.Id,
                        BaglantiSatirId = 0,
                        KayitTarihi = DateTime.Now,
                        KayitUserId = UserSession.CurrentUser.Id,
                        UretimTarihi = DateTime.Now,
                        KaliteKontrolNo = isEmri.PartiNo,
                        LotNo = isEmri.PartiNo,

                        SKT = skt,
                        AnalizSertifikasiGeldimi = (int)AnalizSerifikası.None,
                        AnalizDurumu = "",
                        Aciklama = String.Format("{0} Kodlu Emir İle Hammdde Tartım Girişi", isEmri.IsEmriKodu),
                        GirisCikis = ((int)StokGirisCikis.Giris).ToString(),
                        GirisCikisMiktar = Convert.ToDouble(isEmri.Miktar),
                        HareketTuru = ((int)HareketTuru.HammaddeTartim).ToString(),
                        BirimId = isEmri.BirimId
                    };
                    fis.StokHareket.Add(fisDetay);
                    fis = _stokHareketService.AddFis(fis, HareketTuru.HammaddeTartim);
                    isEmri.FisId = fis.Id;
                }
                isEmri.GenelDurumu = (int)Status.Tamam;
                isEmri.KapanisTarihi =
                isEmri.DegistirmeTarihi = DateTime.Now;
                isEmri.DegistirmeUserId = UserSession.CurrentUser.Id;
                _isEmriDal.Update(isEmri);
            }
        }

        private decimal[] carpanDegeri(UrunRecete urunRecete, int isEmriBirimId, StokKarti stokKarti)
        {
            decimal[] result = new decimal[3] { 1, 1, 1 };
            decimal carpan = 1;
            if (urunRecete.BirimId == isEmriBirimId)
            {
                result[0] = 1;
                result[1] = 1;
                result[2] = 1;
            }
            else
            if (stokKarti.StokBirimId == isEmriBirimId)
            {
                result[0] = 1 / (urunRecete.BirimPay / urunRecete.BirimPayda);
                result[1] = 1 / urunRecete.BirimPay;
                result[2] = 1 / urunRecete.BirimPayda;
                //result[0] = Convert.ToDecimal((1/1) / (urunRecete.BirimPay / urunRecete.BirimPayda));

            }
            else if (stokKarti.Birim2Id == isEmriBirimId)
            {
                var degerStok = (stokKarti.Birim2Pay / stokKarti.Birim2Payda);
                var degerRecete = (urunRecete.BirimPay / urunRecete.BirimPayda);
                result[0] = Math.Round((1 / ( degerStok / degerRecete)),6);
                result[1] = Math.Round((1 / degerStok),6);
                result[2] = Math.Round((1 / degerRecete),6);
                //result[0] = (stokKarti.Birim2Pay / stokKarti.Birim2Payda) / (urunRecete.BirimPay / urunRecete.BirimPayda);
            }
            else if (stokKarti.Birim3Id == isEmriBirimId)
            {
                result[0] = Math.Round((1 / ((stokKarti.Birim3Pay / stokKarti.Birim2Payda) / (urunRecete.BirimPay / urunRecete.BirimPayda))),6);
                result[1] = Math.Round((1 / (stokKarti.Birim3Pay / stokKarti.Birim3Payda)),6);
                result[2] = 1 / (urunRecete.BirimPay / urunRecete.BirimPayda);
                //result[0] = (stokKarti.Birim3Pay / stokKarti.Birim3Payda) / (urunRecete.BirimPay / urunRecete.BirimPayda);
            }


            return result;
        }
        private decimal StokKartCarpanBul(int stokKartId, int hedefBirimId)
        {
            decimal carpan = 1;
            var stok = _stokKartService.GetById(stokKartId);
            if (stok.StokBirimId == hedefBirimId)
                carpan = 1;
            else if (stok.Birim2Id == hedefBirimId)
            {
                carpan = (stok.Birim2Pay / stok.Birim2Payda);
            }
            else if (stok.Birim3Id == hedefBirimId)
            {
                carpan = (stok.Birim3Pay / stok.Birim3Payda);
            }

            return carpan;
        }
        public decimal TartimCarpaniBul(int stokKartiId, int KaynakBirimi, int HedefBirim)
        {
            var KaynakCarpan = StokKartCarpanBul(stokKartiId, KaynakBirimi);
            var HedefCarpan = StokKartCarpanBul(stokKartiId, HedefBirim);
            decimal sonuc = 1;
            sonuc = 1 / (HedefCarpan / KaynakCarpan);
            return sonuc;
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [TransactionScopeAspect()]
        public IsEmriOperasyonIslem OperasyonEkle(IsEmriOperasyonIslem operasyonIslem, bool Update = false)
        {
            operasyonIslem.TartimBrut = operasyonIslem.TartimDara + operasyonIslem.TartimMiktar;
            if (!Update)
            {
                // Kayıt İşlemi
                operasyonIslem.DonemId = UserSession.Donem.Id;
                operasyonIslem.KayitUserId = UserSession.CurrentUser.Id;
                operasyonIslem.KayitTarihi = DateTime.Now;
                operasyonIslem = _isEmriOperasyonIslemDal.Add(operasyonIslem);

            }
            else
            {
                operasyonIslem.DegistirmeUserId = UserSession.CurrentUser.Id;
                operasyonIslem.DegistirmeTarihi = DateTime.Now;
                operasyonIslem = _isEmriOperasyonIslemDal.Update(operasyonIslem);
            }
            var operasyon = _isEmriOperasyonDal.Get(f => f.Id == operasyonIslem.IsEmriOperasyonId);
            var isEmri = _isEmriDal.Get(f => f.Id == operasyon.IsEmriId);
            //Sadece Miktar Düzeltemesi Yap
            var carpan = TartimCarpaniBul(operasyon.StokKartiId, Convert.ToInt32(operasyonIslem.TartimBirim), operasyon.BirimId);
            operasyon.ReelMiktar += operasyonIslem.TartimMiktar * carpan;
            //Referans ve lot düzeltmesi yap
            var islemListesi = _isEmriOperasyonIslemDal.GetList(f => f.IsEmriOperasyonId == operasyon.Id);
            var Lots = islemListesi.Select(l => l.TartimLotNo).Distinct();
            var Refs = islemListesi.Select(l => l.TartimReferansNo).Distinct();
            var tett = islemListesi.Where(f => f.SonKullanimTarihi != null).OrderBy(f => f.SonKullanimTarihi).Select(l => l.SonKullanimTarihi).Distinct();
            operasyon.LotNo = String.Join(", ", Lots.ToArray());
            operasyon.ReferansNo = String.Join(", ", Refs.ToArray());
            if (tett.Count() > 0)
                operasyon.SonKullanimTarihi = tett.First();
            operasyon.DegistirmeTarihi = DateTime.Now;
            operasyon.DegistirmeUserId = UserSession.CurrentUser.Id;
            operasyon.IsEmriOperasyonIslem = null;
            //Çıkış Fişi hazırlanacak
            //Operasyon Id ile StokHareket Tablosu BaglantıId bağlı
            //İşlemId ile Stokhareket Tablosu BaglantıSarıId Baglı olacak
            var HareketListe = _stokHareketService.GetAll(f => f.BaglantiId == operasyon.Id);
            if (HareketListe == null || HareketListe.Count() == 0)
            {
                //Fis Oluşmamış Yeni Fis
                var fisim = new Fis
                {
                    FisKodu = String.Format("HT-{0}-{1}", isEmri.IsEmriKodu, _stokKartService.GetById(operasyon.StokKartiId).Kod),
                    FisTuru = "",
                    BelgeNo = String.Format("HT-{0}-{1}", isEmri.IsEmriKodu, _stokKartService.GetById(operasyon.StokKartiId).Kod),
                    KayitTarihi = DateTime.Now,
                    Tarih = DateTime.Now,
                    SirketId = UserSession.Sirket.Id,
                    DonemId = UserSession.Donem.Id,
                    KayitUserId = UserSession.CurrentUser.Id,
                    TeslimEden = UserSession.CurrentUser.FirstName + " " + UserSession.CurrentUser.LastName,
                    IskontoOrani = 0,
                    IskontoTutar = 0,
                    ToplamTutar = 0,
                    Aciklama = String.Format("{0} Kodlu Emir İle {1} Hammdde Tartım Çıkışı", isEmri.IsEmriKodu, _stokKartService.GetById(operasyon.StokKartiId).Ad)

                };
                var fisDetay = new StokHareket
                {
                    SirketId = UserSession.Sirket.Id,
                    DonemId = UserSession.Donem.Id,
                    DepoId = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.Depo_VarsayilanDepo)),
                    StokId = operasyon.StokKartiId,

                    FisNo = String.Format("HT-{0}", isEmri.IsEmriKodu),
                    Tarih = DateTime.Now,
                    BaglantiId = operasyon.Id,
                    BaglantiSatirId = operasyonIslem.Id,
                    KayitTarihi = DateTime.Now,
                    KayitUserId = UserSession.CurrentUser.Id,
                    UretimTarihi = DateTime.Now,
                    LotNo = operasyonIslem.TartimLotNo,
                    SKT = operasyon.SonKullanimTarihi,
                    AnalizSertifikasiGeldimi = (int)AnalizSerifikası.None,
                    AnalizDurumu = "",
                    Aciklama = String.Format("{0} Kodlu Emir İle Hammdde Tartım Çıkışı", isEmri.IsEmriKodu),
                    GirisCikis = ((int)StokGirisCikis.Cikis).ToString(),
                    GirisCikisMiktar = Convert.ToDouble(operasyonIslem.TartimMiktar),
                    HareketTuru = ((int)HareketTuru.HammaddeTartim).ToString(),
                    BirimId = Convert.ToInt32(operasyonIslem.TartimBirim)
                };
                fisim.StokHareket.Add(fisDetay);
                fisim = _stokHareketService.AddFis(fisim, HareketTuru.HammaddeTartim);
                operasyon.FisId = fisim.Id;
            }
            else
            {
                //Fis Var Detay varmı kontrol edilecek
                var fisim = _stokHareketService.GetByIdFis(HareketListe.First().FisId);
                var Detayim = HareketListe.FirstOrDefault(f => f.BaglantiSatirId == operasyonIslem.Id);
                if (Detayim == null)
                {
                    //Fişe yeni Hareket Eklecek
                    var fisDetay = new StokHareket
                    {
                        SirketId = UserSession.Sirket.Id,
                        DonemId = UserSession.Donem.Id,
                        DepoId = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.Depo_VarsayilanDepo)),
                        StokId = operasyon.StokKartiId,
                        LotNo = operasyonIslem.TartimLotNo,
                        FisNo = String.Format("HT-{0}", isEmri.IsEmriKodu),
                        Tarih = DateTime.Now,
                        BaglantiId = operasyon.Id,
                        BaglantiSatirId = operasyonIslem.Id,
                        KayitTarihi = DateTime.Now,
                        KayitUserId = UserSession.CurrentUser.Id,
                        UretimTarihi = DateTime.Now,
                        SKT = operasyon.SonKullanimTarihi,
                        AnalizSertifikasiGeldimi = (int)AnalizSerifikası.None,
                        AnalizDurumu = "",
                        Aciklama = String.Format("{0} Kodlu Emir İle Hammdde Tartım Çıkışı", isEmri.IsEmriKodu),
                        GirisCikis = ((int)StokGirisCikis.Cikis).ToString(),
                        GirisCikisMiktar = Convert.ToDouble(operasyonIslem.TartimMiktar),
                        HareketTuru = ((int)HareketTuru.HammaddeTartim).ToString(),
                        BirimId = Convert.ToInt32(operasyonIslem.TartimBirim)
                    };
                    fisim.StokHareket = HareketListe;
                    fisim.StokHareket.Add(fisDetay);

                }
                else
                {
                    //Fis Hareketi Var Güncellenecek
                    var detayorj = Detayim;
                    Detayim.GirisCikisMiktar = Convert.ToDouble(operasyonIslem.TartimMiktar);
                    Detayim.BirimId = Convert.ToInt32(operasyonIslem.TartimBirim);
                    fisim.StokHareket = HareketListe;
                    fisim.StokHareket.Remove(detayorj);
                    fisim.StokHareket.Add(Detayim);
                }
                _stokHareketService.UpdateFis(fisim);
            }
            operasyon = _isEmriOperasyonDal.Update(operasyon);
            return operasyonIslem;
        }

        public List<HammaddeKontrolFoyu> HammaddeKontrolFoyuOlustur(int emirId)
        {
            return _isEmriDal.HammaddeKontrolFoyuOlustur(emirId);
        }

        public List<IsEmriIhtiyacListesi> IsEmriIhtiyacListesiHazirla(int StokId, int HedefBirimId, decimal Miktar)
        {
            //Urun Recetesi Oku
            UrunRecete urunRecete = _urunReceteService.GetById(_urunReceteService.GetAll(u => u.StokId == StokId && u.IsActive == true).OrderByDescending(u => u.RevizyonNo).FirstOrDefault().Id);
            StokKarti stokKarti = _stokKartService.GetById(StokId);
            //Çarpan Ürün Recetesine göre hesaplayıor toplam için Miktar*carpan
            var carpanlar = carpanDegeri(urunRecete, HedefBirimId, stokKarti);
            var carpanMiktari =TartimCarpaniBul(StokId,HedefBirimId,urunRecete.BirimId)*Miktar;
            var carpan = Math.Round((1/carpanlar[0]) * Miktar,6);
            return _isEmriDal.IsEmriIhtiyacListesiOlustur(urunRecete.Id,Math.Round(carpanMiktari,6));
        }

        public List<LotListesi> LotListesi(Expression<Func<LotListesi, bool>> filter = null)
        {
            return _stokHareketService.LotListesi(filter);
        }
    }
}
