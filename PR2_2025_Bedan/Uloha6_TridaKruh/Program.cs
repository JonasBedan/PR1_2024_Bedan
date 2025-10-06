using System;

namespace Uloha6_TridaKruh
{
    class Kruh
    {
        public double Polomer { get; set; }

        public Kruh(double polomer)
        {
            Polomer = polomer;
        }

        public double VypocitejObvod()
        {
            return 2 * Math.PI * Polomer;
        }

        public double VypocitejObsah()
        {
            return Math.PI * Polomer * Polomer;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Úloha 6: Třída Kruh ===\n");

            Console.Write("Zadejte poloměr kruhu: ");
            if (double.TryParse(Console.ReadLine(), out double polomer))
            {
                Kruh kruh = new Kruh(polomer);

                Console.WriteLine($"\nKruh s poloměrem {kruh.Polomer}:");
                Console.WriteLine($"Obvod: {kruh.VypocitejObvod():F2}");
                Console.WriteLine($"Obsah: {kruh.VypocitejObsah():F2}");
            }
            else
            {
                Console.WriteLine("Neplatný vstup!");
            }

            Console.WriteLine("\nProgram ukončen. Stiskněte libovolnou klávesu...");
            Console.ReadKey();
        }
    }
}

