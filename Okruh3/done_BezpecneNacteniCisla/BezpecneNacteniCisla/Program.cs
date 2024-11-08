using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int cislo;

        do 
        {
            Console.Write("Zadej číslo:");
        } while (!int.TryParse(Console.ReadLine(), out cislo));
        Console.WriteLine("číslo je "+cislo);
    }
}