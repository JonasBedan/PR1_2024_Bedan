using System;

class MainClass 
{   public static void delsi(string a, string b) 
    {
        string delsiSlovo;

        if (a.length > b.length)
        {
            delsiSlovo = a;
        }
        else if (b.length > a.length)
        {
            delsiSlovo = b;
        }
        else 
        {
            delsiSlovo = "stejně dlouhá"    
        }
    }
    public static void Main (string[] args) {
        Console.Write ("Zadej první slovo: ");
        string slovo1 = Console.ReadLine();

        Console.Write ("Zadej druhé slovo: ");
        string slovo2 = Console.ReadLine();

        string delsiSlovo = delsi(slovo1, slovo2) // sem přijde zavolání vaší metody, nic jiného zde neměňte
        Console.WriteLine ($"Když porovnáme {slovo1} a {slovo2}, pak delší je {delsiSlovo}.");
    }

    //sem přijde deklarace vaší metody
    //jak udělat hlavičku: obdrží dva řetězce a vrátí delší z nich
}