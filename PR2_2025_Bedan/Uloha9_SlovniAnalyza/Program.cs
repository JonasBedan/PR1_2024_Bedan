using System;
using System.Collections.Generic;

namespace Uloha9_SlovniAnalyza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Úloha 9: Slovní analýza s využitím Dictionary ===\n");

            Console.Write("Zadejte slovo pro analýzu: ");
            string slovo = Console.ReadLine();

            Dictionary<char, int> vyskytyPismen = new Dictionary<char, int>();

            foreach (char pismeno in slovo)
            {
                if (vyskytyPismen.ContainsKey(pismeno))
                {
                    vyskytyPismen[pismeno]++;
                }
                else
                {
                    vyskytyPismen.Add(pismeno, 1);
                }
            }

            Console.WriteLine($"\nAnalýza slova '{slovo}':");
            Console.WriteLine("Výskyt jednotlivých písmen:");
            
            foreach (KeyValuePair<char, int> zaznam in vyskytyPismen)
            {
                Console.WriteLine($"'{zaznam.Key}': {zaznam.Value}x");
            }

            Console.WriteLine($"\nCelkový počet znaků: {slovo.Length}");
            Console.WriteLine($"Počet unikátních znaků: {vyskytyPismen.Count}");

            Console.WriteLine("\nProgram ukončen. Stiskněte libovolnou klávesu...");
            Console.ReadKey();
        }
    }
}

