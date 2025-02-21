namespace done_vypis_do_tabulky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matice = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 10 } };
            serad(matice);
            
        }

        public static void serad(int[,] a) 
        {
            int nejvetsi = int.MinValue;
            int radek_s_nejvetsim = 0;
            

            for (int x = 0;  x < a.GetLength(0); x++) 
            { 
                for (int y = 0; y < a.GetLength(1); y++) 
                {
                    if (nejvetsi < a[x, y])
                    {
                        nejvetsi = a[x, y];
                        radek_s_nejvetsim = x;
                    }                    
                }                
            }

            for (int x = 0;x < a.GetLength(1); x++) 
            {
                int pom = a[radek_s_nejvetsim, x];
                a[radek_s_nejvetsim, x] = a[0, x];
                a[0, x] = pom;
            }


            for (int i = 0; i < a.GetLength(0); i++) 
            {
                for (int j = 0; j < a.GetLength(1)*3; j++) 
                {
                    Console.Write("-");
                }
                Console.WriteLine();
                for (int k = 0; k < a.GetLength(1); k++) 
                {
                    Console.Write($"|{a[i, k]}"); 
                    
                }
                Console.Write("|");
                Console.WriteLine();
            }
        } 
    }
}
