using Sanmark.Core.DataAccess.EntityFramework;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Entities.ComplexTypes.Uretim;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Entities.Concrete.Uretim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Sanmark.Erp.Data.Concrete.EntityFramework
{
    public class EfIsEmriDal : EfEntityRepositoryBase<IsEmri, ErpContext>, IIsEmriDal
    {
        public List<IsEmri> GetMasterList(Expression<Func<IsEmri, bool>> filter = null)
        {
            using (var context = new ErpContext())
            {
                //List<IsEmri> result;
                //if (filter==null)
                //{
                //    context.IsEmriOperasyonlari.Include("IsEmriOperasyonIslem");
                //    context.IsEmirleri.Include("IsEmriOperasyon").ToList();
                //}
                //else
                //{

                //}
                context.IsEmriOperasyonlari.Include("IsEmriOperasyonIslem");
                return filter == null
                    ? context.IsEmirleri.Include("IsEmriOperasyon").ToList()
                    : context.IsEmirleri.Include("IsEmriOperasyon").Where(filter).ToList();
            }
        }

        public List<HammaddeKontrolFoyu> HammaddeKontrolFoyuOlustur(int emirId)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = from p in context.IsEmriOperasyonlari
                             where p.IsEmriId == emirId
                             join sk in context.StokKartis on p.StokKartiId equals sk.Id
                             join birim in context.StokBirims on p.BirimId equals birim.Id
                             join t in context.IsEmriOperasyonIslemleri on p.Id equals (int?)t.IsEmriOperasyonId into operasyonlar

                             from t2 in operasyonlar.Distinct().DefaultIfEmpty()
                                 //join islem in context.IsEmriOperasyonIslemleri on t2.Id equals islem.IsEmriOperasyonId

                             select new HammaddeKontrolFoyu
                             {
                                 HammaddeAdi = sk.Ad,
                                 StokKodu = sk.Kod,
                                 TeorikMiktar = p.Miktar,
                                 ReelMiktar = p.ReelMiktar,
                                 KontrolEden = t2.TartimKontrolEden,
                                 LotNo = p.LotNo,
                                 RefNo = p.ReferansNo,
                                 Tartan = t2.TartimTartan,
                                 Tarih = p.IslemBitisTarihi,
                                 Birim = birim.Kod,
                                 BirimId = birim.Id,
                                 Id = p.Id,
                                 Fark = p.ReelMiktar - p.Miktar,
                                 Stok = sk
                             };
                return result.ToList();

            }

        }

        public List<IsEmriIhtiyacListesi> IsEmriIhtiyacListesiOlustur(int ReceteId, decimal Carpan)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = from p in context.UrunReceteDetaylar
                             join stok in context.StokKartis on p.StokKartiId equals stok.Id into birlesmis
                             from liste in birlesmis.DefaultIfEmpty()
                             where p.UrunReceteId == ReceteId
                             select new IsEmriIhtiyacListesi
                             {
                                 Id = p.Id,
                                 StokId = liste.Id,
                                 StokKodu = liste.Kod,
                                 StokAd = liste.Ad,
                                 StokMiktari = liste.MevcutMiktar,
                                 StokBirimi = liste.StokBirimId,
                                 StokReceteIhtiyaci = p.Miktar * Carpan,
                                 StokReceteBirimi = p.StokBirimId,
                                 Ihtiyac = 1//true? StokKartCarpanBul(liste, p,Carpan):1
                             };
                List<IsEmriIhtiyacListesi> listem = new List<IsEmriIhtiyacListesi>();
                foreach (var item in result)
                {
                    var carpan = StokKartCarpanBul(item.StokId, item.StokReceteBirimi);
                    item.Ihtiyac = carpan * item.StokReceteIhtiyaci;
                    if (item.Ihtiyac > item.StokMiktari)
                        listem.Add(item);
                }
                
                return listem;
            }
        }

        public decimal StokKartCarpanBul(int stokId, int birimId)
        {
            StokKarti stok;
            using (ErpContext context = new ErpContext())
            {
                stok = (from p in context.StokKartis
                        where p.Id == stokId
                        select p).FirstOrDefault();
            }
            decimal carpan;
            carpan = 1;
            if (stok.StokBirimId == birimId)
                carpan = 1;
            else if (stok.Birim2Id == birimId)
            {
                carpan = (stok.Birim2Pay / stok.Birim2Payda);
            }
            else if (stok.Birim3Id == birimId)
            {
                carpan = (stok.Birim3Pay / stok.Birim3Payda);
            }

            return carpan;
        }
    }
    public class EfIsEmriOperasyonDal : EfEntityRepositoryBase<IsEmriOperasyon, ErpContext>, IIsEmriOperasyonDal
    {
        public void TopluSil(List<IsEmriOperasyon> OperasyonListesi)
        {
            foreach (var item in OperasyonListesi)
            {
                Delete(item);
            }
        }


    }
    public class EfIsEmriOperasyonIslemDal : EfEntityRepositoryBase<IsEmriOperasyonIslem, ErpContext>, IIsEmriOperasyonIslemDal
    {

    }
}
