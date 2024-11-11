using System;

class MainClass
{
    public static void Main(string[] args)
    {
        bool sude = false;
        int liche_cislo = 0;
        int vstup;
        Console.Write("Zadej sudé číslo: ");

        do {
            int.TryParse(Console.ReadLine(), out vstup);

            if ((vstup % 2) == 0)
            {
                sude = true;
            }
            else 
            {
                Console.Write("To není sudé, zkus to znovu: ");
            }
            

        } while (sude==false);
        liche_cislo = vstup + 1;
        Console.WriteLine("Nejbližší vyšší liché číslo je "+liche_cislo);

    }
}