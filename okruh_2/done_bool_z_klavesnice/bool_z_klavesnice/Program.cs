using System;
using System.IO.Pipes;

class MainClass
{
    public static void Main(string[] args)
    {
        // Sem přijde váš kód
        // uvnitř tohoto kódu musí vzniknout proměnné jeHezky a chciVen 
        Console.WriteLine("je venku hezky (a/n)?");
        char odpoved1 = Console.ReadKey().KeyChar;
        bool jeHezky = false;
        bool chyba = false;
        if (odpoved1 == 'a')
        {
            jeHezky = true;
        }
        else if (odpoved1 == 'n') { jeHezky = false; }
        else {Console.WriteLine("neplatná hodnota");chyba = true; }

        Console.WriteLine("chce se ti ven? (a/n)?");
        char odpoved2 = Console.ReadKey().KeyChar;
        bool chciVen = false;
        if (odpoved2 == 'a')
        {
            chciVen = true;
        }
        else if (odpoved2 == 'n') { chciVen = false; }
        else { Console.WriteLine("neplatná hodnota"); chyba = true; }

        // Konec vašeho kódu
        if (chyba == false)
        {
            if (jeHezky || chciVen)
            {
                Console.WriteLine("Je čas jít ven.");
            }
            else
            {
                Console.WriteLine("Zůstaň radši doma.");
            }
        }
    }
}