using FluentValidation;
using Sanmark.Erp.Entities.Concrete.Cari;
using System;
using System.Linq;

namespace Sanmark.Erp.Framework.ValidationRules.FluentValidation
{
    public class FirmaValidator : AbstractValidator<Firma>
    {
        public FirmaValidator()
        {
            RuleFor(s => s.Ad).NotEmpty().WithName("Ünvan/Ad");//.WithMessage("Ünvanı boş olamaz");
            RuleFor(s => s.Ad).MaximumLength(100).WithName("Ünvan/Ad");
            RuleFor(s => s.Kod).MaximumLength(100).WithName("Kod");
            //RuleFor(s => s.Email).EmailAddress().WithName("E-mail Adres").When(i => !string.IsNullOrEmpty(i.Email));
            //RuleFor(s => s.Email).MaximumLength(50).WithName("E-mail Adres");

        }
    }
}
