namespace ukoly_linked_list_done
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();

            while (true) 
            {
                int volba = Menu();
                switch (volba) 
                {
                    case 1:
                        Console.Write("tvůj úkol: ");
                        list.AddFirst(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("tvůj úkol:");
                        list.AddLast(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("odebírám první úkol...");
                        list.RemoveFirst();
                        break;
                    case 4:
                        Console.WriteLine("odebírám poslední úkol...");
                        list.RemoveLast();
                        break;
                    case 5:
                        foreach (var item in list) 
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    default:
                        break;
                }
                if (volba == 6) break; 
                
            }
        }

        public static int Menu() 
        {
            int volba;
            do {
                Console.WriteLine("1. přidat úkol na začátek");
                Console.WriteLine("2. přidat úkol na konec");
                Console.WriteLine("3. odebrat úkol na začátku");
                Console.WriteLine("4. odebrat úkol na konci");
                Console.WriteLine("5. vypsání seznamu");
                Console.WriteLine("6. vypnout program");
                Console.Write("vyber: ");
            }while(!int.TryParse(Console.ReadLine(), out volba) || volba > 6 || volba < 1);
            return volba;
        }
    }
}
