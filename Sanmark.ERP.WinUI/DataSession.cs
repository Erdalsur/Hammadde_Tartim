using Sanmark.Erp.Framework.Abstract;
using System;
using System.Linq;

namespace Sanmark.ERP.WinUI
{
    public class DataSession
    {
        public DataSession(ISirketService sirketService, IDonemService donemService, IStokKartService stokKartService,IAmbalajService ambalajService,
            IStokBirimService stokBirimService,IStokGrupService stokGrupService,IDepoService depoService, IDepoHareketService depoHareketService,
            IStokHareketService stokHareketService,IFirmaService firmaService, IUrunAgaciService urunAgaciService,
            IUretimService uretimService, IUserService userService,IKodService kodService,IUrunReceteService urunReceteService,IIsEmirService isEmirService)
        {
            SirketService = sirketService;
            DonemService = donemService;
            StokKartService = stokKartService;
            AmbalajService = ambalajService;
            StokGrupService = stokGrupService;
            StokBirimService = stokBirimService;
            DepoService = depoService;
            DepoHareketService = depoHareketService;
            StokHareketService = stokHareketService;
            FirmaService = firmaService;
            UrunAgaciService = urunAgaciService;
            UretimService = uretimService;
            UserService = userService;
            KodService = kodService;
            UrunReceteService = urunReceteService;
            IsEmirService = isEmirService;
        }
        public static ISirketService SirketService { get; set; }
        public static IDonemService DonemService { get; set; }
        public static IStokKartService StokKartService { get; set; }
        public static IAmbalajService AmbalajService { get; set; }
        public static IStokGrupService StokGrupService { get; set; }
        public static IStokBirimService StokBirimService { get; set; }
        public static IDepoService DepoService { get; set; }
        public static IDepoHareketService DepoHareketService { get; set; }
        public static IStokHareketService StokHareketService { get; set; }
        public static IFirmaService FirmaService { get; set; }
        public static IUrunAgaciService UrunAgaciService { get; set; }
        public static IUretimService UretimService { get; set; }
        public static IUserService UserService { get; set; }
        public static IKodService KodService { get; set; }
        public static IUrunReceteService UrunReceteService { get; set; }
        public static IIsEmirService IsEmirService { get; set; }
    }

}
