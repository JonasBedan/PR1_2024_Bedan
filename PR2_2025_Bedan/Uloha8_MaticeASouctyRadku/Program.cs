using System;

namespace Uloha8_MaticeASouctyRadku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Úloha 8: Matice a součty řádků ===\n");

            Random random = new Random();
            int[,] matice = new int[4, 4];
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matice[i, j] = random.Next(1, 51);
                }
            }

            Console.WriteLine("Matice 4x4:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{matice[i, j],4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Součty řádků:");
            int maxSoucet = int.MinValue;
            int radekSMaxSouctem = 0;

            for (int i = 0; i < 4; i++)
            {
                int soucet = 0;
                for (int j = 0; j < 4; j++)
                {
                    soucet += matice[i, j];
                }
                
                Console.WriteLine($"Řádek {i + 1}: {soucet}");

                if (soucet > maxSoucet)
                {
                    maxSoucet = soucet;
                    radekSMaxSouctem = i + 1;
                }
            }

            Console.WriteLine($"\nŘádek s největším součtem: Řádek {radekSMaxSouctem} (součet: {maxSoucet})");

            Console.WriteLine("\nProgram ukončen. Stiskněte libovolnou klávesu...");
            Console.ReadKey();
        }
    }
}

