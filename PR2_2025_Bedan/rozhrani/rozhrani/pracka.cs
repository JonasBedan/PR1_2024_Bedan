using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rozhrani
{
    internal class pracka:ISpotrebic
    {
        public void ZapojDoSite()
        {
            Console.WriteLine("pracka je siti");
        }

        public void OdpojOdSite()
        {
            Console.WriteLine("pracka neni v sit");
        }
    }
}
