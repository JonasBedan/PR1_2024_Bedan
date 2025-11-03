using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop
{
    internal class Kosik
    {
        private List<IPolozkaKosiku> ProduktyKosiku = new List<IPolozkaKosiku>();
        public void PridejPolozku(IPolozkaKosiku polozka)
        {
            ProduktyKosiku.Add(polozka);
            polozka.VlozDoKosiku();
        }

        public void vypisKosik()
        {
            foreach(var i in ProduktyKosiku) { Console.WriteLine(i); }
        }

        public void celkovaCena()
        {

            int x = ProduktyKosiku.Sum(p => p.cena);
            Console.WriteLine($"Celková cena nákupu: {x} Kč");
        }

        public void OdeberPolozku(IPolozkaKosiku polozka)
        {
            ProduktyKosiku.Remove(polozka);
            polozka.OdstranPolozku();
        }
    }
}
