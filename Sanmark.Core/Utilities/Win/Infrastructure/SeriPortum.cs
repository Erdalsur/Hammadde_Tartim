using System;

namespace Sanmark.Core.Utilities.Win.Infrastructure
{
    public class SeriPortum
    {
        public string PortName { get; set; }
        public int BaundRate { get; set; }
        public int DataBits { get; set; }
        public System.IO.Ports.StopBits StopBits { get; set; }
        public System.IO.Ports.Parity Parity { get; set; }


    }
}
