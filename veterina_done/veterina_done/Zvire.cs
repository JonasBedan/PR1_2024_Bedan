using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterina_done
{
    internal class Zvire
    {
        public string jmeno {  get; set; }
        public string druh { get; set; }
        public int vek { get; set; }

        public Zvire(string jmeno, string druh, int vek) 
        {
            this.jmeno = jmeno;
            this.druh = druh;
            this.vek = vek;
        }

        public override string ToString()
        {
            return $"{jmeno}, {druh} - {vek}";
        }
    }
}
