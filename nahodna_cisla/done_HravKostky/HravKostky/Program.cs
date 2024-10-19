using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Sem přijde váš kód
        Random random = new Random();
        Random random1 = new Random();

        int kostka_pocitace = random.Next(1, 7);
        Console.WriteLine("hodil jsem "+kostka_pocitace);

        Console.Write("hoď si (zmáčkni kláveesu) ");
        Console.ReadKey();
        int kostka_uzivatele = random1.Next(1, 7);
        Console.WriteLine("hodil jsi "+ kostka_uzivatele);

        if (kostka_pocitace > kostka_uzivatele) { Console.WriteLine("prohrál jsi"); }
        else if (kostka_pocitace < kostka_uzivatele) { Console.WriteLine("vyhrál jsi"); }
        else{ Console.WriteLine("remíza"); }
    }
}