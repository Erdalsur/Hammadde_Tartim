using FluentValidation;
using Sanmark.Erp.Entities.Concrete.Stok;
using System;
using System.Linq;

namespace Sanmark.Erp.Framework.ValidationRules.FluentValidation
{
    public class FisValidator : AbstractValidator<Fis>
    {
        public FisValidator()
        {

        }
    }
}
