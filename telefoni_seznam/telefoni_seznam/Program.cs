namespace telefoni_seznam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> dic = new Dictionary<string,string>();

            while (true)
            {
                int volba = Menu();
                Console.WriteLine();
                switch (volba)
                {
                    case 1:
                        Console.Write("jméno: ");
                        string jmeno = Console.ReadLine();
                        Console.Write("kontakt: ");
                        string tel_cislo = Console.ReadLine();
                        dic.Add(jmeno, tel_cislo);
                        break;
                    case 2:
                        Console.Write("jméno: ");
                        string jmeno_pro_vyhledani = Console.ReadLine();
                        if (dic.TryGetValue(jmeno_pro_vyhledani, out var hodnota))
                        {
                            Console.WriteLine($"Jméno je na seznamu, tel. cislo: {hodnota}");
                        }
                        else
                        {
                            Console.WriteLine("Jméno není na seznamu.");
                        }

                        break;
                    case 3:
                        Console.Write("jméno: ");
                        string jmeno_pro_odstraneni = Console.ReadLine();
                        if (dic.TryGetValue(jmeno_pro_odstraneni, out var hodnota1))
                        {
                            dic.Remove(jmeno_pro_odstraneni);
                        }
                        else
                        {
                            Console.WriteLine("Jméno není na seznamu.");
                        }
                        break;
                    case 4:
                        foreach(var i in dic) 
                        {
                            Console.WriteLine(i.Key+" "+i.Value);
                        }
                        break;
                    default:
                        break;
                }
                if (volba == 5) break;
                Console.WriteLine();
            }
        }

        public static int Menu()
        {
            int volba;
            do
            {
                Console.WriteLine("1. přidat nový kontakt");
                Console.WriteLine("2. najít kontakt podle jména");
                Console.WriteLine("3. odebrat kontakt podle jména");
                Console.WriteLine("4. vypsat tel. seznam");
                Console.WriteLine("5. vypnout program");
                Console.Write("vyber: ");
            } while (!int.TryParse(Console.ReadLine(), out volba) || volba > 5 || volba < 1);
            return volba;
        }
    }
}

