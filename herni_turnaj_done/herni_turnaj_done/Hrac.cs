using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herni_turnaj_done
{
    internal class Hrac
    {
        public string jmeno {  get; set; }
        public string prijmeni { get; set; }
        public int vek {  get; set; }
        public string prezdivka { get; set; }

        public Hrac(string jmeno, string prijmeni, int vek, string prezdivka) 
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.vek = vek;
            this.prezdivka = prezdivka;
        }

        public override string ToString()
        {
            return $"{jmeno} {prijmeni}-{vek}, {prezdivka}";
        }
    }
}
