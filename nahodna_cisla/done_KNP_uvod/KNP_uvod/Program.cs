using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Sem přijde váš kód
        Random generator = new Random();
        int pocitac_cislo = generator.Next(1,4);

        string pocitac_cislo_string = pocitac_cislo.ToString();

        string pocitac_volba = pocitac_cislo_string switch
        {
            "1" => "kámen",
            "2" => "nůžky",
            "3" => "papír",
        };  
        Console.WriteLine(pocitac_volba);
    }
}