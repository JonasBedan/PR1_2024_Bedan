using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Sem přijde váš kód
        Console.Write("kolik je 2+4: ");
        string odpoved = Console.ReadLine();
        Console.Write("které písmeno je první v abecedě: ");
        string odpoved2 = Console.ReadLine();
        Console.Write("je číslo 13 sudé (A/N):");
        string odpoved3 = Console.ReadLine();

        int pocetBodu=0;

        if ((odpoved == "6")||(odpoved == "šest")) { pocetBodu += 5; }
        

        if ((odpoved2 == "A") || (odpoved2 == "a")) { pocetBodu += 5; }
        

        if ((odpoved3 == "N")||(odpoved3 == "n")) { pocetBodu+= 5; }

        Console.WriteLine("získal jsi "+pocetBodu+" bodů");

    }
}