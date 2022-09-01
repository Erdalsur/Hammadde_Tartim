using System;
using System.ComponentModel;
using System.Linq;

namespace Sanmark.Core.Utilities.Tipler
{
    [Flags]
    public enum AnalizSerifikası
    {
        [Description("Yok")]
        None = 0,
        [Description("Geldi")]
        Geldi = 1,
        [Description("Bekleniyor")]
        Bekleniyor = 2
    }
}
