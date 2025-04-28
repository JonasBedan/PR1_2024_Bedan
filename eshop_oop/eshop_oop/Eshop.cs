using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop_oop
{
    internal class Eshop
    {
        private string nazev;
        private string adresa;
        public List<Polozka> produkty = new List<Polozka>();

        public Eshop(string nazev, string adresa)
        {
            this.nazev = nazev;
            this.adresa = adresa;
            
        }

        public void pridej_polozku(Polozka polozka) 
        {
            produkty.Add(polozka);
        }

        public void zobraz_produkty() 
        {
            if (produkty.Count == 0) 
            { 
                Console.WriteLine("Ještě nebyl přidán produkt"); 
            }
            else 
            { 
                foreach(var polozka in produkty) 
                {
                    Console.WriteLine(polozka);
                }
            }
        }

        public Polozka NejlevnejsiPolozka() 
        {
            if (produkty.Count == 0) 
            {
                Console.WriteLine("neexistuje produkt");
                return null;
            }

            return produkty.OrderBy(p => p.cena).First();//lambda vyraz
        }
    }
}
