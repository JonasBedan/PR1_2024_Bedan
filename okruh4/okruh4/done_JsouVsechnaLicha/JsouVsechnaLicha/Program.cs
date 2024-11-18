using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //sem přijde váš kód
        int pocet;
        int zadane;
        bool sude = false;
        Console.Write("počet vkládaných čísel: ");
        int.TryParse(Console.ReadLine(), out pocet);

        for (int i = 0; i < pocet; i++) 
        {
            Console.Write("Zadej číslo: ");
            int.TryParse(Console.ReadLine(), out zadane);

            if ((zadane % 2) == 0) 
            { 
                sude = true;
                break;
            }
        }

        if (sude == true)
        {
            Console.WriteLine("Program byl ukončen, protože jsi zadal sudé číslo.");
        }
        else 
        {
            Console.WriteLine("všechna čísla byl lichá.");
        }

    }
}