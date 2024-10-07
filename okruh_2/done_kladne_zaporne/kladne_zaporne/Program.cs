using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // sem přijde váš kód      
        Console.Write("napiš celé číslo: ");
        int cislo = int.Parse(Console.ReadLine());

        if (cislo == 0)
        {
            Console.WriteLine("číslo je nula");
        }
        else if (cislo > 0) { Console.WriteLine("číslo je kladné"); }
        else { Console.WriteLine("číslo je záporné"); }
    }
}