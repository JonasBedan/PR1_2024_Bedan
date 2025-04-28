using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterina_done
{
    internal class Klient
    {
        public string jmeno {  get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }
        public List<Zvire>zvirata { get; set; }

        public Klient(string jmeno, string adresa, string telefon, List<Zvire> zvirata)        {
            this.jmeno = jmeno;
            this.adresa = adresa;
            this.telefon = telefon;
            this.zvirata = zvirata;
        }

        public Klient(string jmeno, string adresa, string telefon, Zvire zvire)//pro jedno        {
            this.jmeno = jmeno;
            this.adresa = adresa;
            this.telefon = telefon;
            this.zvirata = new List<Zvire> { zvire };
        }

        public override string ToString()
        {
            return $"{jmeno} - {adresa} - {telefon}, {zvirata}";
        }

    }
}
