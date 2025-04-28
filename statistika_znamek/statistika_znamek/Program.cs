namespace statistika_znamek 
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            while (true)
            {
                int volba = Menu();
                Console.WriteLine();
                switch (volba)
                {
                    case 1:
                        int pom;
                        do { Console.Write("přidej novou známku: "); } while(!int.TryParse(Console.ReadLine(), out pom)||pom<1||pom>5);
                        list.Add(pom);
                        break;
                    case 2:
                        double prumer = 0;
                        Console.WriteLine("počítám průměr...");
                        for (int i = 0; i < list.Count; i++) 
                        {
                            prumer += list[i];    
                        }
                        prumer = prumer/list.Count;
                        Console.WriteLine($"průmerná známka je: {prumer}" );
                        break;
                    case 3:
                        Console.WriteLine("zjišťuji hodnoty...");
                        int min = int.MaxValue;
                        int max = int.MinValue;
                        for (int i = 0; i < list.Count; i++) 
                        {
                            if (list[i]<min) min = list[i];
                            if (list[i]>max) max = list[i];
                        }
                        Console.WriteLine($"nejmnižší známka byla: {min}");
                        Console.WriteLine($"nejvyšší známka byla: {max}");
                        break;
                    case 4:
                        foreach (int i in list) 
                        {
                            Console.WriteLine(i);
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
                Console.WriteLine("1. přidat novou známku");
                Console.WriteLine("2. vypočítat průměr známek");
                Console.WriteLine("3. zjistit minimální a maximální známku");
                Console.WriteLine("4. vypsat všechny známky");
                Console.WriteLine("5. vypnout program");
                Console.Write("vyber: ");
            } while (!int.TryParse(Console.ReadLine(), out volba) || volba > 5 || volba < 1);
            return volba;
        }
    }
}
