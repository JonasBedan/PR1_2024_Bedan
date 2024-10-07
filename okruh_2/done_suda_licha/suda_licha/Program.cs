using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // sem přijde váš kód
        Console.Write("napiš mi cislo: ");
        double cislo = double.Parse(Console.ReadLine());

        if (cislo % 2 == 0)
        {
            Console.WriteLine("číslo je sudé");
        }
        else
        {
            Console.WriteLine("číslo je liché");
        }
    }
}