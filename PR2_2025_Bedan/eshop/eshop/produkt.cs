using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop
{
    abstract class produkt:IPolozkaKosiku
    {
        public string NazevProduktu { get; private set; }
        public int cena{ get; private set; }

        public abstract void ZobrazInfo();

        public void VlozDoKosiku()
        {
            Console.WriteLine($"{NazevProduktu} byl přidán do košíku.");
        }
        public void OdstranPolozku()
        {
            Console.WriteLine($"{NazevProduktu} byl odebrán z košíku.");
        }
    }
}
