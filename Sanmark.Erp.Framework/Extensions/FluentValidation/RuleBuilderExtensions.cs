using FluentValidation;
using Sanmark.Core.Entities;
using System;
using System.Linq;

namespace Sanmark.Erp.Framework.Extensions.FluentValidation
{
    public static class RuleBuilderExtensions
    {
        public static IRuleBuilderOptions<TEntity,object> IsUnique<TEntity>(this IRuleBuilder<TEntity, object> ruleBuilder)
            where TEntity:class,IEntity, new()
        {
            return ruleBuilder.SetValidator(new UniqueValidator<TEntity>());
        }
    }
}
