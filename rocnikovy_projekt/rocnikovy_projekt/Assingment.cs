using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocnikovy_projekt
{
    internal class Assingment
    {
        public string jmeno {  get; set; }
        public bool splneno { get; set; }
        public DateTime? datum_splneni { get; set; }
        public Assingment(string jmeno, bool splneno)
        {
            this.jmeno = jmeno;
            this.splneno = splneno;
            datum_splneni = DateTime.Now;
        }

       

        public override string ToString() 
        {
            string Splneno;
            if (splneno == true) 
            {
                Splneno = "Splněno";
                Console.ForegroundColor = ConsoleColor.Green;
                return jmeno + " - " + Splneno + " " + datum_splneni;
                
            }
            else
            {
                Splneno = "Nesplněno";
                Console.ForegroundColor = ConsoleColor.Red;
                return jmeno + " - " + Splneno + " " + datum_splneni;
            }
            
        }
    }
}
