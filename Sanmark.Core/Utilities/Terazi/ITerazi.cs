using System;
using System.ComponentModel;
using System.Linq;

namespace Sanmark.Core.Utilities.Terazi
{
    public interface ITerazi
    {
        TeraziData TeraziData { get; set; }
        void Baglan();
        bool DataOk { get; set; }
    }
}
