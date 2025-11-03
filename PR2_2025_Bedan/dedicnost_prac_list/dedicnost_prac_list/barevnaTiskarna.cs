using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedicnost_prac_list
{
    internal class barevnaTiskarna:tiskarna
    {
        public override void tiskni(string obsah)
        {
            Console.WriteLine($"tisknu barvny obsah: {obsah}");
        }
    }
}
