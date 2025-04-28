using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herni_turnaj_done
{
    internal class Prihlaska
    {
        public Hrac h {  get; set; }
        public Turnaj t { get; set; }
        public string datum {  get; set; }

        public Prihlaska(Hrac h, Turnaj t, string datum) 
        {
            this.h = h;
            this.t = t;
            this.datum = datum;
        }

        public override string ToString()
        {
            return $"hlásí se:{h} ,na turnaj:{t} ,dne:{datum}";
        }
    }
}
