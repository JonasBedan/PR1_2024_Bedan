using System;
using System.Collections.Generic;

namespace Uloha4_PraceSListem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Úloha 4: Práce s Listem ===\n");

            Random random = new Random();

            List<int> cisla = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                cisla.Add(random.Next(1, 101));
            }

            Console.WriteLine("Původní List (20 čísel):");
            foreach (int cislo in cisla)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine($"\nPočet prvků: {cisla.Count}\n");

            int noveCislo = random.Next(1, 101);
            cisla.Add(noveCislo);
            Console.WriteLine($"Přidáno nové číslo: {noveCislo}");
            Console.WriteLine($"Počet prvků: {cisla.Count}\n");

            Console.WriteLine("Odebírání sudých hodnot...");
            for (int i = cisla.Count - 1; i >= 0; i--)
            {
                if (cisla[i] % 2 == 0)
                {
                    cisla.RemoveAt(i);
                }
            }

            Console.WriteLine("\nFinální List (pouze lichá čísla):");
            foreach (int cislo in cisla)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine($"\nPočet prvků: {cisla.Count}");

            Console.WriteLine("\nProgram ukončen. Stiskněte libovolnou klávesu...");
            Console.ReadKey();
        }
    }
}

