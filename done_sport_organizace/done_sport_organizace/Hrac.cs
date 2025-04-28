using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace done_sport_organizace
{
    internal class Hrac
    {
        public string Jmeno { get; private set; }
        public int Cislo { get; private set; }
        public string Narodnost { get; private set; }
        public Kluby Tym { get; private set; }

        public Hrac(string jmeno, int cislo, string narodnost, Kluby klub) 
        {
            Jmeno = jmeno;
            Cislo = cislo;
            Narodnost = narodnost;
            Tym = klub;
        }

        public override string ToString() 
        {
            return $"{Jmeno} - {Cislo}, {Narodnost}, Tým: {Tym}";
        }
    }
}
