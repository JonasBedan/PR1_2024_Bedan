using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // sem přijde váš kód
        Console.Write("napiš mi první číslo: ");
        double cislo1 = double.Parse(Console.ReadLine());

        Console.Write("napiš mi druhé číslo: ");
        double cislo2 = double.Parse(Console.ReadLine());

        Console.Write("napiš mi třetí číslo: ");
        double cislo3 = double.Parse(Console.ReadLine());

        Console.Write("napiš mi čtvrté číslo: ");
        double cislo4 = double.Parse(Console.ReadLine());


        //tuto cast jsem si vyhledal, protože jsem se chtěl naučit jak psát seznamy
        double[] cisla = { cislo1, cislo2, cislo3, cislo4 };

        Array.Sort(cisla);

        Console.WriteLine("Seřazené čísla: ");
        foreach (double cislo in cisla) { Console.WriteLine(cislo); }



    }
}