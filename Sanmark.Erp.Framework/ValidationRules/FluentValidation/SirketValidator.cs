using FluentValidation;
using Sanmark.Erp.Entities.Concrete;
using System;
using System.Linq;

namespace Sanmark.Erp.Framework.ValidationRules.FluentValidation
{
    public class SirketValidator:AbstractValidator<Sirket>
    {
        public SirketValidator()
        {
            RuleFor(s => s.Ad).NotEmpty().WithName("Ünvan");//.WithMessage("Ünvanı boş olamaz");
            RuleFor(s => s.Ad).MaximumLength(50).WithName("Ünvan");
            RuleFor(s => s.Email).EmailAddress().WithName("E-mail Adres").When(i => !string.IsNullOrEmpty(i.Email));
            RuleFor(s => s.Email).MaximumLength(50).WithName("E-mail Adres");

        }
    }
}
