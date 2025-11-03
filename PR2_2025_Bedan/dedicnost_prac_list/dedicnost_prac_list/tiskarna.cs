using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedicnost_prac_list
{
    internal class tiskarna
    {
        public virtual void tiskni(string obsah) 
        {
            Console.WriteLine($"tisknu obsah: {obsah}");
        }
    }
}
