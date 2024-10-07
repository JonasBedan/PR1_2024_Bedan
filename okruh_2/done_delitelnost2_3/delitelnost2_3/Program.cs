using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Sem přijde váš kód
        Console.Write("napiš mi celé kladné číslo:");
        int cislo = int.Parse(Console.ReadLine());

        if ((cislo % 2 == 0) && (cislo % 3 == 0))
        {
            Console.WriteLine("číslo je dělitelné trojkou i dvojkou");
        }
        else if (cislo % 2 == 0)
        {
            Console.WriteLine("číslo je dělitelné jen dvojkou");
        }
        else if (cislo % 3 == 0)
        {
            Console.WriteLine("číslo je dělitelné jen trojkou");
        }
        else
        {
            Console.WriteLine("číslo není dělitelné ani dvojkou ani trojkou");
        }
    }
}