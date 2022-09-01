using FluentValidation.Validators;
using Sanmark.Core.Entities;
using Sanmark.Erp.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;
using System.Threading.Tasks;

namespace Sanmark.Erp.Framework.Extensions.FluentValidation
{
    public class UniqueValidator<TEntity> : PropertyValidator
        where TEntity:class,IEntity,new()
    {
        public UniqueValidator():base("Girdiğiniz {PropertyName} kayıtlarda var.")
        {

        }
        protected override bool IsValid(PropertyValidatorContext context)
        {
            using (var erpContext = new ErpContext())
            {
                var result = erpContext.Set<TEntity>().Where($"{context.PropertyName}==@0",context.PropertyValue).Count();
                return result == 0 ? true : false;
            }
        }
    }
}
