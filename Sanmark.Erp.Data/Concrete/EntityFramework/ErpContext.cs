using Sanmark.Erp.Data.Concrete.EntityFramework.Mappings;
using Sanmark.Erp.Data.Migrations;
using Sanmark.Erp.Entities.ComplexTypes.Uretim;
using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Entities.Concrete.Cari;
using Sanmark.Erp.Entities.Concrete.Depolar;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Entities.Concrete.Uretim;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanmark.Erp.Data.Concrete.EntityFramework
{
    public class ErpContext : DbContext
    {
        public ErpContext():base("name=ErpContext") 
        {
            //if (Database.CreateIfNotExists())
            //{
            //    Database.SetInitializer<ErpContext>(new MigrateDatabaseToLatestVersion<ErpContext, ConfigurationFirst>());
                
            //}
            Database.SetInitializer<ErpContext>(new MigrateDatabaseToLatestVersion<ErpContext,Configuration>());
            //Configuration.LazyLoadingEnabled = true;
            //Configuration.ProxyCreationEnabled = true;
            this.Configuration.LazyLoadingEnabled = false;
        }
        public ErpContext(string ConnectionString) : base("name=ErpContext")
        {
            this.Database.Connection.ConnectionString = ConnectionString;
            //if (Database.CreateIfNotExists())
            //{
            //    Database.SetInitializer<ErpContext>(new MigrateDatabaseToLatestVersion<ErpContext, ConfigurationFirst>());

            //}
            Database.SetInitializer<ErpContext>(new MigrateDatabaseToLatestVersion<ErpContext, Configuration>());
            //Configuration.LazyLoadingEnabled = true;
            //Configuration.ProxyCreationEnabled = true;
            this.Configuration.LazyLoadingEnabled = false;
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public DbSet<Sirket> Sirketler { get; set; }
        public DbSet<Firma> Firmas { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Donem> Donems { get; set; }
        public DbSet<StokKarti> StokKartis { get; set; }
        public DbSet<Ambalaj> Ambalajlar { get; set; }
        public DbSet<StokGrup> StokGrups { get; set; }
        public DbSet<StokBirim> StokBirims { get; set; }
        public DbSet<Depo> Depos { get; set; }
        //public DbSet<StokDepoHareket> StokDepoHarekets { get; set; }
        //public DbSet<DepoHareketSatirlari> DepoHareketSatirlaris{ get; set; }
        public DbSet<StokHareket> StokHarekets { get; set; }

        public DbSet<UrunAgacSatirlari> UrunAgacSatirlari { get; set; }
        public DbSet<UrunAgaclari> UrunAgaclari { get; set; }
        public DbSet<UretimEmirleri> UretimEmirleri { get; set; }
        public DbSet<UretimEmirDetaylari> UretimEmirDetaylari { get; set; }
        public DbSet<UretimTartimlari> UretimTartimlari { get; set; }
        public DbSet<Makina> Makinalar { get; set; }
        public DbSet<Entities.Concrete.Kod> Kodlar { get; set; }
        public DbSet<UrunRecete> UrunReceteler { get; set; }
        public DbSet<UrunReceteDetay> UrunReceteDetaylar { get; set; }
        public DbSet<IsEmri> IsEmirleri { get; set; }
        public DbSet<IsEmriOperasyon> IsEmriOperasyonlari { get; set; }
        public DbSet<IsEmriOperasyonIslem> IsEmriOperasyonIslemleri { get; set; }
        //public virtual DbSet<LotListesi> LotListesis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SirketMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new DonemMap());
            modelBuilder.Configurations.Add(new StokKartiMap());
            modelBuilder.Configurations.Add(new AmbalajMap());
            modelBuilder.Configurations.Add(new StokGrupMap());
            modelBuilder.Configurations.Add(new StokBirimMap());
            modelBuilder.Configurations.Add(new DepoMap());
            modelBuilder.Configurations.Add(new UrunReceteMap());
            modelBuilder.Configurations.Add(new UrunReceteDetayMap());
            modelBuilder.Configurations.Add(new IsEmriMap());
            modelBuilder.Configurations.Add(new IsEmriOperasyonMap());
            modelBuilder.Configurations.Add(new IsEmriOperasyonIslemMap());
            modelBuilder.Configurations.Add(new StokHareketMap());
            modelBuilder.Configurations.Add(new FirmaMap());

            modelBuilder.Configurations.Add(new UrunAgaclariMap());
            modelBuilder.Configurations.Add(new UrunAgacSatirlariMap());
            modelBuilder.Configurations.Add(new UretimEmirleriMap());
            modelBuilder.Configurations.Add(new UretimEmirDetaylariMap());
            modelBuilder.Configurations.Add(new UretimTartimlariMap());
            modelBuilder.Configurations.Add(new MakinaMap());
            modelBuilder.Configurations.Add(new KodMap());

            //modelBuilder.Configurations.Add(new LotListesiMap());

            //modelBuilder.Conventions.Remove(OneToManyCascadeDeleteConvention);
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Entity<Sirket>().HasData();

        }

        public void ExecuteCommand(string command, params object[] parameters)
        {
            base.Database.ExecuteSqlCommand(command, parameters);
        }

    }
}
