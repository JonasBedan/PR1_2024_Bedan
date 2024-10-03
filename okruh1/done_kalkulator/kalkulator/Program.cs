using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("napis prvni cislo: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("napis druhe cislo: ");
        int b = int.Parse(Console.ReadLine());
        int vysledek = a + b;
        Console.WriteLine("soucet je "+vysledek);
        vysledek = a - b;
        Console.WriteLine("rozdil cisel je " + vysledek);
        vysledek = a * b;
        Console.WriteLine("soucin cisel je " + vysledek);
        float vysledek2;
        vysledek2 = (float)a / b;
        Console.WriteLine("podil cisel je " + vysledek2);
    }
}