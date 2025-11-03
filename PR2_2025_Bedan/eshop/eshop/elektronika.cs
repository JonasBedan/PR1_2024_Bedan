using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop
{
    internal class elektronika:produkt
    {
        public int Zaruka {  get; set; }
        public override void ZobrazInfo()
        {
            Console.WriteLine(NazevProduktu);
            Console.WriteLine($"Cena: {cena} Kč");
            Console.WriteLine($"Záruka: {Zaruka} roky");
            Console.WriteLine();
        }
    }
}
