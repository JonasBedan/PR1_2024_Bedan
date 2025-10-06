using System;

namespace Uloha3_PraceSMetodami
{
    class Program
    {
        static int[] VytvorPole(int velikost)
        {
            Random random = new Random();
            int[] pole = new int[velikost];
            
            for (int i = 0; i < velikost; i++)
            {
                pole[i] = random.Next(1, 101);
            }
            
            return pole;
        }

        static void VypisPole(int[] pole)
        {
            Console.WriteLine("Obsah pole:");
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i] + " ");
            }
            Console.WriteLine("\n");
        }

        static int NajdiMinimum(int[] pole)
        {
            int min = pole[0];
            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i] < min)
                    min = pole[i];
            }
            return min;
        }

        static int NajdiMaximum(int[] pole)
        {
            int max = pole[0];
            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i] > max)
                    max = pole[i];
            }
            return max;
        }

        static double VypocitejPrumer(int[] pole)
        {
            int soucet = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                soucet += pole[i];
            }
            return (double)soucet / pole.Length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Úloha 3: Práce s metodami ===\n");

            int[] mojePole = VytvorPole(10);

            VypisPole(mojePole);

            int minimum = NajdiMinimum(mojePole);
            Console.WriteLine($"Minimum: {minimum}");

            int maximum = NajdiMaximum(mojePole);
            Console.WriteLine($"Maximum: {maximum}");

            double prumer = VypocitejPrumer(mojePole);
            Console.WriteLine($"Průměr: {prumer:F2}");

            Console.WriteLine("\nProgram ukončen. Stiskněte libovolnou klávesu...");
            Console.ReadKey();
        }
    }
}

