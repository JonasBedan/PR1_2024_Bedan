using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("napiš mi číslo měsíce a já ti napíšu kolik má dní (1-12): ");
        int mesic = int.Parse(Console.ReadLine());

        string pocetDni = mesic switch
        {
            1 => "31",
            2 => "28",
            3 => "31",
            4 => "30",
            5 => "31",
            6 => "30",
            7 => "31",
            8 => "31",
            9 => "30",
            10 => "31",
            11 => "30",
            12 => "31",
            _ => "nezadal jsi existující měsíc"
        };
        Console.WriteLine(pocetDni);
    }
}