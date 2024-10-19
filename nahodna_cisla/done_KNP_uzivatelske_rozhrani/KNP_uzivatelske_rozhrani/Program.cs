using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Sem přijde váš kód
        Console.Write("jakou si bereš figuru k/n/p: ");
        char volba_uzivatele = Console.ReadKey().KeyChar;
        Console.WriteLine("");

        if (volba_uzivatele == 'k') { Console.WriteLine("kámen"); }
        else if (volba_uzivatele == 'n') { Console.WriteLine("nůžky"); }
        else if (volba_uzivatele == 'p') { Console.WriteLine("papír"); }
        else { Console.WriteLine("zadal jsi neplatnou hodnotu"); }



    }
}