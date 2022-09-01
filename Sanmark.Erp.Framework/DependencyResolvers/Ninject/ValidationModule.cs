using FluentValidation;
using Ninject.Modules;
using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Entities.Concrete.Cari;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Framework.ValidationRules.FluentValidation;

namespace Sanmark.Erp.Framework.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Donem>>().To<DonemValidator>().InSingletonScope();
            Bind<IValidator<Sirket>>().To<SirketValidator>().InSingletonScope();
            Bind<IValidator<StokBirim>>().To<StokBirimValidator>().InSingletonScope();
            Bind<IValidator<StokGrup>>().To<StokGrupValidator>().InSingletonScope();
            Bind<IValidator<StokKarti>>().To<StokKartValidator>().InSingletonScope();
            Bind<IValidator<Ambalaj>>().To<AmbalajValidator>().InSingletonScope();
            Bind<IValidator<Depo>>().To<DepoValidator>().InSingletonScope();
            Bind<IValidator<Firma>>().To<FirmaValidator>().InSingletonScope();
        }
    }
}
