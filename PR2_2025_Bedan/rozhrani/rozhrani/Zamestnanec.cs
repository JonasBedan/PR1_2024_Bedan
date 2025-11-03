using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rozhrani
{
    abstract class Zamestnanec
    {
        public string name {  get; set; }
        public string plat {  get; set; }

        public abstract void Pracuj();
    }
}
