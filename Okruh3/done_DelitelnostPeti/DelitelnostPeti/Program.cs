using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int cislo = 4;
        int vysledek;

        do
        {
            Console.Write("Zadej číslo dělitelné 5: ");
            int.TryParse(Console.ReadLine(), out cislo);

            if ((cislo % 5) == 0)
            {
                vysledek = cislo / 5;
                Console.WriteLine(cislo + " / " + 5 + " = " + vysledek);
            }
            else 
            {
                Console.WriteLine("To není dělitelné 5, zkus to znovu");
            }

        } while ((cislo%5) != 0);
    }
}