using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Sem přijde váš kód
        Random generator = new Random();

        int kostka = generator.Next(1,7);

        Console.WriteLine(kostka);
    }
}