using Sanmark.Core.Utilities.Tipler;
using Sanmark.Erp.Entities.ComplexTypes.Uretim;
using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Sanmark.Erp.Framework.Abstract
{
    public interface IStokHareketService
    {
        List<StokHareket> GetAll(Expression<Func<StokHareket, bool>> filter = null);
        StokHareket GetById(int id);
        void Add(StokHareket stokHareket);
        void Update(StokHareket stokHareket);
        void Delete(StokHareket stokHareket);
        List<StokHareketListe> StokHareketListesi(Expression<Func<StokHareket, bool>> filter = null);

        List<Fis> GetAllFis(Expression<Func<Fis, bool>> filter = null);
        Fis GetByIdFis(int id);
        Fis AddFis(Fis stokHareket, HareketTuru hareketTuru = HareketTuru.GirisFisi);
        void UpdateFis(Fis stokHareket);
        void DeleteFis(Fis stokHareket);
        List<LotListesi> LotListesi(Expression<Func<LotListesi, bool>> filter = null);
    }

}
