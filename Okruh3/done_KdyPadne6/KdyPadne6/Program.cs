using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int kostka;
        int pocet = 0;

        do
        {
            kostka = rnd.Next(1,7);
            Console.WriteLine("hodil jsem: "+kostka);
            pocet++;
        } while (kostka != 6);
        Console.WriteLine("trvalo mi "+pocet+" hodů, než jsem hodil 6");

        //vzhledem ke své lenosti jsem pouze okopcil z jiz hotove ulohy, vim ze se da tato cast udelat lip
        Console.Write("Chceš pokračovat? a/n: ");
        char pokracovat = Console.ReadKey().KeyChar;
        Console.WriteLine("");
        if (pokracovat == 'a')
        {
            Main(args);
        }


    }
}