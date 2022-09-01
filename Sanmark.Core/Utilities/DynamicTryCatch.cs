using Sanmark.Core.Aspects.Postsharp.ExceptionAspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanmark.Core.Utilities
{
    public class DynamicTryCatch
    {
        /// <summary>
        /// Try-Catch Merkezi Kullanımı 
        /// </summary>
        /// <param name="action"></param>
        /// <param name="metodAdi"></param>
        /// DynamicTryCatch.TryCatch(() =>
        ///    {
        ///        Komutlar
        ///    }, MethodBase.GetCurrentMethod().Name);
        [ExceptionLogAspect()]
        public static void TryCatch(Action action, string metodAdi)
        {
            try
            {
                action();
            }
            catch (Exception Ex)
            {

            }
        }
    }
}
