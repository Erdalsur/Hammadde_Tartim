using FluentValidation;
using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.Linq;

namespace Sanmark.Erp.Framework.ValidationRules.FluentValidation
{
    public class AmbalajValidator : AbstractValidator<Ambalaj>
    {
        public AmbalajValidator()
        {
            RuleFor(s => s.Ad).NotEmpty().WithName("Ambalaj Adı");
            RuleFor(s => s.Ad).MaximumLength(15).WithName("Ambalaj Adı");
            RuleFor(s => s.SirketId).NotEmpty().WithName("Şirket");
        }
    }
}
