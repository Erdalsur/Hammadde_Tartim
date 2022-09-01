using System;
using System.ComponentModel;
using System.Linq;

namespace Sanmark.Core.Utilities.Tipler
{
    [Flags]
    public enum StokGirisCikis
    {
        [Description("Seçiniz...")]
        None = 0,
        [Description("Giriş")]
        Giris = 1,
        [Description("Çıkış")]
        Cikis = 2


    }
}
