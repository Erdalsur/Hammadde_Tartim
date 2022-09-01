using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;

namespace Sanmark.Core.Utilities.Win.Infrastructure
{
    
    public class CompositionRootNinject
    {
        private static IKernel _ninjectKernel;
        public static void Wire(INinjectModule module)
        {
            _ninjectKernel = new StandardKernel(module);
        }
        public static T Resolve<T>()
        {
            return _ninjectKernel.Get<T>();
        }

        public static IEnumerable<T> ResolveAll<T>()
        {
            return _ninjectKernel.GetAll<T>();
        }
    }
}
