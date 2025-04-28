using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herni_turnaj_done
{
    internal class Historie
    {
        public string datum {  get; set; }
        public int cena { get; set; }
        public string nazev_turnaje { get; set; }

        public Historie(string datum, int cena, string nazev_turnaje) 
        {
            this.datum = datum;
            this.cena = cena;
            this.nazev_turnaje = nazev_turnaje;
        }

        public override string ToString()
        {
            return $"dne {datum} se konal {nazev_turnaje}, cena:{cena}";
        }
    }
}
