using System;
using System.ComponentModel;
using System.Linq;

namespace Sanmark.Core.Utilities.Tipler
{
    [Flags]
    public enum HareketTuru
    {
        [Description("Seçiniz...")]
        None = 0,
        [Description("Hammadde Tartımı")]
        HammaddeTartim = 1,
        [Description("Depo Giriş-Çıkış Fişi")]
        GirisFisi = 2,
        [Description("Depo Transfer Fişi")]
        DepoTransfer = 4
    }
}
