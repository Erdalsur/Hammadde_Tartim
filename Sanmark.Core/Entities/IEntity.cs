using System;

namespace Sanmark.Core.Entities
{
    public interface IEntity
    {
        DateTime? KayitTarihi { get; set; }
        DateTime? DegistirmeTarihi { get; set; }
        int? KayitUserId { get; set; }
        int? DegistirmeUserId { get; set; }
    }
}
