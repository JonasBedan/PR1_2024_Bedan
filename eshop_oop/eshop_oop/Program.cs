using System.Globalization;

namespace eshop_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Eshop eshop = null;
            int pocetEshopu = 0;
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Vytvořit obchod");
                Console.WriteLine("2 - Přidat položku");
                Console.WriteLine("3 - Zobrazit produkty");
                Console.WriteLine("4 - Zobrazit nejlevnější položku");
                Console.WriteLine("5 - Ukončit program");
                Console.Write("Vyberte možnost: ");

                string volba = Console.ReadLine();

                switch (volba)
                {
                    case "1":
                        if (pocetEshopu == 0)
                        {
                            Console.Write("Název obchodu:");
                            string nazev = Console.ReadLine();
                            Console.Write("Adresa obchodu:");
                            string adresa = Console.ReadLine();
                            eshop = new Eshop(nazev, adresa);
                            pocetEshopu++;
                        }
                        else { Console.WriteLine("byl překročen počet povolených eshopů"); }
                        break;

                    case "2":
                        if (eshop == null) 
                        {
                            Console.WriteLine("nelze přidat položku, eshop neexistuje");
                            break;
                        }

                        Console.Write("Název položky:");
                        string nazev_po = Console.ReadLine();
                        double cena;

                        do
                        {
                            Console.Write($"Cena {nazev_po}:");
                        } while (!double.TryParse(Console.ReadLine(), out cena)||cena<0);

                        Console.Write("Výrobce:");
                        string vyrobce = Console.ReadLine();
                        Polozka nova_polozka = new Polozka(nazev_po, cena, vyrobce);
                        eshop.pridej_polozku(nova_polozka);
                        Console.WriteLine("položka přidána");
                        break;

                    case "3":
                        if (eshop == null) 
                        {
                            Console.WriteLine("nelze zobrazit položky, eshop neexistuje");
                            break;
                        }

                        eshop.zobraz_produkty();
                        break;

                    case "4":
                        if(eshop == null) 
                        {
                            Console.WriteLine("Eshop neexistuje");
                            break;
                        }
                        eshop.NejlevnejsiPolozka();
                        break;

                    case "5":
                        Console.WriteLine("ukončuje se...");
                        break;

                    default:
                        Console.WriteLine("tvá volba neexistuje");
                        break;
                }
                if (volba == "5") break;
            }
        }
    }
}
