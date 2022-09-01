using System;
using System.Linq;

namespace Sanmark.Core.Utilities.Terazi
{
    public delegate void TeraziDataOkEventHandler();
    public class TeraziData
    {
        public event TeraziDataOkEventHandler TeraziTamam;

        public int Adet { get; set; }
        public DateTime Tarih { get; set; }
        decimal net;
        public decimal Net
        {
            get => net;
            set
            {
                if (net == value)
                {
                    return;
                }
                net = value;
                TeraziTamam();
                
            }
        }
        public decimal Dara { get; set; }
        public decimal Brut { get; set; }
        public string Birim { get; set; }

    }
}
