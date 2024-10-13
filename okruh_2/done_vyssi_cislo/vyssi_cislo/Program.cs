using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // sem přijde váš kód
        Console.Write("napiš mi v čísle hodnotu X: ");
        int hodnotaX = int.Parse(Console.ReadLine());

        Console.Write("napiš mi v čísle hodnotu Y: ");
        int hodnotaY = int.Parse(Console.ReadLine());

        if (hodnotaX < hodnotaY) { Console.WriteLine(hodnotaY + "je větší"); }
        else if (hodnotaX > hodnotaY) { Console.WriteLine(hodnotaX + "je větší"); }
        else if (hodnotaY == hodnotaX) { Console.WriteLine("hodnoty se rovnají"); }
        else { Console.WriteLine("zadal jsi neplatnou hodnotu"); }

    }
}