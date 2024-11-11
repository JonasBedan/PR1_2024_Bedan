using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int vstup = 1;
        int liche = 0;
        int sude = 0;

        do
        {
            Console.Write("Zadej číslo: ");
            int.TryParse(Console.ReadLine(), out vstup);

            if ((vstup % 2) == 0) 
            {
                sude++;
            }
            else
            {
                liche++;
            }

        } while (vstup != 0);
        sude = sude - 1;//bere nulu jako sudé číslo
        Console.WriteLine("napsal jsi "+sude+" sudých čísel");
        Console.WriteLine("napasl jsi "+liche+" lichých čísel");
    }
}