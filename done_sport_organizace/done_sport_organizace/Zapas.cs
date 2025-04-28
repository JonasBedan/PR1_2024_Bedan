using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace done_sport_organizace
{
    internal class Zapas
    {
        private string lokace;
        private string datum;
        private string vysledek;
        
        public Zapas (string lokace, string datum, string vysledek) 
        {
            this.lokace = lokace;
            this.datum = datum;
            this.vysledek = vysledek;
        }

        public override string ToString()
        {
            return $"{vysledek} dne {datum} v {lokace}";   
        }
    }
}
