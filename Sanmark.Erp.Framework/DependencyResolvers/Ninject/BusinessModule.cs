using Ninject.Modules;
using Sanmark.Core.DataAccess;
using Sanmark.Core.DataAccess.EntityFramework;
using Sanmark.Erp.Data.Abstract;
using Sanmark.Erp.Data.Concrete.EntityFramework;
using Sanmark.Erp.Framework.Abstract;
using Sanmark.Erp.Framework.Concrete.Managers;
using System.Data.Entity;

namespace Sanmark.Erp.Framework.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISirketService>().To<SirketManager>().InSingletonScope();
            Bind<ISirketDal>().To<EfSirketDal>().InSingletonScope();
            Bind<IDonemService>().To<DonemManager>().InSingletonScope();
            Bind<IDonemDal>().To<EfDonemDal>().InSingletonScope();
            Bind<IStokKartService>().To<StokKartManager>().InSingletonScope();
            Bind<IStokKartiDal>().To<EfStokKartiDal>().InSingletonScope();
            Bind<IStokBirimService>().To<StokBirimManager>().InSingletonScope();
            Bind<IStokBirimDal>().To<EfStokBirimDal>().InSingletonScope();
            Bind<IStokGrupService>().To<StokGrupManager>().InSingletonScope();
            Bind<IStokGrupDal>().To<EfStokGrupDal>().InSingletonScope();
            Bind<IAmbalajService>().To<AmbalajManager>().InSingletonScope();
            Bind<IAmbalajDal>().To<EfAmbalajDal>().InSingletonScope();
            Bind<IDepoService>().To<DepoManager>().InSingletonScope();
            Bind<IDepoDal>().To<EfDepoDal>().InSingletonScope();
            Bind<IDepoHareketService>().To<DepoHareketManager>().InSingletonScope();
            Bind<IDepoHareketDal>().To<EfDepoHareketDal>().InSingletonScope();

            Bind<IStokHareketService>().To<StokHareketManager>().InSingletonScope();
            Bind<IStokHareketDal>().To<EfStokHareketDal>().InSingletonScope();
            Bind<IFisDal>().To<EfFisDal>().InSingletonScope();
            Bind<IFirmaService>().To<FirmaManager>().InSingletonScope();
            Bind<IFirmaDal>().To<EfFirmaDal>().InSingletonScope();
            Bind<IKodService>().To<KodManager>().InSingletonScope();
            Bind<IKodDal>().To<EfKodDal>().InSingletonScope();

            Bind<IUrunAgaciService>().To<UrunAgaciManager>().InSingletonScope();
            Bind<IUrunAgacDal>().To<EfUrunAgacDal>().InSingletonScope();
            Bind<IUrunAgacSatirlariDal>().To<EfUrunAgacSatirlariDal>().InSingletonScope();
            Bind<IUretimService>().To<UretimEmirManager>().InSingletonScope();
            Bind<IUretimEmirleriDal>().To<EfUretimEmirleriDal>().InSingletonScope();
            Bind<IUretimEmirDetaylariDal>().To<EfUretimEmirDetaylariDal>().InSingletonScope();
            Bind<IUretimTartimlariDal>().To<EfUretimTartimlariDal>().InSingletonScope();
            Bind<IMakinaDal>().To<EfMakinaDal>().InSingletonScope();
            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();
            Bind<IUrunReceteService>().To<ReceteManager>().InSingletonScope();
            Bind<IUrunReceteDal>().To<EfUrunReceteDal>().InSingletonScope();
            Bind<IUrunReceteDetayDal>().To<EfUrunReceteDetayDal>().InSingletonScope();
            Bind<IIsEmirService>().To<IsEmirManager>().InSingletonScope();
            Bind<IIsEmriDal>().To<EfIsEmriDal>().InSingletonScope();
            Bind<IIsEmriOperasyonDal>().To<EfIsEmriOperasyonDal>().InSingletonScope();
            Bind<IIsEmriOperasyonIslemDal>().To<EfIsEmriOperasyonIslemDal>().InSingletonScope();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<ErpContext>();
            //Bind<NHibernateHelper>().To<SqlServerHelper>();
        }
    }
}
