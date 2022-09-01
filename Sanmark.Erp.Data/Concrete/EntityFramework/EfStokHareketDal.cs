using Sanmark.Core.DataAccess.EntityFramework;
using Sanmark.Core.Utilities.Extensions.LinqEx;
using Sanmark.Core.Utilities.Tipler;
using Sanmark.Core.Utilities.Win.Infrastructure;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Entities.ComplexTypes.Uretim;
using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanmark.Erp.Data.Concrete.EntityFramework
{
    public class EfStokHareketDal : EfEntityRepositoryBase<StokHareket, ErpContext>, IStokHareketDal
    {
        private double StokMevcut;

        public List<StokHareketListe> StokHarketListesi(Expression<Func<StokHareket, bool>> filter = null)
        {
            StokMevcut = 0;
            Mevcut = new Dictionary<int, double>();
            using (ErpContext context = new ErpContext())
            {
                var tablo = context.StokHarekets.Where(filter).ToList().GroupJoin(context.StokKartis, c => c.StokId, c => c.Id,
                (StokHarekets, StokKarts) =>
                new StokHareketListe
                {
                    Id = StokHarekets.Id,
                    SirketId = StokHarekets.SirketId,
                    DonemId = StokHarekets.DonemId,
                    DepoId = StokHarekets.DepoId,
                    StokId = StokHarekets.StokId,
                    StokTipi = StokKarts.SingleOrDefault(f => f.Id == StokHarekets.StokId).Tip,
                    FisId = StokHarekets.FisId,
                    FisNo = StokHarekets.FisNo,
                    Tarih = StokHarekets.Tarih,
                    GirisCikis = StokHarekets.GirisCikis,
                    HareketTuru = StokHarekets.HareketTuru,
                    KaliteKontrolNo = StokHarekets.KaliteKontrolNo,
                    BaglantiId = StokHarekets.BaglantiId,
                    BaglantiSatirId = StokHarekets.BaglantiSatirId,
                    KayitTarihi = StokHarekets.KayitTarihi,
                    KayitUserId = StokHarekets.KayitUserId,
                    DegistirmeTarihi = StokHarekets.DegistirmeTarihi,
                    DegistirmeUserId = StokHarekets.DegistirmeUserId,
                    LotNo = StokHarekets.LotNo,
                    AnalizDurumu = StokHarekets.AnalizDurumu,
                    AnalizSertifikasiGeldimi = StokHarekets.AnalizSertifikasiGeldimi,
                    StokAdi = StokKarts.SingleOrDefault(f => f.Id == StokHarekets.StokId).Ad,
                    StokGirisMiktari = StokHarekets.GirisCikis == "1" ? StokHarekets.GirisCikisMiktar : 0,
                    StokCikisMiktari = StokHarekets.GirisCikis == "2" ? StokHarekets.GirisCikisMiktar : 0,
                    StokBirimi = StokHarekets.BirimId,
                    StokBakiyesi = StokHarekets.GirisCikis == "1" ? StokArttir(StokHarekets.StokId, StokHarekets.GirisCikisMiktar * 1, StokKarts.SingleOrDefault(f => f.Id == StokHarekets.StokId), StokHarekets.BirimId) :
                    StokArttir(StokHarekets.StokId, StokHarekets.GirisCikisMiktar * -1, StokKarts.SingleOrDefault(f => f.Id == StokHarekets.StokId), StokHarekets.BirimId),
                    StokAnaBirimi = StokKarts.SingleOrDefault(s => s.Id == StokHarekets.StokId).StokBirimId,
                    SKT = StokHarekets.SKT
                }
                );
                //if (tablo.Count()==0)
                //{
                //    return new List<StokHareketListe>();
                //}
                return tablo.ToList();
            }

        }

        private Dictionary<int, double> Mevcut;
        private Dictionary<string, double> Mevcut2;
        private double StokArttir(int stokId, double girisCikisMiktar, StokKarti stokKarti, int hareketBirimId)
        {
            double deger;
            decimal carpan = 1;
            Mevcut.TryGetValue(stokId, out deger);
            if (stokKarti.StokBirimId == hareketBirimId)
            {
                carpan = 1;
            }
            else
            {
                //Birim Çevrimi Yapılacak
                if (stokKarti.Birim2Id == hareketBirimId)
                {
                    carpan = stokKarti.Birim2Pay / stokKarti.Birim2Payda;
                }
                else if (stokKarti.Birim3Id == hareketBirimId)
                {
                    carpan = stokKarti.Birim3Pay / stokKarti.Birim3Payda;
                }
                else
                {
                    carpan = 1;
                }
            }
            if (deger == null)
            {

                deger = (girisCikisMiktar * Convert.ToDouble(carpan));
                Mevcut.Add(stokId, girisCikisMiktar);
            }
            else
            {

                deger += girisCikisMiktar * Convert.ToDouble(carpan);
                Mevcut.Remove(stokId);
                Mevcut.Add(stokId, deger);
            }

            return deger;
        }
        private double StokArttir2(double girisCikisMiktar, StokKarti stokKarti, int hareketBirimId)
        {
            double deger;
            decimal carpan = 1;
            if (stokKarti.StokBirimId == hareketBirimId)
            {
                carpan = 1;
            }
            else
            {
                //Birim Çevrimi Yapılacak
                if (stokKarti.Birim2Id == hareketBirimId)
                {
                    carpan = stokKarti.Birim2Pay / stokKarti.Birim2Payda;
                }
                else if (stokKarti.Birim3Id == hareketBirimId)
                {
                    carpan = stokKarti.Birim3Pay / stokKarti.Birim3Payda;
                }
                else
                {
                    carpan = 1;
                }
            }
            deger = (girisCikisMiktar * Convert.ToDouble(carpan));

            return deger;
        }
        public List<LotListesi> LotListesi(Expression<Func<LotListesi, bool>> filter = null)
        {
            string deger;
            using (ErpContext db = new ErpContext())
            {

                //         var query =
                //     from H in db.StokHarekets
                //     select new
                //     {
                //         H.Id,
                //         H.SirketId,
                //         H.DonemId,
                //         H.StokId,
                //         H.BirimId,
                //         H.LotNo,
                //         Giris = (decimal?)
                //         (from G in db.StokHarekets
                //          join K in db.StokKartis on new { Id = G.StokId } equals new { Id = K.Id } into K_join
                //          from K in K_join.DefaultIfEmpty()
                //          where
                //            G.StokId == H.StokId &&
                //            G.GirisCikis == "1"
                //          select new
                //          {
                //              Column1 =
                //G.BirimId == K.StokBirimId ? 1 :
                //G.BirimId == K.Birim2Id ? (K.Birim2Pay / K.Birim2Payda) :
                //G.BirimId == K.Birim3Id ? (K.Birim3Pay / K.Birim3Payda) : 0
                //          }).Sum(p => p.Column1),

                //         Cikis = (decimal?)
                //         (from G in db.StokHarekets
                //          join K in db.StokKartis on new { Id = G.StokId } equals new { Id = K.Id } into K_join
                //          from K in K_join.DefaultIfEmpty()
                //          where
                //            G.StokId == H.StokId &&
                //            G.GirisCikis == "2"
                //          select new
                //          {
                //              Column1 =
                //G.BirimId == K.StokBirimId ? 1 :
                //G.BirimId == K.Birim2Id ? (K.Birim2Pay / K.Birim2Payda) :
                //G.BirimId == K.Birim3Id ? (K.Birim3Pay / K.Birim3Payda) : 0
                //          }).Sum(p => p.Column1),
                //         SKT =
                //         ((from TH in db.StokHarekets
                //           where
                //             TH.StokId == H.StokId &&
                //             TH.SKT != null
                //           select new
                //           {
                //               TH.SKT
                //           }).Take(1)).Min(p => p.SKT),
                //         UretimTarihi =
                //         ((from TH in db.StokHarekets
                //           where
                //             TH.StokId == H.StokId &&
                //             TH.UretimTarihi != null
                //           select new
                //           {
                //               TH.UretimTarihi
                //           }).Take(1)).Min(p => p.UretimTarihi),
                //         H.Tarih,
                //         StokKartBirimId =
                //         ((from StokKartlars in db.StokKartis
                //           where
                //             StokKartlars.Id == H.StokId
                //           select new
                //           {
                //               StokKartlars.StokBirimId
                //           }).First().StokBirimId)
                //     };
                //         Debugger.NotifyOfCrossThreadDependency();
                //         var liste = new List<LotListesi>();
                //         foreach (var r in query)
                //             liste.Add(new LotListesi { 
                //                 Id=r.Id, SirketId=r.SirketId, DonemId=r.DonemId, StokId= r.StokId, Birim= r.BirimId, LotNo= r.LotNo,
                //                 Giris_Miktar=(decimal)r.Giris, Cikis_Miktar=(decimal)r.Cikis,SKT= r.SKT,UretimTarihi= r.UretimTarihi,Tarih= r.Tarih,
                //                 StokKartBirimId=r.StokKartBirimId});
                //         Task.WaitAll();
                //         return liste;
                var sql = @"SELECT Id, SirketId, DonemId, StokId, BirimId, LotNo,
(SELECT SUM(G.GirisCikisMiktar * CASE WHEN G.BirimId = K.StokBirimId THEN 1 WHEN G.BirimId = K.Birim2Id THEN K.Birim2Pay / K.Birim2Payda WHEN G.BirimId
                            = K.Birim3Id THEN K.Birim3Pay / K.Birim3Payda ELSE 0 END) AS Expr1
FROM            dbo.StokHareketleri AS G LEFT OUTER JOIN
                            dbo.StokKartlar AS K ON K.Id = G.StokId
WHERE(G.StokId = H.StokId) AND(G.GirisCikis = 1) and (G.LotNo=H.LotNo)) AS Giris,
                             (SELECT        SUM(G.GirisCikisMiktar * CASE WHEN G.BirimId = K.StokBirimId THEN 1 WHEN G.BirimId = K.Birim2Id THEN K.Birim2Pay / K.Birim2Payda WHEN G.BirimId
                                                 = K.Birim3Id THEN K.Birim3Pay / K.Birim3Payda ELSE 0 END) AS Expr1

                      FROM            dbo.StokHareketleri AS G LEFT OUTER JOIN

                                                dbo.StokKartlar AS K ON K.Id = G.StokId

                      WHERE(G.StokId = H.StokId) AND(G.GirisCikis = 2) and (G.LotNo=H.LotNo)) AS Cikis,
                             (SELECT        TOP(1) MIN(SKT) AS Expr1

             FROM            dbo.StokHareketleri AS TH

             WHERE(StokId = H.StokId) AND(SKT IS NOT NULL) and (LotNo=H.LotNo)) AS SKT,
                             (SELECT        TOP(1) MIN(UretimTarihi) AS Expr1

    FROM            dbo.StokHareketleri AS TH

    WHERE(StokId = H.StokId) AND(UretimTarihi IS NOT NULL) and (LotNo=H.LotNo)) AS UretimTarihi, Tarih,
                             (SELECT        StokBirimId

FROM            dbo.StokKartlar

WHERE(Id = H.StokId)) AS StokKartBirimId
FROM dbo.StokHareketleri AS H ";
                var Server = SettingsTool.AyarOku(SettingsTool.Ayarlar.DataSetting_Host);
                var DataBaseName = SettingsTool.AyarOku(SettingsTool.Ayarlar.DataSetting_DataBase);
                var Kullanici = SettingsTool.AyarOku(SettingsTool.Ayarlar.DataSetting_User);
                var SifreHash = SettingsTool.AyarOku(SettingsTool.Ayarlar.DataSetting_Password);
                var Sifre = SettingsTool.AyarOku(SettingsTool.Ayarlar.DataSetting_Password);//CryptoManager.SifreCoz(SifreHash);
                String strConnection = String.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                    Server, DataBaseName, Kullanici, Sifre);

                var c = new SqlConnection(strConnection); // Your Connection String here
                var dataAdapter = new SqlDataAdapter(sql, c);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);

                //var tablo = ds.Tables[0].AsEnumerable().ToList();
                var liste = new List<LotListesi>();
                liste = (from DataRow dr in ds.Tables[0].Rows
                         select new LotListesi()
                         {
                             Id = Convert.ToInt32(dr["Id"]),
                             SirketId = Convert.ToInt32(dr["SirketId"]),
                             DonemId = Convert.ToInt32(dr["DonemId"]),
                             StokId = Convert.ToInt32(dr["StokId"]),
                             Birim = Convert.ToInt32(dr["BirimId"]),
                             LotNo = dr["LotNo"].ToString(),
                             Giris_Miktar = decimalParse(dr["Giris"]),
                             Cikis_Miktar = decimalParse(dr["Cikis"]),
                             SKT = datetimeParse(dr["SKT"].ToString()),
                             UretimTarihi = datetimeParse(dr["UretimTarihi"].ToString()),
                             Tarih = Convert.ToDateTime(dr["Tarih"].ToString()),
                             StokKartBirimId = Convert.ToInt32(dr["StokKartBirimId"])

                         }).ToList();
                //return liste;
                var tablo = liste.AsQueryable().Where(filter).ToList();
                ////var tablo2 = tablo.ToList();
                ////Debugger.NotifyOfCrossThreadDependency();
                ////return tablo2.DistinctBy(f => new { f.StokId, f.LotNo }).OrderBy(f => f.Tarih).ToList();
                return tablo.DistinctBy(f => new { f.StokId, f.LotNo }).OrderBy(f => f.Tarih).ToList();
            }
            decimal decimalParse(object str)
            {
                if (str == null)
                    return 0;
                else
                {
                    decimal tmp = 0;
                    decimal.TryParse(str.ToString(), out tmp);
                    return tmp;
                }
            }
            DateTime datetimeParse(object str)
            {
                DateTime tmp = new DateTime(2000, 1, 1);  //DateTime.MinValue;
                if (str != null)
                    if (str != DBNull.Value)
                        DateTime.TryParse(str.ToString(), out tmp);

                return tmp;
            }
        }

        private object StokAyar(double girisCikisMiktar, decimal birimPay, decimal birimPayda)
        {
            var result = girisCikisMiktar * Convert.ToDouble(birimPay / birimPayda);
            return result.ToString();
        }
    }
}

//       var tablo = (from H in db.StokHarekets.Where(filter)
//                    select new LotListesi
//                    {
//                        Id = H.Id,
//                        SirketId = H.SirketId,
//                        DonemId = H.DonemId,
//                        StokId = H.StokId,
//                        Birim = H.BirimId,
//                        LotNo = H.LotNo,
//                        Giris_Miktar = (double)
//                        (from X in db.StokHarekets
//                         from SX in db.StokKartis.Where(f => f.Id == X.StokId).DefaultIfEmpty()
//                         where
//H.StokId == X.StokId &&
//X.GirisCikis == ((int)StokGirisCikis.Giris).ToString()
//                         select new
//                         {
//                             G =(SX.Birim2Pay/SX.Birim2Payda),
//                             a = X.GirisCikisMiktar.ToString()
//                             //X.GirisCikisMiktar,
//                             //G =deger.ToString() //X.BirimId==SX.StokBirimId?(X.GirisCikisMiktar).ToString(): //X.BirimId == SX.Birim2Id ? X.GirisCikisMiktar*Convert.ToDouble(SX.Birim2Pay/SX.Birim2Payda):
//                             //(X.GirisCikisMiktar * Convert.ToDouble((SX.Birim3Pay / SX.Birim3Payda))).ToString()


//                         }).Sum(p => Convert.ToDecimal(new { a=p.G *Convert.ToDecimal(p.a) })),

//                        Cikis_Miktar = (double)
//                        (from X in db.StokHarekets
//                         where
//                            H.StokId == X.StokId &&
//                            X.GirisCikis == ((int)StokGirisCikis.Cikis).ToString()
//                         select new
//                         {
//                             X.GirisCikisMiktar
//                         }).Sum(p => p.GirisCikisMiktar),

//                        Tarih = H.Tarih,
//                        SKT = ((from X in db.StokHarekets
//                                where
//                                  H.StokId == X.StokId
//                                orderby
//                                  X.SKT
//                                select new
//                                {
//                                    X.SKT
//                                }).Take(1).FirstOrDefault().SKT),
//                        UretimTarihi = ((from X in db.StokHarekets
//                                         where
//                                           H.StokId == X.StokId
//                                         orderby
//                                           X.UretimTarihi descending
//                                         select new
//                                         {
//                                             X.UretimTarihi
//                                         }).Take(1).FirstOrDefault().UretimTarihi)
//                    }).Distinct();
//       var tablo = from H in db.StokHarekets.Where(filter)
//                   select new LotListesi
//                   {
//                       Id=H.Id,
//                       SirketId=H.SirketId,
//                       DonemId=H.DonemId,
//                       StokId=H.StokId,
//                       Birim=H.BirimId,
//                       LotNo=H.LotNo,
//                       Giris_Miktar = (decimal?)
//             (from G in db.StokHarekets
//              join K in db.StokKartis on new { Id = G.StokId } equals new { Id = K.Id } into K_join
//              from K in K_join.DefaultIfEmpty()
//              where
//G.StokId == H.StokId &&
//G.GirisCikis == Convert.ToString(1)
//              select new
//              {
//                  Column1 =
//G.BirimId == K.StokBirimId ? 1 :
//G.BirimId == K.Birim2Id ? (K.Birim2Pay / K.Birim2Payda) :
//G.BirimId == K.Birim3Id ? (K.Birim3Pay / K.Birim3Payda) : 0
//              }).Sum(p => p.Column1),
//                       Cikis_Miktar = (decimal?)
//             (from G in db.StokHarekets
//              join K in db.StokKartis on new { Id = G.StokId } equals new { Id = K.Id } into K_join
//              from K in K_join.DefaultIfEmpty()
//              where
//G.StokId == H.StokId &&
//G.GirisCikis == Convert.ToString(2)
//              select new
//              {
//                  Column1 =
//G.BirimId == K.StokBirimId ? 1 :
//G.BirimId == K.Birim2Id ? (K.Birim2Pay / K.Birim2Payda) :
//G.BirimId == K.Birim3Id ? (K.Birim3Pay / K.Birim3Payda) : 0
//              }).Sum(p => p.Column1),
//                       SKT =
//             ((from TH in db.StokHarekets
//               where
// TH.StokId == H.StokId &&
// TH.SKT != null
//               select new
//               {
//                   TH.SKT
//               }).Take(1)).Min(p => p.SKT),
//                       UretimTarihi =
//             ((from TH in db.StokHarekets
//               where
// TH.StokId == H.StokId &&
// TH.UretimTarihi != null
//               select new
//               {
//                   TH.UretimTarihi
//               }).Take(1)).Min(p => p.UretimTarihi),
//                       Tarih=H.Tarih,
//                       StokKartBirimId =
//             ((from StokKartlars in db.StokKartis
//               where
// StokKartlars.Id == H.StokId
//               select new
//               {
//                   StokKartlars.StokBirimId
//               }).First().StokBirimId)
//                   };



//public List<StokHareketListe> StokHarketListesi(Expression<Func<StokHareket, bool>> filter = null)
//{
//    StokMevcut = 0;

//    using (ErpContext context = new ErpContext())
//    {
//        var tablo = context.StokHarekets.Where(filter).ToList().GroupJoin(context.StokKartis, c => c.StokId, c => c.Id,
//        (StokHarekets, StokKarts) =>
//        new StokHareketListe
//        {
//            Id = StokHarekets.Id,
//            SirketId = StokHarekets.SirketId,
//            DonemId = StokHarekets.DonemId,
//            DepoId = StokHarekets.DepoId,
//            StokId = StokHarekets.StokId,
//            StokTipi = StokKarts.SingleOrDefault(f => f.Id == StokHarekets.StokId).Tip,
//            FisNo = StokHarekets.FisNo,
//            Tarih = StokHarekets.Tarih,
//            GirisCikis = StokHarekets.GirisCikis,
//            HareketTuru = StokHarekets.HareketTuru,
//            KaliteKontrolNo = StokHarekets.KaliteKontrolNo,
//            BaglantiId = StokHarekets.BaglantiId,
//            BaglantiSatirId = StokHarekets.BaglantiSatirId,
//            KayitTarihi = StokHarekets.KayitTarihi,
//            KayitUserId = StokHarekets.KayitUserId,
//            DegistirmeTarihi = StokHarekets.DegistirmeTarihi,
//            DegistirmeUserId = StokHarekets.DegistirmeUserId,
//            StokAdi = StokKarts.SingleOrDefault(f => f.Id == StokHarekets.StokId).Ad,
//            StokGirisMiktari = StokHarekets.GirisCikis == "1" ? StokHarekets.GirisCikisMiktar : 0,
//            StokCikisMiktari = StokHarekets.GirisCikis == "2" ? StokHarekets.GirisCikisMiktar : 0,
//            StokBakiyesi = StokHarekets.GirisCikis == "1" ? StokArttir(StokHarekets.StokId, StokHarekets.GirisCikisMiktar * 1) :
//            StokArttir(StokHarekets.StokId, StokHarekets.GirisCikisMiktar * -1),
//            StokBirimi = StokKarts.SingleOrDefault(s => s.Id == StokHarekets.StokId).StokBirimId
//        }
//        );
//        //if (tablo.Count()==0)
//        //{
//        //    return new List<StokHareketListe>();
//        //}
//        return tablo.ToList();
//    }

//}