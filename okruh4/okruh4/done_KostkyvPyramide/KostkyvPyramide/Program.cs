using System;

class MainClass
{

    public static void Main(string[] args)
    {
        int vyska = 4, pocet = 0;
        //dál pokračujte vy
        for (int i = 0; i < vyska; i++) {
        pocet = pocet + i;
        }
        pocet += vyska;

        //zde končí váš kód
        Console.WriteLine($"Na stavbu pyramidy výšky {vyska} je potřeba {pocet} kostek.");
    }
}