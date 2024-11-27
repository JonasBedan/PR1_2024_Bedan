using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int delka = 8;
        //dál pokračujte vy
        for (int i = 0; i < delka; i++)
        {
            for (int j = 0; j < delka; j++) 
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

    }
}