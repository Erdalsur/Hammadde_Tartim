using System;
using System.ComponentModel;
using System.Linq;

namespace Sanmark.Core.Utilities.Tipler
{
    [Flags]
    public enum IsEmriTipi
    {
        [Description("Belirlenmemiş")]
        Belirlenmemis = 0,
        [Description("Hammadde Tartımı")]
        HammaddeTartim = 1

    }
}
