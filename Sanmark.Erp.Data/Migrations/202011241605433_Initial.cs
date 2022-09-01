namespace Sanmark.Erp.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Paketler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SirketId = c.Int(nullable: false),
                        Ad = c.String(),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Depolar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SirketId = c.Int(nullable: false),
                        Kod = c.String(),
                        Ad = c.String(),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Donemler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SirketId = c.Int(nullable: false),
                        Yil = c.Short(nullable: false),
                        Baslangic = c.DateTime(nullable: false),
                        Bitis = c.DateTime(nullable: false),
                        OncekiYilId = c.Short(nullable: false),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Firmalar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SirketId = c.Int(nullable: false),
                        FirmaKartTip = c.Short(nullable: false),
                        FirmaTip = c.Short(nullable: false),
                        Kod = c.String(),
                        Ad = c.String(),
                        Soyad = c.String(),
                        VergiDairesi = c.String(),
                        VergiNo = c.String(),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IsEmirleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DonemId = c.Int(nullable: false),
                        IsEmriKodu = c.String(maxLength: 25),
                        IsEmriTipi = c.Int(nullable: false),
                        GenelDurumu = c.Int(nullable: false),
                        Aciklama = c.String(maxLength: 200),
                        PartiNo = c.String(maxLength: 100),
                        StokKartiId = c.Int(nullable: false),
                        Miktar = c.Decimal(nullable: false, precision: 12, scale: 6),
                        BirimId = c.Int(nullable: false),
                        MakinaId = c.Int(nullable: false),
                        Carpan = c.Decimal(nullable: false, precision: 12, scale: 6),
                        BaglantiAdres = c.String(maxLength: 25),
                        BaglantiId = c.Int(),
                        FisId = c.Int(),
                        PlanlananBaslangicTarihi = c.DateTime(),
                        PlananBitisTarihi = c.DateTime(),
                        BaslamaTarihi = c.DateTime(),
                        KapanisTarihi = c.DateTime(),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IsEmirOperasyonlari",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DonemId = c.Int(nullable: false),
                        IsEmriId = c.Int(nullable: false),
                        StokKartiId = c.Int(nullable: false),
                        Miktar = c.Decimal(nullable: false, precision: 12, scale: 6),
                        ReelMiktar = c.Decimal(nullable: false, precision: 12, scale: 6),
                        BirimId = c.Int(nullable: false),
                        Carpan = c.Decimal(nullable: false, precision: 12, scale: 6),
                        LotNo = c.String(),
                        ReferansNo = c.String(),
                        GenelDurum = c.Int(nullable: false),
                        IslemBaslamaTarihi = c.DateTime(),
                        IslemBitisTarihi = c.DateTime(),
                        SonKullanimTarihi = c.DateTime(),
                        FireMiktari = c.Decimal(nullable: false, precision: 12, scale: 6),
                        MakinaId = c.Int(nullable: false),
                        SiraNo = c.Int(),
                        FisId = c.Int(),
                        FisSatirId = c.Int(),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                        UrunReceteId = c.Int(nullable: false),
                        UrunReceteDetayId = c.Int(nullable: false),
                        StokBirim_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Donemler", t => t.DonemId)
                .ForeignKey("dbo.IsEmirleri", t => t.IsEmriId)
                .ForeignKey("dbo.Makinalar", t => t.MakinaId)
                .ForeignKey("dbo.StokBirimler", t => t.StokBirim_Id)
                .ForeignKey("dbo.StokKartlar", t => t.StokKartiId)
                .ForeignKey("dbo.UrunReceteleri", t => t.UrunReceteId)
                .ForeignKey("dbo.UrunReceteDetaylar", t => t.UrunReceteDetayId)
                .Index(t => t.DonemId)
                .Index(t => t.IsEmriId)
                .Index(t => t.StokKartiId)
                .Index(t => t.MakinaId)
                .Index(t => t.UrunReceteId)
                .Index(t => t.UrunReceteDetayId)
                .Index(t => t.StokBirim_Id);
            
            CreateTable(
                "dbo.IsEmirOperasyonIslemleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DonemId = c.Int(nullable: false),
                        IsEmriOperasyonId = c.Int(nullable: false),
                        TartimLotNo = c.String(maxLength: 25),
                        TartimReferansNo = c.String(maxLength: 25),
                        TartimTartan = c.String(maxLength: 25),
                        TartimKontrolEden = c.String(maxLength: 25),
                        TartimTarihi = c.DateTime(),
                        TartimMiktar = c.Decimal(nullable: false, precision: 12, scale: 6),
                        TartimDara = c.Decimal(nullable: false, precision: 12, scale: 6),
                        TartimBrut = c.Decimal(nullable: false, precision: 12, scale: 6),
                        TartimBirim = c.String(maxLength: 25),
                        TartimUrunId = c.Int(),
                        SonKullanimTarihi = c.DateTime(),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                        StokKarti_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Donemler", t => t.DonemId)
                .ForeignKey("dbo.IsEmirOperasyonlari", t => t.IsEmriOperasyonId)
                .ForeignKey("dbo.StokKartlar", t => t.StokKarti_Id)
                .Index(t => t.DonemId)
                .Index(t => t.IsEmriOperasyonId)
                .Index(t => t.StokKarti_Id);
            
            CreateTable(
                "dbo.StokKartlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SirketId = c.Int(nullable: false),
                        StokGrupId = c.Int(nullable: false),
                        StokBirimId = c.Int(nullable: false),
                        Tip = c.Short(nullable: false),
                        Kod = c.String(),
                        Ad = c.String(),
                        MevcutMiktar = c.Decimal(nullable: false, precision: 12, scale: 6),
                        Barkod = c.String(),
                        AmbalajId = c.Int(),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                        Birim2Id = c.Int(nullable: false),
                        Birim2Pay = c.Decimal(nullable: false, precision: 12, scale: 6),
                        Birim2Payda = c.Decimal(nullable: false, precision: 12, scale: 6),
                        Birim3Id = c.Int(nullable: false),
                        Birim3Pay = c.Decimal(nullable: false, precision: 12, scale: 6),
                        Birim3Payda = c.Decimal(nullable: false, precision: 12, scale: 6),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Makinalar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SirketId = c.Int(nullable: false),
                        DonemId = c.Int(nullable: false),
                        MakinaAdi = c.String(),
                        IsTartim = c.Boolean(nullable: false),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Donemler", t => t.DonemId)
                .ForeignKey("dbo.Sirketler", t => t.SirketId)
                .Index(t => t.SirketId)
                .Index(t => t.DonemId);
            
            CreateTable(
                "dbo.Sirketler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Kod = c.String(maxLength: 12),
                        Ad = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UretimEmirleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DonemId = c.Int(nullable: false),
                        Durumu = c.Int(nullable: false),
                        MakinaId = c.Int(),
                        UrunId = c.Int(nullable: false),
                        Aciklama = c.String(),
                        SeriNo = c.String(),
                        Tarih = c.DateTime(),
                        Miktar = c.Decimal(nullable: false, precision: 12, scale: 6),
                        UretimBaslangicTarihi = c.DateTime(),
                        UretimBitisTarihi = c.DateTime(),
                        AltUretimId = c.Int(nullable: false),
                        UstUretimId = c.Int(nullable: false),
                        UretimTipi = c.Int(nullable: false),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Donemler", t => t.DonemId)
                .ForeignKey("dbo.Makinalar", t => t.MakinaId)
                .ForeignKey("dbo.StokKartlar", t => t.UrunId)
                .Index(t => t.DonemId)
                .Index(t => t.MakinaId)
                .Index(t => t.UrunId);
            
            CreateTable(
                "dbo.UretimEmirDetaylari",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UretimEmirId = c.Int(nullable: false),
                        UrunId = c.Int(nullable: false),
                        Miktar = c.Decimal(nullable: false, precision: 12, scale: 6),
                        ReelMiktar = c.Decimal(nullable: false, precision: 12, scale: 6),
                        LotNo = c.String(),
                        ReferansNo = c.String(),
                        IslemBaslamaTarihi = c.DateTime(),
                        IslemBitisTarihi = c.DateTime(),
                        UretimDurumu = c.Int(nullable: false),
                        SonKullanimTarihi = c.DateTime(),
                        FireMiktari = c.Decimal(nullable: false, precision: 12, scale: 6),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UretimEmirleri", t => t.UretimEmirId)
                .Index(t => t.UretimEmirId);
            
            CreateTable(
                "dbo.UretimTartimlari",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UretimEmirDetayId = c.Int(nullable: false),
                        LotNo = c.String(),
                        ReferansNo = c.String(),
                        Tartan = c.String(),
                        KontrolEden = c.String(),
                        TartimTarihi = c.DateTime(),
                        SKT = c.DateTime(),
                        Miktar = c.Decimal(nullable: false, precision: 12, scale: 6),
                        Dara = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Brut = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Birim = c.String(),
                        UrunId = c.Int(nullable: false),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UretimEmirDetaylari", t => t.UretimEmirDetayId)
                .Index(t => t.UretimEmirDetayId);
            
            CreateTable(
                "dbo.StokBirimler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SirketId = c.Int(nullable: false),
                        Kod = c.String(),
                        Ad = c.String(),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UrunReceteleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false),
                        SirketId = c.Int(nullable: false),
                        ReceteKodu = c.String(maxLength: 25),
                        StokId = c.Int(nullable: false),
                        DepoId = c.Int(nullable: false),
                        Miktar = c.Decimal(nullable: false, precision: 12, scale: 6),
                        BirimId = c.Int(nullable: false),
                        BirimPay = c.Decimal(nullable: false, precision: 12, scale: 6),
                        BirimPayda = c.Decimal(nullable: false, precision: 12, scale: 6),
                        Aciklama = c.String(maxLength: 100),
                        RevizyonNo = c.Int(nullable: false),
                        RevizyonTarihi = c.DateTime(),
                        Carpan = c.Decimal(precision: 12, scale: 6),
                        MakinaId = c.Int(nullable: false),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                        StokBirim_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Depolar", t => t.DepoId)
                .ForeignKey("dbo.Makinalar", t => t.MakinaId)
                .ForeignKey("dbo.Sirketler", t => t.SirketId)
                .ForeignKey("dbo.StokKartlar", t => t.StokId)
                .ForeignKey("dbo.StokBirimler", t => t.StokBirim_Id)
                .Index(t => t.SirketId)
                .Index(t => t.StokId)
                .Index(t => t.DepoId)
                .Index(t => t.MakinaId)
                .Index(t => t.StokBirim_Id);
            
            CreateTable(
                "dbo.UrunReceteDetaylar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UrunReceteId = c.Int(nullable: false),
                        AnaStokKartiId = c.Int(nullable: false),
                        StokKartiId = c.Int(nullable: false),
                        Miktar = c.Decimal(nullable: false, precision: 12, scale: 6),
                        StokBirimId = c.Int(nullable: false),
                        FireOrani = c.Int(nullable: false),
                        DepoId = c.Int(nullable: false),
                        Not = c.String(maxLength: 100),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Depolar", t => t.DepoId)
                .ForeignKey("dbo.StokBirimler", t => t.StokBirimId)
                .ForeignKey("dbo.StokKartlar", t => t.StokKartiId)
                .ForeignKey("dbo.UrunReceteleri", t => t.UrunReceteId)
                .Index(t => t.UrunReceteId)
                .Index(t => t.StokKartiId)
                .Index(t => t.StokBirimId)
                .Index(t => t.DepoId);
            
            CreateTable(
                "dbo.Kodlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SirketId = c.Int(nullable: false),
                        DonemId = c.Int(nullable: false),
                        Tablo = c.String(maxLength: 15),
                        OnEki = c.String(maxLength: 6),
                        SonDeger = c.Int(nullable: false),
                        Uzunlugu = c.Int(nullable: false),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Donemler", t => t.DonemId)
                .ForeignKey("dbo.Sirketler", t => t.SirketId)
                .Index(t => t.SirketId)
                .Index(t => t.DonemId);
            
            CreateTable(
                "dbo.StokGruplar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SirketId = c.Int(nullable: false),
                        ParentId = c.Int(nullable: false),
                        Ad = c.String(),
                        Aciklama = c.String(),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StokHareketleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SirketId = c.Int(nullable: false),
                        DonemId = c.Int(nullable: false),
                        DepoId = c.Int(nullable: false),
                        StokId = c.Int(nullable: false),
                        FisId = c.Int(nullable: false),
                        FisNo = c.String(),
                        Tarih = c.DateTime(),
                        GirisCikisMiktar = c.Double(nullable: false),
                        GirisCikisMiktar2 = c.Double(nullable: false),
                        GirisCikis = c.String(),
                        HareketTuru = c.String(),
                        KaliteKontrolNo = c.String(),
                        BaglantiId = c.Int(nullable: false),
                        BaglantiSatirId = c.Int(nullable: false),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                        LotNo = c.String(),
                        UretimTarihi = c.DateTime(),
                        SKT = c.DateTime(),
                        PaketlemeTuru = c.String(),
                        PaketlemeSayisi = c.Int(),
                        AnalizSertifikasiGeldimi = c.Int(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "DefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "0")
                                },
                            }),
                        AnalizDurumu = c.String(),
                        Aciklama = c.String(),
                        BirimId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fis", t => t.FisId)
                .Index(t => t.FisId);
            
            CreateTable(
                "dbo.Fis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FisKodu = c.String(),
                        FisTuru = c.String(),
                        CariId = c.Int(),
                        BelgeNo = c.String(),
                        Tarih = c.DateTime(nullable: false),
                        PlasiyerId = c.Int(),
                        TeslimEden = c.String(),
                        IskontoOrani = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IskontoTutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ToplamTutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aciklama = c.String(),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                        SirketId = c.Int(nullable: false),
                        DonemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UrunAgaclari",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SirketId = c.Int(),
                        StokId = c.Int(nullable: false),
                        BirimId = c.Int(nullable: false),
                        Kod = c.String(),
                        Aciklama = c.String(),
                        RevizyonNo = c.Int(nullable: false),
                        RevizyonTarihi = c.DateTime(),
                        Carpan = c.Decimal(precision: 12, scale: 6),
                        MakinaId = c.Int(nullable: false),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sirketler", t => t.SirketId)
                .ForeignKey("dbo.StokKartlar", t => t.StokId)
                .Index(t => t.SirketId)
                .Index(t => t.StokId);
            
            CreateTable(
                "dbo.UrunAgacSatirlari",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UrunAgacId = c.Int(nullable: false),
                        UrunId = c.Int(nullable: false),
                        BirimId = c.Int(nullable: false),
                        Miktar = c.Decimal(nullable: false, precision: 12, scale: 6),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StokKartlar", t => t.UrunId)
                .ForeignKey("dbo.UrunAgaclari", t => t.UrunAgacId)
                .Index(t => t.UrunAgacId)
                .Index(t => t.UrunId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        LastName = c.String(),
                        FirstName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        KayitTarihi = c.DateTime(),
                        DegistirmeTarihi = c.DateTime(),
                        KayitUserId = c.Int(),
                        DegistirmeUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            string script =
        @"
        CREATE VIEW [dbo].[LotNumbers]
AS
SELECT        Id, SirketId, DonemId, StokId, BirimId, LotNo,
                             (SELECT        SUM(G.GirisCikisMiktar * CASE WHEN G.BirimId = K.StokBirimId THEN 1 WHEN G.BirimId = K.Birim2Id THEN K.Birim2Pay / K.Birim2Payda WHEN G.BirimId
                                                          = K.Birim3Id THEN K.Birim3Pay / K.Birim3Payda ELSE 0 END) AS Expr1
                               FROM            dbo.StokHareketleri AS G LEFT OUTER JOIN
                                                         dbo.StokKartlar AS K ON K.Id = G.StokId
                               WHERE        (G.StokId = H.StokId) AND (G.GirisCikis = 1)) AS Giris,
                             (SELECT        SUM(G.GirisCikisMiktar * CASE WHEN G.BirimId = K.StokBirimId THEN 1 WHEN G.BirimId = K.Birim2Id THEN K.Birim2Pay / K.Birim2Payda WHEN G.BirimId
                                                          = K.Birim3Id THEN K.Birim3Pay / K.Birim3Payda ELSE 0 END) AS Expr1
                               FROM            dbo.StokHareketleri AS G LEFT OUTER JOIN
                                                         dbo.StokKartlar AS K ON K.Id = G.StokId
                               WHERE        (G.StokId = H.StokId) AND (G.GirisCikis = 2)) AS Cikis,
                             (SELECT        TOP (1) MIN(SKT) AS Expr1
                               FROM            dbo.StokHareketleri AS TH
                               WHERE        (StokId = H.StokId) AND (SKT IS NOT NULL)) AS SKT,
                             (SELECT        TOP (1) MIN(UretimTarihi) AS Expr1
                               FROM            dbo.StokHareketleri AS TH
                               WHERE        (StokId = H.StokId) AND (UretimTarihi IS NOT NULL)) AS UretimTarihi, Tarih,
                             (SELECT        StokBirimId
                               FROM            dbo.StokKartlar
                               WHERE        (Id = H.StokId)) AS StokKartBirimId
FROM            dbo.StokHareketleri AS H";
            Concrete.EntityFramework.ErpContext context = new Concrete.EntityFramework.ErpContext();
            context.Database.ExecuteSqlCommand(script);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UrunAgacSatirlari", "UrunAgacId", "dbo.UrunAgaclari");
            DropForeignKey("dbo.UrunAgacSatirlari", "UrunId", "dbo.StokKartlar");
            DropForeignKey("dbo.UrunAgaclari", "StokId", "dbo.StokKartlar");
            DropForeignKey("dbo.UrunAgaclari", "SirketId", "dbo.Sirketler");
            DropForeignKey("dbo.StokHareketleri", "FisId", "dbo.Fis");
            DropForeignKey("dbo.Kodlar", "SirketId", "dbo.Sirketler");
            DropForeignKey("dbo.Kodlar", "DonemId", "dbo.Donemler");
            DropForeignKey("dbo.IsEmirOperasyonlari", "UrunReceteDetayId", "dbo.UrunReceteDetaylar");
            DropForeignKey("dbo.IsEmirOperasyonlari", "UrunReceteId", "dbo.UrunReceteleri");
            DropForeignKey("dbo.UrunReceteDetaylar", "UrunReceteId", "dbo.UrunReceteleri");
            DropForeignKey("dbo.UrunReceteDetaylar", "StokKartiId", "dbo.StokKartlar");
            DropForeignKey("dbo.UrunReceteDetaylar", "StokBirimId", "dbo.StokBirimler");
            DropForeignKey("dbo.UrunReceteDetaylar", "DepoId", "dbo.Depolar");
            DropForeignKey("dbo.UrunReceteleri", "StokBirim_Id", "dbo.StokBirimler");
            DropForeignKey("dbo.UrunReceteleri", "StokId", "dbo.StokKartlar");
            DropForeignKey("dbo.UrunReceteleri", "SirketId", "dbo.Sirketler");
            DropForeignKey("dbo.UrunReceteleri", "MakinaId", "dbo.Makinalar");
            DropForeignKey("dbo.UrunReceteleri", "DepoId", "dbo.Depolar");
            DropForeignKey("dbo.IsEmirOperasyonlari", "StokKartiId", "dbo.StokKartlar");
            DropForeignKey("dbo.IsEmirOperasyonlari", "StokBirim_Id", "dbo.StokBirimler");
            DropForeignKey("dbo.IsEmirOperasyonlari", "MakinaId", "dbo.Makinalar");
            DropForeignKey("dbo.UretimEmirleri", "UrunId", "dbo.StokKartlar");
            DropForeignKey("dbo.UretimTartimlari", "UretimEmirDetayId", "dbo.UretimEmirDetaylari");
            DropForeignKey("dbo.UretimEmirDetaylari", "UretimEmirId", "dbo.UretimEmirleri");
            DropForeignKey("dbo.UretimEmirleri", "MakinaId", "dbo.Makinalar");
            DropForeignKey("dbo.UretimEmirleri", "DonemId", "dbo.Donemler");
            DropForeignKey("dbo.Makinalar", "SirketId", "dbo.Sirketler");
            DropForeignKey("dbo.Makinalar", "DonemId", "dbo.Donemler");
            DropForeignKey("dbo.IsEmirOperasyonIslemleri", "StokKarti_Id", "dbo.StokKartlar");
            DropForeignKey("dbo.IsEmirOperasyonIslemleri", "IsEmriOperasyonId", "dbo.IsEmirOperasyonlari");
            DropForeignKey("dbo.IsEmirOperasyonIslemleri", "DonemId", "dbo.Donemler");
            DropForeignKey("dbo.IsEmirOperasyonlari", "IsEmriId", "dbo.IsEmirleri");
            DropForeignKey("dbo.IsEmirOperasyonlari", "DonemId", "dbo.Donemler");
            DropIndex("dbo.UrunAgacSatirlari", new[] { "UrunId" });
            DropIndex("dbo.UrunAgacSatirlari", new[] { "UrunAgacId" });
            DropIndex("dbo.UrunAgaclari", new[] { "StokId" });
            DropIndex("dbo.UrunAgaclari", new[] { "SirketId" });
            DropIndex("dbo.StokHareketleri", new[] { "FisId" });
            DropIndex("dbo.Kodlar", new[] { "DonemId" });
            DropIndex("dbo.Kodlar", new[] { "SirketId" });
            DropIndex("dbo.UrunReceteDetaylar", new[] { "DepoId" });
            DropIndex("dbo.UrunReceteDetaylar", new[] { "StokBirimId" });
            DropIndex("dbo.UrunReceteDetaylar", new[] { "StokKartiId" });
            DropIndex("dbo.UrunReceteDetaylar", new[] { "UrunReceteId" });
            DropIndex("dbo.UrunReceteleri", new[] { "StokBirim_Id" });
            DropIndex("dbo.UrunReceteleri", new[] { "MakinaId" });
            DropIndex("dbo.UrunReceteleri", new[] { "DepoId" });
            DropIndex("dbo.UrunReceteleri", new[] { "StokId" });
            DropIndex("dbo.UrunReceteleri", new[] { "SirketId" });
            DropIndex("dbo.UretimTartimlari", new[] { "UretimEmirDetayId" });
            DropIndex("dbo.UretimEmirDetaylari", new[] { "UretimEmirId" });
            DropIndex("dbo.UretimEmirleri", new[] { "UrunId" });
            DropIndex("dbo.UretimEmirleri", new[] { "MakinaId" });
            DropIndex("dbo.UretimEmirleri", new[] { "DonemId" });
            DropIndex("dbo.Makinalar", new[] { "DonemId" });
            DropIndex("dbo.Makinalar", new[] { "SirketId" });
            DropIndex("dbo.IsEmirOperasyonIslemleri", new[] { "StokKarti_Id" });
            DropIndex("dbo.IsEmirOperasyonIslemleri", new[] { "IsEmriOperasyonId" });
            DropIndex("dbo.IsEmirOperasyonIslemleri", new[] { "DonemId" });
            DropIndex("dbo.IsEmirOperasyonlari", new[] { "StokBirim_Id" });
            DropIndex("dbo.IsEmirOperasyonlari", new[] { "UrunReceteDetayId" });
            DropIndex("dbo.IsEmirOperasyonlari", new[] { "UrunReceteId" });
            DropIndex("dbo.IsEmirOperasyonlari", new[] { "MakinaId" });
            DropIndex("dbo.IsEmirOperasyonlari", new[] { "StokKartiId" });
            DropIndex("dbo.IsEmirOperasyonlari", new[] { "IsEmriId" });
            DropIndex("dbo.IsEmirOperasyonlari", new[] { "DonemId" });
            DropTable("dbo.Users");
            DropTable("dbo.UrunAgacSatirlari");
            DropTable("dbo.UrunAgaclari");
            DropTable("dbo.Fis");
            DropTable("dbo.StokHareketleri",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "AnalizSertifikasiGeldimi",
                        new Dictionary<string, object>
                        {
                            { "DefaultValue", "0" },
                        }
                    },
                });
            DropTable("dbo.StokGruplar");
            DropTable("dbo.Kodlar");
            DropTable("dbo.UrunReceteDetaylar");
            DropTable("dbo.UrunReceteleri");
            DropTable("dbo.StokBirimler");
            DropTable("dbo.UretimTartimlari");
            DropTable("dbo.UretimEmirDetaylari");
            DropTable("dbo.UretimEmirleri");
            DropTable("dbo.Sirketler");
            DropTable("dbo.Makinalar");
            DropTable("dbo.StokKartlar");
            DropTable("dbo.IsEmirOperasyonIslemleri");
            DropTable("dbo.IsEmirOperasyonlari");
            DropTable("dbo.IsEmirleri");
            DropTable("dbo.Firmalar");
            DropTable("dbo.Donemler");
            DropTable("dbo.Depolar");
            DropTable("dbo.Paketler");
            Concrete.EntityFramework.ErpContext context = new Concrete.EntityFramework.ErpContext();
            context.Database.ExecuteSqlCommand("DROP VIEW dbo.LotNumbers");
        }
    }
}
