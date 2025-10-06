using System;
using System.Collections.Generic;

namespace Uloha7_EvidenceVozidel
{
    class Auto
    {
        public string Znacka { get; set; }
        public string Model { get; set; }
        public int RokVyroby { get; set; }
        public int NajeteKilometry { get; set; }

        public Auto(string znacka, string model, int rokVyroby, int najeteKilometry)
        {
            Znacka = znacka;
            Model = model;
            RokVyroby = rokVyroby;
            NajeteKilometry = najeteKilometry;
        }

        public void VypisInformace()
        {
            Console.WriteLine($"Značka: {Znacka}, Model: {Model}, Rok výroby: {RokVyroby}, Najeté km: {NajeteKilometry}");
        }
    }

    class Autopark
    {
        public List<Auto> Vozidla { get; set; }

        public Autopark()
        {
            Vozidla = new List<Auto>();
        }

        public void PridejVozidlo(Auto auto)
        {
            Vozidla.Add(auto);
            Console.WriteLine($"Vozidlo {auto.Znacka} {auto.Model} bylo přidáno.");
        }

        public void OdeberVozidlo(string znacka, string model)
        {
            Auto nalezene = null;
            foreach (Auto auto in Vozidla)
            {
                if (auto.Znacka == znacka && auto.Model == model)
                {
                    nalezene = auto;
                    break;
                }
            }

            if (nalezene != null)
            {
                Vozidla.Remove(nalezene);
                Console.WriteLine($"Vozidlo {znacka} {model} bylo odebráno.");
            }
            else
            {
                Console.WriteLine($"Vozidlo {znacka} {model} nebylo nalezeno.");
            }
        }

        public void VypisVsechnaVozidla()
        {
            if (Vozidla.Count == 0)
            {
                Console.WriteLine("V autoparku nejsou žádná vozidla.");
            }
            else
            {
                Console.WriteLine("\nSeznam vozidel v autoparku:");
                foreach (Auto auto in Vozidla)
                {
                    auto.VypisInformace();
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Úloha 7: Evidence vozidel ===\n");

            Autopark autopark = new Autopark();

            autopark.PridejVozidlo(new Auto("Škoda", "Octavia", 2020, 45000));
            autopark.PridejVozidlo(new Auto("BMW", "X5", 2019, 60000));
            autopark.PridejVozidlo(new Auto("Audi", "A4", 2021, 25000));
            autopark.PridejVozidlo(new Auto("Mercedes", "C-Class", 2018, 80000));

            autopark.VypisVsechnaVozidla();

            Console.WriteLine();
            autopark.OdeberVozidlo("BMW", "X5");

            autopark.VypisVsechnaVozidla();

            Console.WriteLine("\nProgram ukončen. Stiskněte libovolnou klávesu...");
            Console.ReadKey();
        }
    }
}

