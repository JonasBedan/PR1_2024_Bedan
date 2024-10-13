using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // sem přijde váš kód      
        Console.Write("jaký je den (1-7):");
        string denTydne = Console.ReadLine();

        string den = (denTydne) switch
        {
            "1" or "2" or "3" or "4" or "5" => "je všední den",
            "6" or "7" => "je výkend",
            "_" => "neplatná hodnota,"
            
        };
        Console.WriteLine(den);
    }
}