using Sanmark.Core.DataAccess.EntityFramework;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Entities.ComplexTypes.Uretim;
using Sanmark.Erp.Entities.Concrete.Uretim;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sanmark.Erp.Data.Concrete.EntityFramework
{
    
    public class EfUretimEmirDetaylariDal : EfEntityRepositoryBase<UretimEmirDetaylari, ErpContext>, IUretimEmirDetaylariDal
    {
        public List<HammaddeKontrolFoyu> GetHammaddeKontrol(int id)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = from p in context.UretimEmirDetaylari
                             where p.UretimEmirId == id
                             join sk in context.StokKartis on p.UrunId equals sk.Id
                             join birim in context.StokBirims on sk.StokBirimId equals birim.Id
                             join t in context.UretimTartimlari on p.Id equals (int?)t.UretimEmirDetayId into tartimlar
                             from t2 in tartimlar.Distinct().DefaultIfEmpty()
                             select new HammaddeKontrolFoyu
                             {
                                 HammaddeAdi = sk.Ad,
                                 StokKodu=sk.Kod,
                                 TeorikMiktar = p.Miktar,
                                 ReelMiktar = p.ReelMiktar,
                                 KontrolEden = t2.KontrolEden,
                                 LotNo = p.LotNo,
                                 RefNo = p.ReferansNo,
                                 Tartan = t2.Tartan,
                                 Tarih = t2.TartimTarihi,
                                 Birim=birim.Kod,
                                 Id = p.Id
                             };
                          
                              
                            
                return result.ToList();

            }
        }


    }
}
//var result = (from p in Products
//              join o in Orders on p.ProductId equals o.ProductId into temp
//              from t in temp.DefaultIfEmpty()
//              select new
//              {
//                  p.ProductId,
//                  OrderId = (int?)t.OrderId,
//                  t.OrderNumber,
//                  p.ProductName,
//                  Quantity = (int?)t.Quantity,
//                  t.TotalAmount,
//                  t.OrderDate
//              }).ToList();