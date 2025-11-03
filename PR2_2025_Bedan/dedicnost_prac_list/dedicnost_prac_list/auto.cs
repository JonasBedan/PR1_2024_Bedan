using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedicnost_prac_list
{
    internal class auto:dopravniProstredek
    {

        public void zapniMotor()
        {
            Console.WriteLine("motor je zapnutý");
        }
        public override void jizda()
        {
            Console.WriteLine("auto jede");
        }
    }
}
