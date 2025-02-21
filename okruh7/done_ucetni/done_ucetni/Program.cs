namespace done_ucetni
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           



            int[,] cisla2 = {
            {1, 0, 10, 4},
            {2, 2, 3, 4},
            {6, 5, 4, 3},
            {12, 0, 0, -1}
            };
            Ucetni(cisla2);

        }

        public static void Ucetni(int[,] poleCisel)
        {
            List<int> soucet_radku = new List<int> { 0, 0, 0, 0 };
            List<int> soucet_sloupcu = new List<int> { 0, 0, 0, 0 };

            // Výpočet součtů řádků a sloupců
            for (int i = 0; i < poleCisel.GetLength(0); i++)
            {
                for (int j = 0; j < poleCisel.GetLength(1); j++)
                {
                    soucet_radku[i] += poleCisel[i, j];
                    soucet_sloupcu[j] += poleCisel[i, j];
                }
            }

            for (int i = 0; i < poleCisel.GetLength(0); i++)
            {
               
                for (int j = 0; j < poleCisel.GetLength(1); j++)
                {
                    Console.Write($"{poleCisel[i, j]},");

                }
                Console.Write($"| {soucet_radku[i]}");
                Console.WriteLine();
            }
            Console.WriteLine("----------------------");
            for (int i = 0; i < poleCisel.GetLength(1); i++) 
            {
                Console.Write($"{soucet_sloupcu[i]}, ");
            }

        }
    }
}
