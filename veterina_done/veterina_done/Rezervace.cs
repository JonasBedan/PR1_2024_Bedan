using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterina_done
{
    internal class Rezervace
    {
        public Klient k {  get; set; }
        public Veterinar v {  get; set; }
        public string duvodNavstevy { get; set; }
        public bool navstiveno { get; set; }
        List <Zvire> zvirata {  get; set; }

        public Rezervace(Klient k, Veterinar v, string duvodNavstevy, bool navstiveno, Zvire zvire)
        {
            this.k = k;
            this.v = v;
            this.duvodNavstevy = duvodNavstevy;
            this.navstiveno = navstiveno;
            this.zvirata = new List<Zvire> { zvire };
        }

        public Rezervace(Klient k, Veterinar v, string duvodNavstevy, bool navstiveno, List<Zvire> zvirata)//pro více zvířat
        {
            this.k = k;
            this.v = v;
            this.duvodNavstevy = duvodNavstevy;
            this.navstiveno = navstiveno;
            this.zvirata = zvirata;
        }


    }
}
