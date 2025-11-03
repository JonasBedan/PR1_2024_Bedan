using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rozhrani
{
    internal class vlak:IVozidlo
    {
        public void Nastartuj()
        {
            Console.WriteLine("startuju vlak");
        }
        public void Zastav()
        {
            Console.WriteLine("zastavuju vlak");
        }
    }
}
