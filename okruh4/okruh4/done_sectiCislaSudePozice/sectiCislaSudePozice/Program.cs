using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //sem přijde váš kód
        
        int cislo;
        int soucet = 0;

        for (int i = 1; i <= 10; i++) 
        {
            do {
                Console.Write("Zadej číslo "+i+":");
            }while(!int.TryParse(Console.ReadLine(), out cislo));

            if ((i % 2) == 0) 
            {
                soucet = soucet + cislo;
            }
        }
        Console.WriteLine("součet čísel na sudé pozici je "+soucet);
    }
}