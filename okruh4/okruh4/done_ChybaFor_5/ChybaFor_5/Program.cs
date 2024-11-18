using System;

class MainClass
{
    static void Main(string[] args)
    {
        int pocet;
        Console.Write("Kolik čísel budeme průměrovat: ");
        int.TryParse(Console.ReadLine(), out pocet);

        double suma = 0;

        for (int i = 0; i < pocet; i++)
        {
            Console.Write("Číslo: ");
            int cislo;
            while (!int.TryParse(Console.ReadLine(), out cislo))
            {
                Console.Write("Chyba formátu, vložte číslo znovu: ");
            }

            suma += cislo;
        }

        double prumer = suma / pocet;

        Console.WriteLine("Průměrná hodnota čísla byla {0}.", prumer);

    }
}