using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int strana;

        //dál pokračujte vy
        Console.Write("jak vysoký má být trojúhelník: ");
        int.TryParse(Console.ReadLine(), out strana);

        for (int i = strana - 1; i >= 0; i--) 
        {
            for (int j = 0; j < strana - 1 - i; j++) 
            {
                Console.Write(" ");
            }
            for (int j = 0; j < 2 * i + 1; j++) 
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}