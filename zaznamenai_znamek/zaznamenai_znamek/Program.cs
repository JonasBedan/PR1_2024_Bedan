namespace zaznamenai_znamek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> evidence = new Dictionary<string, List<int>>();
            LinkedList<int> historie = new LinkedList<int>();

            while (true) 
            {
                int volba = menu();
                switch (volba)
                {
                    case 1:
                        Console.Write("Napiš jméno studenta: ");
                        string jmeno_studenta = Console.ReadLine();
                        if (evidence.ContainsKey(jmeno_studenta)) 
                        { 
                            Console.WriteLine("Student s tímto jménem již existuje."); 
                            return; 
                        }
                        evidence.Add(jmeno_studenta, new List<int>());
                        Console.WriteLine("Student přidán.");
                        break;
                    case 2:
                        Console.Write("jméno: ");
                        string jmeno_pro_vyhledani = Console.ReadLine();
                        if (evidence.ContainsKey(jmeno_pro_vyhledani))
                        {
                            int znamka;
                            do { Console.WriteLine("Přidej známku (1-5): "); } while (!int.TryParse(Console.ReadLine(), out znamka) || znamka < 1 || znamka > 5);

                            evidence[jmeno_pro_vyhledani].Add(znamka);

                            historie.AddFirst(znamka);
                            if (historie.Count > 5)
                            {
                                historie.RemoveLast();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Jméno není na seznamu.");
                        }

                        break;
                    case 3:
                        Console.Write("jméno: ");
                        string jmeno_pro_vypsani = Console.ReadLine();
                        if (evidence.ContainsKey(jmeno_pro_vypsani) == true)
                        {
                            if (evidence.TryGetValue(jmeno_pro_vypsani, out var hodnota1))
                            {
                                if (hodnota1.Count == 0)
                                {
                                    Console.WriteLine("Student zatím nemá žádné známky.");
                                }
                                else
                                {
                                    foreach (var i in hodnota1)
                                    {
                                        Console.WriteLine(i);
                                    }
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Jméno není na seznamu.");
                            return;
                        }
                        break;
                    case 4:

                        break;
                    case 5:
                        foreach(int i in historie)
                        {  Console.WriteLine(i); }
                        break;
                    default:
                        break;
                }
                if (volba == 6) 
                {
                    break;
                }
            }

        }

        public static int menu() 
        {
            int volba;
            do {
                Console.WriteLine("1. Přidání studenta (jméno studenta se nesmí opakovat).");
                Console.WriteLine("2. Přidání známky studentovi (pokud student existuje).");
                Console.WriteLine("3. zobrazení všech známek konkrétního studenta");
                Console.WriteLine("4. výpis všech studentů a jejich průměrné známky od nejlepšího po nejhorší");
                Console.WriteLine("5. výpis posledních pěti přidaných známek");
                Console.WriteLine("6. ukončit program");
            } while (!int.TryParse(Console.ReadLine(), out volba)||volba>6||volba<0);
            return volba;
        }
    }
}
