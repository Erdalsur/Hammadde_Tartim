using System;
using System.ComponentModel;
using System.Linq;

namespace Sanmark.Core.Utilities.Tipler
{
    [Flags]
    public enum FirmaTipi
    {
        [Description("Seçiniz...")]
        None = 0,
        [Description("Satıcı")]
        Satici = 1,
        [Description("Müşteri")]
        Musteri = 2,
        [Description("Hem Satıcı, Hem Müşteri")]
        SaticiveMusteri = 4

    }
    [Flags]
    public enum FirmaKartTipi
    {
        [Description("Seçiniz...")]
        None = 0,
        [Description("Tüzel")]
        Tuzel = 1,
        [Description("Şahıs")]
        Sahis = 2
    }
}
