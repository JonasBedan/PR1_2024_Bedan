using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rozhrani
{
    internal class motocykl:IVozidlo
    {
        public void Nastartuj()
        {
            Console.WriteLine("startuju motocykl");
        }
        public void Zastav()
        {
            Console.WriteLine("zastavuju motocykl");
        }
    }
}
