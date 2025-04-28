namespace herni_turnaj_done
{
    internal class Program
    {
        static List<Turnaj> turnaje = new List<Turnaj>();
        static List<Hrac> hraci = new List<Hrac>();

        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("\n---------------------");
                Console.WriteLine("Menu:");
                Console.WriteLine("---------------------");
                Console.WriteLine("1 - Přidat a vypsat turnaje");
                Console.WriteLine("2 - Přidat hráče");
                Console.WriteLine("3 - Přepni na hráče");
                Console.WriteLine("0 - Ukončit program");
                Console.WriteLine("---------------------");
                Console.Write("Vyberte možnost: ");

                string volba = Console.ReadLine();
                switch (volba) 
                {
                    case "0":
                        Console.WriteLine("Ukončuji...");
                        break;
                    case "1":
                        Console.Write("název turnaje:");
                        string nazev = Console.ReadLine();

                        Console.Write("místo konání:");
                        string misto = Console.ReadLine();

                        int kapacita;
                        do {
                            Console.Write("kapacita turnaje:");
                        } while (!int.TryParse(Console.ReadLine(), out kapacita));

                        Console.Write("hlavní cena:");
                        string cena = Console.ReadLine();


                        Console.Write("jmeno hry:");
                        string nazevH = Console.ReadLine();

                        Console.Write("časová náročnost:");
                        string casova_narocnost = Console.ReadLine();

                        int pocetHracu;
                        do { Console.Write("počet hráčů:"); }while(!int.TryParse(Console.ReadLine(),out pocetHracu));

                        Hra hra = new Hra(nazevH, casova_narocnost, pocetHracu);
                        Turnaj turnaj = new Turnaj(nazev, misto, kapacita, cena, hra);
                        turnaje.Add(turnaj);


                        foreach(Turnaj i in turnaje) 
                        {
                            Console.WriteLine($"{(turnaje.Count)+1}.) {i}");
                        }
                        break;

                    case "2":
                        Console.Write("jmeno hrace:");
                        string jmeno = Console.ReadLine();

                        Console.Write("prijmeni hrace:");
                        string prijmeni = Console.ReadLine();

                        int vek;
                        do {
                            Console.Write("vek hrace:");
                        }while(!int.TryParse(Console.ReadLine(), out vek));

                        Console.Write("prezdivka hrace:");
                        string prezdivka = Console.ReadLine();

                        Hrac hrac = new Hrac(jmeno, prijmeni, vek, prezdivka);
                        hraci.Add(hrac);
                        break;
                    case "3":

                        foreach (Hrac i in hraci)
                        {
                            Console.WriteLine($"{(hraci.Count) + 1}.) {i}");
                        }
                        
                        Hrac vybrany_hrac = null;
                        while( vybrany_hrac != null) 
                        {
                            Console.Write("vyber hrace:");
                            string hracJmeno = Console.ReadLine();

                            vybrany_hrac = hraci.FirstOrDefault(k => k.jmeno == hracJmeno);
                            if (vybrany_hrac == null)
                            {
                                Console.WriteLine("Hráč nebyl nalezen. Zkuz znovu.");
                            }

                        }
                        break;
                    default:
                        Console.WriteLine("nevybral jsi existující možnost");
                        break;
                }
            }
        }
    }
}
