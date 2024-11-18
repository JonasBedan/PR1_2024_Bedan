using System;

class MainClass
{
    public static void Main(string[] args)
    {
        bool remiza = false;

        // KNP uživatelské rozhraní
        Console.Write("Jakou si bereš figuru (k/n/p): ");
        char volba_uzivatele = Console.ReadKey().KeyChar;
        Console.WriteLine("");

        string hodnota = volba_uzivatele switch
        {
            'k' => "kámen",
            'n' => "nůžky",
            'p' => "papír",
            _ => "neplatná hodnota",
        };

        if (hodnota == "neplatná hodnota")
        {
            Console.WriteLine(hodnota);
            return;
        }

        // KNP uvod
        Random generator = new Random();
        int pocitac_cislo = generator.Next(1, 4);

        string pocitac_volba = pocitac_cislo switch
        {
            1 => "kámen",
            2 => "nůžky",
            3 => "papír",
        };

        Console.WriteLine("Počítač bere: " + pocitac_volba);


        if (pocitac_volba == hodnota)
        {
            remiza = true;
            Console.WriteLine("Remíza");
        }
        else if ((pocitac_volba == "kámen" && hodnota == "nůžky") ||
                 (pocitac_volba == "nůžky" && hodnota == "papír") ||
                 (pocitac_volba == "papír" && hodnota == "kámen"))
        {
            
            Console.WriteLine("Prohra");
        }
        else
        {
            
            Console.WriteLine("Výhra");
        }
        Console.WriteLine("");

        if (remiza == true)
        {
            Main(args);
        }

        Console.Write("Chceš pokračovat? a/n: ");
        char pokracovat = Console.ReadKey().KeyChar;
        Console.WriteLine("");
        if (pokracovat == 'a')
        {
            Main(args);
        }

    }
}