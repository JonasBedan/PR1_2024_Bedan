using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int vstup = 1;
        int soucet = 0;

        do {

            Console.Write("Zadej číslo: ");
            int.TryParse(Console.ReadLine(), out vstup);
            soucet = soucet + vstup;

        } while (vstup != 0);

        Console.WriteLine("Součet zadaných čísel je "+soucet);
    }
}