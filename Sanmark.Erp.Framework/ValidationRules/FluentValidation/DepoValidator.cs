using FluentValidation;
using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Framework.Extensions.FluentValidation;

namespace Sanmark.Erp.Framework.ValidationRules.FluentValidation
{
    public class DepoValidator : AbstractValidator<Depo>
    {
        public DepoValidator()
        {
            RuleFor(s => s.Kod).NotEmpty().WithName("Depo Kodu");
            RuleFor(s => s.Kod).IsUnique();// Extensions ile kayıt var mı diye kontrol ediyor.
            RuleFor(s => s.Kod).MaximumLength(15).WithName("Depo Kodu");
            RuleFor(s => s.Ad).NotEmpty().WithName("Depo Adı");
            RuleFor(s => s.Ad).MaximumLength(50).WithName("Depo Adı");
            RuleFor(s => s.SirketId).GreaterThan(0).WithName("Şirket").WithMessage("'Sirket' Boş Olamaz"); ;

        }
    }
}
