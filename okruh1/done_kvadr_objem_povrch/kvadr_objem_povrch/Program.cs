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
        Console.Write("Zadej výšku (v cm):");
        double stranaC = double.Parse(Console.ReadLine());
        double vysledek = stranaA * stranaB * stranaC;
        Console.WriteLine("objem kvádru je:"+vysledek+(" cm krychl."));
        double plochaA = stranaA * stranaB;
        double plochaB = stranaB * stranaC;
        double plochaC = stranaC * stranaA;
        vysledek = (plochaA + plochaB + plochaC) * 2;
        Console.WriteLine("povrh kvadru je:" + vysledek + (" cm čtver."));
        //rozdělil jsem to na ty plochy, protože jsem si myslel že to bude přehlednější než kdybych to napsal do toho vysledku 


        // Konec prostoru pro kód
    }
}