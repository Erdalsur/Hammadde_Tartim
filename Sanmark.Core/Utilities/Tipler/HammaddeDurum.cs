using System;
using System.ComponentModel;
using System.Linq;

namespace Sanmark.Core.Utilities.Tipler
{
    [Flags]
    public enum HammaddeDurum
    {
        [Description("Seçiniz...")]
        None = 0,
        [Description("Karantina Uygulansın")]
        Karantina = 1,
        [Description("Depoya Alınsın")]
        Depo = 2

    }
}
