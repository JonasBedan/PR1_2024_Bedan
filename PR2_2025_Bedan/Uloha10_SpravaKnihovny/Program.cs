using System;
using System.Collections.Generic;

namespace Uloha10_SpravaKnihovny
{
    class Kniha
    {
        public string Nazev { get; set; }
        public string Autor { get; set; }
        public int RokVydani { get; set; }
        public int PocetStran { get; set; }

        public Kniha(string nazev, string autor, int rokVydani, int pocetStran)
        {
            Nazev = nazev;
            Autor = autor;
            RokVydani = rokVydani;
            PocetStran = pocetStran;
        }

        public void VypisInformace()
        {
            Console.WriteLine($"Název: {Nazev}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Rok vydání: {RokVydani}");
            Console.WriteLine($"Počet stran: {PocetStran}");
            Console.WriteLine("---");
        }
    }

    class Knihovna
    {
        public string Nazev { get; set; }
        public List<Kniha> Knihy { get; set; }

        public Knihovna(string nazev)
        {
            Nazev = nazev;
            Knihy = new List<Kniha>();
        }

        public void PridejKnihu(Kniha kniha)
        {
            Knihy.Add(kniha);
            Console.WriteLine($"\nKniha '{kniha.Nazev}' byla přidána do knihovny.");
        }

        public void OdeberKnihu(string nazev)
        {
            Kniha nalezena = null;
            foreach (Kniha kniha in Knihy)
            {
                if (kniha.Nazev.Equals(nazev, StringComparison.OrdinalIgnoreCase))
                {
                    nalezena = kniha;
                    break;
                }
            }

            if (nalezena != null)
            {
                Knihy.Remove(nalezena);
                Console.WriteLine($"\nKniha '{nazev}' byla odebrána z knihovny.");
            }
            else
            {
                Console.WriteLine($"\nKniha '{nazev}' nebyla nalezena.");
            }
        }

        public void VypisVsechnyKnihy()
        {
            if (Knihy.Count == 0)
            {
                Console.WriteLine("\nKnihovna neobsahuje žádné knihy.");
            }
            else
            {
                Console.WriteLine($"\n=== Knihy v knihovně {Nazev} ({Knihy.Count} knih) ===");
                foreach (Kniha kniha in Knihy)
                {
                    kniha.VypisInformace();
                }
            }
        }

        public Kniha NajdiKnihuPodleNazvu(string nazev)
        {
            foreach (Kniha kniha in Knihy)
            {
                if (kniha.Nazev.Equals(nazev, StringComparison.OrdinalIgnoreCase))
                {
                    return kniha;
                }
            }
            return null;
        }

        public void VypisKnihyOdAutora(string autor)
        {
            List<Kniha> knihyAutora = new List<Kniha>();
            
            foreach (Kniha kniha in Knihy)
            {
                if (kniha.Autor.Equals(autor, StringComparison.OrdinalIgnoreCase))
                {
                    knihyAutora.Add(kniha);
                }
            }

            if (knihyAutora.Count == 0)
            {
                Console.WriteLine($"\nŽádné knihy od autora '{autor}' nebyly nalezeny.");
            }
            else
            {
                Console.WriteLine($"\n=== Knihy od autora {autor} ({knihyAutora.Count}) ===");
                foreach (Kniha kniha in knihyAutora)
                {
                    kniha.VypisInformace();
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Úloha 10: Správa knihovny ===\n");

            Knihovna knihovna = new Knihovna("Městská knihovna");

            knihovna.PridejKnihu(new Kniha("Hobit", "J.R.R. Tolkien", 1937, 310));
            knihovna.PridejKnihu(new Kniha("Pán prstenů", "J.R.R. Tolkien", 1954, 1178));
            knihovna.PridejKnihu(new Kniha("1984", "George Orwell", 1949, 328));
            knihovna.PridejKnihu(new Kniha("Farma zvířat", "George Orwell", 1945, 112));
            knihovna.PridejKnihu(new Kniha("Válka s mloky", "Karel Čapek", 1936, 348));
            knihovna.PridejKnihu(new Kniha("R.U.R.", "Karel Čapek", 1920, 96));
            knihovna.PridejKnihu(new Kniha("Babička", "Božena Němcová", 1855, 224));
            knihovna.PridejKnihu(new Kniha("Poslední Mohykán", "James Fenimore Cooper", 1826, 464));
            knihovna.PridejKnihu(new Kniha("Harry Potter a Kámen mudrců", "J.K. Rowling", 1997, 223));
            knihovna.PridejKnihu(new Kniha("Stařec a moře", "Ernest Hemingway", 1952, 127));

            bool pokracovat = true;
            
            while (pokracovat)
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1 - Přidat knihu");
                Console.WriteLine("2 - Odebrat knihu");
                Console.WriteLine("3 - Vyhledat knihu podle názvu");
                Console.WriteLine("4 - Zobrazit knihy od autora");
                Console.WriteLine("5 - Zobrazit všechny knihy");
                Console.WriteLine("0 - Ukončit program");
                Console.Write("\nVyberte možnost: ");

                string volba = Console.ReadLine();

                switch (volba)
                {
                    case "1":
                        Console.Write("\nZadejte název knihy: ");
                        string nazev = Console.ReadLine();
                        
                        Console.Write("Zadejte autora: ");
                        string autor = Console.ReadLine();
                        
                        Console.Write("Zadejte rok vydání: ");
                        int rok;
                        while (!int.TryParse(Console.ReadLine(), out rok))
                        {
                            Console.Write("Neplatný rok! Zadejte znovu: ");
                        }
                        
                        Console.Write("Zadejte počet stran: ");
                        int strany;
                        while (!int.TryParse(Console.ReadLine(), out strany))
                        {
                            Console.Write("Neplatný počet stran! Zadejte znovu: ");
                        }
                        
                        knihovna.PridejKnihu(new Kniha(nazev, autor, rok, strany));
                        break;

                    case "2":
                        Console.Write("\nZadejte název knihy k odebrání: ");
                        string nazevKOdebrani = Console.ReadLine();
                        knihovna.OdeberKnihu(nazevKOdebrani);
                        break;

                    case "3":
                        Console.Write("\nZadejte název knihy k vyhledání: ");
                        string nazevKVyhledani = Console.ReadLine();
                        Kniha nalezenaKniha = knihovna.NajdiKnihuPodleNazvu(nazevKVyhledani);
                        
                        if (nalezenaKniha != null)
                        {
                            Console.WriteLine("\nKniha nalezena:");
                            nalezenaKniha.VypisInformace();
                        }
                        else
                        {
                            Console.WriteLine($"\nKniha '{nazevKVyhledani}' nebyla nalezena.");
                        }
                        break;

                    case "4":
                        Console.Write("\nZadejte jméno autora: ");
                        string autorKVyhledani = Console.ReadLine();
                        knihovna.VypisKnihyOdAutora(autorKVyhledani);
                        break;

                    case "5":
                        knihovna.VypisVsechnyKnihy();
                        break;

                    case "0":
                        pokracovat = false;
                        Console.WriteLine("\nProgram ukončen.");
                        break;

                    default:
                        Console.WriteLine("\nNeplatná volba! Zkuste to znovu.");
                        break;
                }
            }

            Console.WriteLine("\nStiskněte libovolnou klávesu...");
            Console.ReadKey();
        }
    }
}

