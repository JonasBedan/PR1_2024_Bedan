using System;
using System.Collections.Generic;

namespace Uloha5_PouzitiDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Úloha 5: Použití Dictionary ===\n");

            Dictionary<string, int> studenti = new Dictionary<string, int>();
            studenti.Add("Jan Novák", 1);
            studenti.Add("Petra Svobodová", 2);
            studenti.Add("Martin Dvořák", 1);
            studenti.Add("Lenka Kučerová", 3);
            studenti.Add("Tomáš Procházka", 2);

            Console.WriteLine("Seznam studentů a jejich známek:");
            foreach (KeyValuePair<string, int> student in studenti)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }
            Console.WriteLine();

            Console.Write("Zadejte jméno studenta pro úpravu známky: ");
            string jmeno = Console.ReadLine();

            if (studenti.ContainsKey(jmeno))
            {
                Console.Write($"Současná známka studenta {jmeno}: {studenti[jmeno]}\n");
                Console.Write("Zadejte novou známku: ");
                
                if (int.TryParse(Console.ReadLine(), out int novaZnamka))
                {
                    studenti[jmeno] = novaZnamka;
                    Console.WriteLine("Známka byla úspěšně upravena.\n");
                }
                else
                {
                    Console.WriteLine("Neplatná známka!\n");
                }
            }
            else
            {
                Console.WriteLine($"Student {jmeno} nebyl nalezen!\n");
            }

            Console.WriteLine("Aktualizovaný seznam studentů a jejich známek:");
            foreach (KeyValuePair<string, int> student in studenti)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }

            Console.WriteLine("\nProgram ukončen. Stiskněte libovolnou klávesu...");
            Console.ReadKey();
        }
    }
}

