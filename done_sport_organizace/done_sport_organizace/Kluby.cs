using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace done_sport_organizace
{
    internal class Kluby
    {
        public string Nazev { get; set; }
        private List<Hrac> hraci = new List<Hrac>();

        public Kluby(string nazev) 
        { 
            Nazev = nazev;
        }

        public void pridej_hrace(Hrac hraci)
        {
            this.hraci.Add(hraci);
        }

        public override string ToString() 
        {
            return $"{Nazev} s {hraci}";
        }

        
    }
}
