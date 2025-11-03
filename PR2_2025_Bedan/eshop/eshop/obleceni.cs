using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop
{
    internal class obleceni:produkt
    {
        public string Velikost { get; set; }
        public string Materiál {  get; set; }

        public override void ZobrazInfo()
        {
            Console.WriteLine(NazevProduktu);
            Console.WriteLine($"Cena: {cena} Kč");
            Console.WriteLine($"Velikost: {Velikost} Materiál: {Materiál}");
            Console.WriteLine();
        }
    }
}
