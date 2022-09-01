using FluentValidation;
using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.Linq;

namespace Sanmark.Erp.Framework.ValidationRules.FluentValidation
{
    public class StokBirimValidator : AbstractValidator<StokBirim>
    {
        public StokBirimValidator()
        {
            RuleFor(s => s.Kod).NotEmpty().WithName("Birim Kodu");
            RuleFor(s => s.Kod).MaximumLength(15).WithName("Birim Kodu");
            RuleFor(s => s.Ad).NotEmpty().WithName("Birim Adı");
            RuleFor(s => s.Ad).MaximumLength(50).WithName("Birim Adı");
            RuleFor(s => s.SirketId).GreaterThan(0).WithName("Şirket").WithMessage("'Sirket' Boş Olamaz"); ;

        }
    }
}
