namespace done_sport_organizace
{
    internal class Program
    {
        static List<Kluby> kluby = new List<Kluby>();
        static List<Zapas> zapasy = new List<Zapas>();
        static List<Hrac> hraci = new List<Hrac>();
        static void Main(string[] args)
        {
            
            while (true) 
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Vytvořit klub");
                Console.WriteLine("2 - Přidat hráče");
                Console.WriteLine("3 - Přidat zápas");
                Console.WriteLine("4 - Zobrazit kluby");
                Console.WriteLine("5 - Zobrazit hráče");
                Console.WriteLine("6 - Zobrazit zápasy");
                Console.WriteLine("7 - Ukončit program");
                Console.Write("Vyberte možnost: ");
                string volba = Console.ReadLine();

                switch (volba) 
                {
                    case "1":
                        Console.Write("Jméno klubu: ");
                        string nazev = Console.ReadLine();
                        kluby.Add(new Kluby(nazev));
                        Console.WriteLine($"Klub '{nazev}' byl vytvořen.");
                        break;
                    case "2":
                        Console.Write("\nJméno hráče:");
                        string jmeno = Console.ReadLine();

                        int cislo;
                        do
                        {
                            Console.Write("\nČíslo hráče:");
                        } while (!int.TryParse(Console.ReadLine(), out cislo)||cislo>99||cislo<0);

                        Console.Write("\nNárodnost hráče:");
                        string narodnost = Console.ReadLine();

                        Kluby vybrany_klub = null;
                        while (vybrany_klub==null) 
                        {
                            Console.Write("\nTým hráče:");
                            string tymJmeno = Console.ReadLine();

                            vybrany_klub = kluby.FirstOrDefault(k => k.Nazev == tymJmeno);
                            if (vybrany_klub == null)
                            {
                                Console.WriteLine("Tým nebyl nalezen. Zkuste to znovu.");
                            }
                        }
                        hraci.Add(new Hrac(jmeno, cislo, narodnost, vybrany_klub));
                        Hrac novyHrac = new Hrac(jmeno, cislo, narodnost, vybrany_klub);
                        vybrany_klub.pridej_hrace(novyHrac);
                        Console.WriteLine($"Hráč '{jmeno}' byl přidán do týmu '{vybrany_klub.Nazev}'.");
                        break;
                    case "3":
                        Console.Write("\nMísto uktání:");
                        string lokace = Console.ReadLine();
                        Console.Write("\nDatum utkání:");
                        string datum = Console.ReadLine();
                        Console.Write("\nVýseldek zápasu:");
                        string vysledek = Console.ReadLine();
                        zapasy.Add(new Zapas(lokace, datum, vysledek));
                        break;
                    case "4":
                        if (kluby.Count == 0)
                        {
                            Console.WriteLine("\nNeexistuje žádný tým, nejdřive musíš vytvořit týmy.");
                            break;
                        }
                        else 
                        {
                            foreach (var k in kluby) 
                            {
                                Console.WriteLine(k);
                            }
                        }
                        break;
                    case "5":
                        if (hraci.Count == 0) 
                        {
                            Console.WriteLine("\nNeexistují žádní hráči, nejdříve musíš vytvořit hráče.");
                            break;
                        }
                        else
                        {
                            foreach(var k in hraci)
                            {
                                Console.WriteLine(k); 
                            }
                        }
                        break;
                    case "6":
                        if (zapasy.Count == 0)
                        {
                            Console.WriteLine("\nNeexistují žádné zápasy, nejdříve musíš vytvořit zápas.");
                            break;
                        }
                        else
                        {
                            foreach (var k in zapasy)
                            {
                                Console.WriteLine(k);
                            }
                        }
                        break;
                    case "7":
                        Console.WriteLine("Program se ukončuje...");
                        break;
                    default:
                        Console.WriteLine("Nevybral jsi použitelnou možnost.");
                        break;
                }
                if (volba == "7") break;
            }
        }
    }
}
