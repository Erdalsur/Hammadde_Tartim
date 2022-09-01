using Sanmark.Core.Aspects.Postsharp.PerformanceAspects;
using System;
using System.ComponentModel;
using System.Linq;

namespace Sanmark.Core.Utilities.Terazi
{
    public class TeraziManager : ITeraziService
    {
        ITerazi _terazi;
        
        public TeraziManager(ITerazi terazi)
        {
            _terazi = terazi;
        }
        [PerformanceCounterAspect]
        public TeraziData GetTeraziData()
        {
            //Düzgün Data Alınacak
            TeraziData data = null;
            _terazi.Baglan();
            while(!_terazi.DataOk)
            {
                data = _terazi.TeraziData;
            }
            return data;
        }

        
    }
}
