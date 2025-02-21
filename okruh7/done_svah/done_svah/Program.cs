namespace done_svah
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //zde je použijte a zavolejte na ně výpis
            VypisPole(Svah(4)); //až bude hotovo, odkomentujte si
            VypisPole(SikmySvah(5)); //až bude hotovo, odkomentujte si

            //zde jsou volání pro level 3
            //VypisPole(Svah(4, "jih"));
            //VypisPole(Svah(4, "zapad"));
        }

        //zde vytvořte vaše metody
        public static int[,] Svah(int a) 
        {
            int[,] x = new int[a, a];
            for (int i = 0; i < a; i++) 
            {
                for (int j = 0; j < a; j++) 
                {
                    x[i, j] = j;
                }
            }
            return x;
        }

        public static int[,] SikmySvah(int a)
        {
            int[,] x = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    x[i, j] = j+i;
                }
            }
            return x;
        }


        //výpis je hotov
        public static void VypisPole(int[,] pole)
        {
            //do kódu této metody nezasahujte
            for (int y = 0; y < pole.GetLength(0); y++)
            {
                for (int x = 0; x < pole.GetLength(1); x++)
                {
                    Console.Write(pole[y, x]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
