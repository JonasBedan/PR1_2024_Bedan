using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // sem přije kód
        Console.Write("napiš číslo, klidně záporné nebo desetinné já ti z toho udělám absolutní hodnotu:");
        double cislo = double.Parse(Console.ReadLine());

        if (cislo < 0)
        {
            cislo = cislo * (-1);
            Console.WriteLine("absolutní hodnota je " + cislo);

        }
        else 
        {
            Console.WriteLine("absolutní hodnota je " + cislo);
        }
    }
}