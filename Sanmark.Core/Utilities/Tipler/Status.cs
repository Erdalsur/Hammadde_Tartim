using System;
using System.ComponentModel;
using System.Linq;

namespace Sanmark.Core.Utilities.Tipler
{
    [Flags]
    public enum Status
    {
        [Description("Yeni Kayıt")]
        Yeni = 1,
        [Description("Yeni Kayıt - Otomatik")]
        OtomatikYeni = 2,
        [Description("Hazırlanıyor")]
        Hazirlaniyor = 4,        
        [Description("Tamamlandı")]
        Tamam=8,
        [Description("Eksik Üretim - Otomatik")]
        EksikUretim = 16,
        [Description("Üretim Değişikliği - Otomatik")]
        DegisiklikVar = 32

    }
}
