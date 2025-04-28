using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterina_done
{
    internal class Veterinar
    {
        public string jmeno {  get; set; }
        public string specializace { get; set; }

        public Veterinar(string jmeno, string specializace) 
        {
            this.jmeno = jmeno;
            this.specializace = specializace;
        }

        public override string ToString() 
        {
            return $"{jmeno} {specializace}";
        }
    }
}
