using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student = new student();
            student.NapisTest();
            ucitel ucitel = new ucitel();
            ucitel.jmeno = "a";
            Console.WriteLine(ucitel.jmeno);
            ucitel.OpravTest();
            ucitel.pozdrav();
        }
    }
}
