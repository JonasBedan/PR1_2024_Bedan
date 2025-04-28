using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_oop
{
    internal class Polozka
    {
        public string nazev { get; set; }
        public double cena { get; set; }
        public string vyrobce {  get; set; }

        public Polozka(string nazev, double cena, string vyrobce)
        {
            this.nazev = nazev;
            this.cena = cena;
            this.vyrobce = vyrobce;
        }

        public override string ToString() 
        {
            return $"{nazev}: {cena} Kč, Výrobce: {vyrobce}";
        }
    }
}
