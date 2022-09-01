using Sanmark.Erp.Data.Concrete.EntityFramework;
using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Entities.Concrete.Uretim;
using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;


namespace Sanmark.Core.Utilities
{
    public static class DataBaseOlusturma
    {
        public static void Olustur(string ConnectionString)
        {
            SqlConnectionStringBuilder sqlConnection = new SqlConnectionStringBuilder(ConnectionString);
            using (var contextYeni = new ErpContext(sqlConnection.ConnectionString))
            {

                contextYeni.Database.Connection.ConnectionString = sqlConnection.ConnectionString;
                CultureInfo cultures = new CultureInfo("tr-TR");
                contextYeni.Database.CreateIfNotExists();
                if (!contextYeni.Users.Any(c => c.UserName == "Admin"))
                {
                    contextYeni.Users.Add(new User
                    {
                        FirstName = "Admin",
                        LastName = "Admin",
                        UserName = "admin",
                        Password = "admin",
                        KayitUserId = 1,
                        KayitTarihi = DateTime.Now
                    });
                }
                if (!contextYeni.Kodlar.Any(c => c.Tablo == "DepoFisi"))
                {
                    contextYeni.Kodlar.Add(new Kod
                    {
                        SirketId = 1,
                        DonemId = 1,
                        Tablo = "DepoFisi",
                        OnEki = "DEPO",
                        SonDeger = 1,
                        Uzunlugu = 10,
                        KayitUserId = 1,
                        KayitTarihi = DateTime.Now
                    });
                    contextYeni.Kodlar.Add(new Kod
                    {
                        SirketId = 1,
                        DonemId = 1,
                        Tablo = "TartimFisi",
                        OnEki = "T",
                        SonDeger = 1,
                        Uzunlugu = 10,
                        KayitUserId = 1,
                        KayitTarihi = DateTime.Now
                    });
                    contextYeni.Kodlar.Add(new Kod
                    {
                        SirketId = 1,
                        DonemId = 1,
                        Tablo = "TransferFisi",
                        OnEki = "DT",
                        SonDeger = 1,
                        Uzunlugu = 10,
                        KayitUserId = 1,
                        KayitTarihi = DateTime.Now
                    });
                }
                if (contextYeni.Sirketler.ToList().Count == 0)
                {
                    contextYeni.Sirketler.Add(new Sirket
                    {
                        Ad = "Test",
                        Kod = "1",
                        KayitTarihi = DateTime.Now,
                        KayitUserId = 1,
                        Id = 1
                    }
                    );
                }
                {
                    string deger = null;
                    var liste = contextYeni.Sirketler.Where(f => f.Kod == deger).ToList();
                    if (contextYeni.Sirketler.Where(f => f.Kod == deger).ToList().Count > 0)
                    {
                        var _sirket = contextYeni.Sirketler.SingleOrDefault(f => f.Kod == deger);
                        _sirket.Kod = "1";
                        var update = contextYeni.Entry(_sirket);
                        update.State = EntityState.Modified;
                    }
                }
                if (contextYeni.Donems.ToList().Count == 0)
                {
                    contextYeni.Donems.Add(new Donem
                    {
                        SirketId = 1,
                        Id = 1,
                        Yil = Convert.ToInt16(DateTime.Now.Year),
                        Baslangic = Convert.ToDateTime("01/01/" + DateTime.Now.Year.ToString(), cultures),
                        Bitis = Convert.ToDateTime("31/12/" + DateTime.Now.Year.ToString(), cultures),
                        KayitTarihi = DateTime.Now,
                        KayitUserId = 1
                    });
                }
                if (contextYeni.Makinalar.ToList().Count == 0)
                {
                    contextYeni.Makinalar.Add(new Makina
                    {
                        Id = 1,
                        MakinaAdi = "Üretim Tartısı",
                        IsTartim = true,
                        SirketId = 1,
                        DonemId = 1,
                        KayitTarihi = DateTime.Now,
                        KayitUserId = 1
                    });
                }
                var count = contextYeni.Ambalajlar.ToList().Count;
                if (count == 0)
                {
                    contextYeni.Ambalajlar.Add(new Ambalaj
                    {
                        Id = 1,
                        SirketId = 1,
                        Ad = "Bidon",
                        KayitTarihi = DateTime.Now,
                        KayitUserId = 1
                    });
                    contextYeni.Ambalajlar.Add(new Ambalaj
                    {
                        Id = 2,
                        SirketId = 1,
                        Ad = "Çuval",
                        KayitTarihi = DateTime.Now,
                        KayitUserId = 1
                    });
                    contextYeni.Ambalajlar.Add(new Ambalaj
                    {
                        Id = 3,
                        SirketId = 1,
                        Ad = "Fıçı",
                        KayitTarihi = DateTime.Now,
                        KayitUserId = 1
                    });
                    contextYeni.Ambalajlar.Add(new Ambalaj
                    {
                        Id = 4,
                        SirketId = 1,
                        Ad = "Koli",
                        KayitTarihi = DateTime.Now,
                        KayitUserId = 1
                    });
                    contextYeni.Ambalajlar.Add(new Ambalaj
                    {
                        Id = 5,
                        SirketId = 1,
                        Ad = "Paket",
                        KayitTarihi = DateTime.Now,
                        KayitUserId = 1
                    });
                    contextYeni.Ambalajlar.Add(new Ambalaj
                    {
                        Id = 6,
                        SirketId = 1,
                        Ad = "Palet",
                        KayitTarihi = DateTime.Now,
                        KayitUserId = 1
                    });
                    contextYeni.Ambalajlar.Add(new Ambalaj
                    {
                        Id = 7,
                        SirketId = 1,
                        Ad = "Poşet",
                        KayitTarihi = DateTime.Now,
                        KayitUserId = 1
                    });
                    contextYeni.Ambalajlar.Add(new Ambalaj
                    {
                        Id = 8,
                        SirketId = 1,
                        Ad = "Varil",
                        KayitTarihi = DateTime.Now,
                        KayitUserId = 1
                    });
                }

                contextYeni.SaveChanges();
            }

        }
    }
}
