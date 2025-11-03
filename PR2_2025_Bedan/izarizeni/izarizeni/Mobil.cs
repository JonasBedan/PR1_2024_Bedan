using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izarizeni
{
    internal class Mobil:iZarizeni
    {
        public void Vypnout()
        {
            Console.WriteLine("mobil vypnut");
        }
        public void Zapnout()
        {
            Console.WriteLine("mobil zapnut");
        }
    }
}
