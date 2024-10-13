using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Jaký je den v týdnu(1-7): ");
        string DenVTydnu = Console.ReadLine();

        string den = DenVTydnu switch
        {
            "1" => "Pondělí",
            "2" => "Úterý",
            "3" => "Středa",
            "4" => "Čtvrtek",
            "5" => "Pátek",
            "6" => "Sobota",
            "7" => "Neděle",
            "_" => "neplatný den,"
        };
        Console.WriteLine(den);
    }
}