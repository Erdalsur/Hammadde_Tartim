using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanmark.Core.Utilities.Terazi
{
    public interface ITeraziService
    {
        TeraziData GetTeraziData();
    }
}
