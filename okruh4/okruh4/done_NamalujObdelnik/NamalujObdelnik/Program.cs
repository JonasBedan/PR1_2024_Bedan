using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int vyska;
        int sirka;
        //dál pokračujte vy

        Console.Write("Jaká má být výška obdelníku: ");
        int.TryParse(Console.ReadLine(), out vyska);

        Console.Write("Jaká má být šířka obdelníku: ");
        int.TryParse(Console.ReadLine(), out sirka);

        for (int i = 0; i < vyska; i++) 
        {
            for (int j = 0; j < sirka; j++) 
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }


    }
}