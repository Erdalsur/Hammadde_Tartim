using System;
using System.ComponentModel;
using System.Linq;

namespace Sanmark.Core.Utilities.Tipler
{
    [Flags]
    public enum StokTipi
    {
        [Description("Seçiniz...")]
        None = 0,
        [Description("Hammadde")]
        Hammadde = 1,
        [Description("Yarı Mamül")]
        YariMamul = 2,
        [Description("Mamül")]
        Mamul = 4,
        [Description("Ambalaj Malzemeleri")]
        Ambalaj =8

    }
}
