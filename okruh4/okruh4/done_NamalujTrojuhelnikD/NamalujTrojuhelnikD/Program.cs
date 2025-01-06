using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int vyska = 10;

        //dál pokračujte vy
        for (int i = 0; i < vyska; i++)
        {
            for (int j = 0; j < vyska - 1 - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < vyska-i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}