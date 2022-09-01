using FluentValidation;
using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.Linq;

namespace Sanmark.Erp.Framework.ValidationRules.FluentValidation
{
    public class StokGrupValidator : AbstractValidator<StokGrup>
    {
        public StokGrupValidator()
        {
            
            RuleFor(s => s.Ad).MaximumLength(50).WithName("Grup Adı");
            RuleFor(s => s.SirketId).GreaterThan(0).WithName("Şirket").WithMessage("'Sirket' Boş Olamaz"); ;
            RuleFor(s => s.Ad).NotEmpty().WithName("Grup Adı");
        }
    }
}
