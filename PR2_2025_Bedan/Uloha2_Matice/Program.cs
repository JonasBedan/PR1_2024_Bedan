using System;

namespace Uloha2_Matice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Úloha 2: Matice (dvourozměrné pole) ===\n");

            Random random = new Random();
            int[,] matice = new int[5, 5];
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matice[i, j] = random.Next(1, 51);
                }
            }

            Console.WriteLine("Matice 5x5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{matice[i, j],4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int min = matice[0, 0];
            int max = matice[0, 0];
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matice[i, j] < min)
                        min = matice[i, j];
                    if (matice[i, j] > max)
                        max = matice[i, j];
                }
            }
            
            Console.WriteLine($"Nejmenší hodnota v matici: {min}");
            Console.WriteLine($"Největší hodnota v matici: {max}\n");

            int soucet = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    soucet += matice[i, j];
                }
            }
            Console.WriteLine($"Součet všech hodnot v matici: {soucet}\n");

            Console.WriteLine("Hlavní diagonála:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(matice[i, i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nProgram ukončen. Stiskněte libovolnou klávesu...");
            Console.ReadKey();
        }
    }
}

