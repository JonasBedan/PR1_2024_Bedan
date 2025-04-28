using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace herni_turnaj_done
{
    internal class Turnaj
    {
        public string nazev {  get; set; }
        public string misto { get; set; }
        public int kapacita { get; set; }
        public string hlavni_cena { get; set; }
        public bool probehl {  get; set; }
        public Hra tema {  get; set; }

        public Turnaj(string nazev, string misto, int kapacita, string hlavni_cena, Hra tema) 
        {
            this.nazev = nazev;
            this.misto = misto;
            this.kapacita = kapacita;
            this.hlavni_cena = hlavni_cena;
            this.probehl = false; 
            this.tema = tema;
        }

        public override string ToString()
        {
            return $"{nazev} ve hře {tema} - {misto} ({kapacita} lidí), hlavní cena:{hlavni_cena} ";
        }
    }
}
