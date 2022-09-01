using FluentValidation;
using Sanmark.Erp.Entities.Concrete;
using System;
using System.Linq;

namespace Sanmark.Erp.Framework.ValidationRules.FluentValidation
{
    public class KodValidator : AbstractValidator<Kod>
    {
        public KodValidator()
        {

        }
    }
}
