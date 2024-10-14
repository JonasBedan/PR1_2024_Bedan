using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Sem přijde váš kód
        Console.Write("zadej čitatele: ");
        int citatel = int.Parse(Console.ReadLine());

        Console.Write("zadej jmenovatele:");
        int jmenovatel = int.Parse(Console.ReadLine());
        int zbytek = citatel%jmenovatel;
        int podil = citatel / jmenovatel;

        if (zbytek == 0)
        {
            Console.WriteLine("zkráceně " + citatel + "/" + jmenovatel + " "+"je "+ podil);
        }
        else if ((citatel / jmenovatel) >= 1)
        {

            Console.WriteLine("zkráceně" + citatel + "/" + jmenovatel + " "+ "je " + podil + " " + zbytek + "/" + jmenovatel);
        }
        else if (podil == 0)
        {
            Console.WriteLine("nelze zkrátit" + citatel + "/" + jmenovatel);
        }
        else if (jmenovatel == 0)
        {
            Console.WriteLine("nelze dělit nulou");
        }
        else
        {
            Console.WriteLine("zadal jsi chybnou hodnotu");
        }

    }
}