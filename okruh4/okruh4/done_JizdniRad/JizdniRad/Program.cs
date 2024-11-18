using System;

class MainClass
{

    public static void Main(string[] args)
    {
        int minuty = 42;
        int hodiny = 5;
        int mezi = 0;
        int pocet_autobusu;

        Console.Write("Pro kolik autobusů chceš znát pravidelný odjezd: ");
        int.TryParse(Console.ReadLine(), out pocet_autobusu);

        for (int i = 0; i < pocet_autobusu; i++)
        {
            minuty = minuty + 13;
            if (minuty >= 60) 
            {
                mezi = minuty - 60;
                minuty = 0+mezi;
                hodiny++;
            }
            if (minuty < 10)
            {
                Console.WriteLine(hodiny + ":0" + minuty);
            }
            else
            {
                Console.WriteLine(hodiny + ":" + minuty);
            }
            mezi = 0;

        }
        //sem přijde váš kód
        
    }
}