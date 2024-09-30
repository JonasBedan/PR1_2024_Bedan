using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Sem přijde váš kód

        Console.Write("Zadej délku (v cm):");
        double stranaA = double.Parse(Console.ReadLine());
        Console.Write("Zadej šířku (v cm):");
        double stranaB = double.Parse(Console.ReadLine());
        Console.Write("Zadej výšku (vcm):");
        double stranaC = double.Parse(Console.ReadLine());
        double vysledek = stranaA * stranaB * stranaC;
        Console.WriteLine("objem kvádru je:"+vysledek);
         


        // Konec prostoru pro kód
    }
}