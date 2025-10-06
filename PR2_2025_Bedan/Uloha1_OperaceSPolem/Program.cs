using System;

namespace Uloha1_OperaceSPolem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Úloha 1: Operace s jednorozměrným polem ===\n");

            //upřimně paní učitelko se musim přiznat. Udělal jsem to z velké části s AI a to protože jsem kompletně zapomněl že jsem to měl udělat do 6.10. vím ale jak co funguje. Byl jsem jenom teď dost časově vytížený:).
            Random random = new Random();
            int[] pole = new int[10];
            
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = random.Next(1, 101);
            }

            Console.WriteLine("Obsah pole:");
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i] + " ");
            }
            Console.WriteLine("\n");

            int min = pole[0];
            int max = pole[0];
            
            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i] < min)
                    min = pole[i];
                if (pole[i] > max)
                    max = pole[i];
            }
            
            Console.WriteLine($"Nejmenší hodnota: {min}");
            Console.WriteLine($"Největší hodnota: {max}\n");

            int soucet = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                soucet += pole[i];
            }
            double prumer = (double)soucet / pole.Length;
            Console.WriteLine($"Průměr hodnot: {prumer:F2}\n");

            Array.Sort(pole);
            
            Console.WriteLine("Seřazené pole:");
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nProgram ukončen. Stiskněte libovolnou klávesu...");
            Console.ReadKey();
        }
    }
}

