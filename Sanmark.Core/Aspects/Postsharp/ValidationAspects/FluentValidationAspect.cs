using FluentValidation;
using PostSharp.Aspects;
using PostSharp.Aspects.Advices;
using PostSharp.Extensibility;
using PostSharp.Reflection;
using PostSharp.Serialization;
using Sanmark.Core.CrossCuttingConcerns.Validation.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Sanmark.Core.Aspects.Postsharp.ValidationAspects
{
    //[Serializable]
    //public class FluentValidationAspect : OnMethodBoundaryAspect
    //{
    //    Type _validatorType;
    //    public FluentValidationAspect(Type validatorType)
    //    {
    //        _validatorType = validatorType; 
    //    }
    //    public override void OnEntry(MethodExecutionArgs args)
    //    {
    //        var validator = (IValidator)Activator.CreateInstance(_validatorType);
    //        var entityType = _validatorType.BaseType.GetGenericArguments()[0];
    //        var entities = args.Arguments;//.Where(t => t.GetType() == entityType);
    //        var test =args.Arguments.Where(t => t.GetType() == entityType);
    //        foreach (var entity in entities)
    //        {
    //            ValidatorTool.FluentValidate(validator, entity);
    //        }
    //    }
    //}

    [PSerializable]
    public class FluentValidationAspect<T> : IMethodLevelAspect
    {
        private Type _validatorType;
        private string _ruleSet;

        public FluentValidationAspect(Type validatorType, string ruleSet = null)
        {
            _validatorType = validatorType;
            _ruleSet = ruleSet;
        }

        public void RuntimeInitialize(MethodBase method)
        {
        }

        [SelfPointcut]
        [OnMethodEntryAdvice]
        public void OnEntry(MethodExecutionArgs args)
        {
            var entities = args.Arguments.Where(x => x is T).Select(x => (T)x);

            var validator = (IValidator<T>)Activator.CreateInstance(_validatorType);
            foreach (var entity in entities)
                ValidatorTool.FluentValidate(validator, entity);
        }
    }
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method)]
    [MulticastAttributeUsage(MulticastTargets.Method)]
    public class FluentValidationAspect : MulticastAttribute, IAspectProvider
    {
        private readonly Type _validatorType;
        private readonly string _ruleSet;

        public FluentValidationAspect(Type validatorType, string ruleSet = null)
        {
            _validatorType = validatorType;
            _ruleSet = ruleSet;
        }

        public IEnumerable<AspectInstance> ProvideAspects(object targetElement)
        {
            var entityType = _validatorType.BaseType?.GetGenericArguments()[0];
            var genericAspectType = typeof(FluentValidationAspect<>).MakeGenericType(entityType);

            yield return new AspectInstance(targetElement, new ObjectConstruction(genericAspectType, new object[] { _validatorType, _ruleSet }));
        }
    }

}
