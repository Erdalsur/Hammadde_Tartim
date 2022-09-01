using FluentValidation;
using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.Linq;

namespace Sanmark.Erp.Framework.ValidationRules.FluentValidation
{
    public class StokKartValidator : AbstractValidator<StokKarti>
    {
        public StokKartValidator()
        {
            RuleFor(s => s.Kod).NotEmpty().WithName("Stok Kodu");
            RuleFor(s => s.Kod).MaximumLength(30).WithName("Stok Kodu");
            RuleFor(s=>s.Ad).NotEmpty().WithName("Stok Adı");
            RuleFor(s => s.Ad).MaximumLength(50).WithName("Stok Adı");
            RuleFor(s=>s.StokBirimId).GreaterThan(0).WithName("Stok Birimi").WithMessage("'Stok Birimi' Boş Olamaz");
            RuleFor(s => s.StokGrupId).GreaterThan(0).WithName("Stok Grubu").WithMessage("'Stok Grubu' Boş Olamaz"); ;
            RuleFor(s => s.Tip).GreaterThan((Int16)0).WithName("Stok Türü").WithMessage("'Stok Türü' Boş Olamaz"); ;
            RuleFor(s => s.SirketId).GreaterThan(0).WithName("Şirket").WithMessage("'Sirket' Boş Olamaz"); ;
            RuleFor(s => s.AmbalajId).GreaterThan(0).WithName("Ambalaj Şekli").WithMessage("'Amalaj Şekli' Boş Olamaz"); ;
            RuleFor(s => s.Barkod).MaximumLength(250).WithName("Barkodu");
        }
    }
}
