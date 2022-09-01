using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sanmark.Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public class ValidatorTool
    {
        //public static void FluentValidate(IValidator validator, object entity)
        //{
        //    var result = validator.Validate(entity);

        //    if (result.Errors.Count > 0)
        //    {
        //        throw new ValidationException(result.Errors);
        //    }
        //}
        public static void FluentValidate(IValidator validator, object entity)
        {
            var result = validator.Validate(entity);
            if (result.Errors.Any())
                throw new ValidationException(result.Errors);
        }

        public static void FluentValidate<T>(IValidator<T> validator, T entity, string ruleSet) where T : class, new()
        {
            var result = validator.Validate(entity, ruleSet: ruleSet);
            if (result.Errors.Any())
                throw new ValidationException(result.Errors);
        }

    }
    
}
