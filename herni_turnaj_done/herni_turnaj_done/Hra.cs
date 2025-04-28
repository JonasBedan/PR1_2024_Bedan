using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herni_turnaj_done
{
    internal class Hra
    {
        public string nazev {  get; set; }
        public string casova_narocnost { get; set; }
        public int pocet_hracu {  get; set; }

        public Hra (string nazev, string casova_narocnost,  int pocet_hracu) 
        {
            this.nazev = nazev;
            this.casova_narocnost = casova_narocnost;
            this.pocet_hracu = pocet_hracu;
        }

        public override string ToString()
        {
            return $"{nazev}, {casova_narocnost} - {pocet_hracu} hráčů";
        }
    }
}
