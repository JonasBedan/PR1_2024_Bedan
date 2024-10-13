using System;
using System.IO.Pipes;

class MainClass
{
    public static void Main(string[] args)
    {
        // Sem přijde váš kód
        // uvnitř tohoto kódu musí vzniknout proměnné jeHezky a chciVen 
        Console.WriteLine("je venku hezky (a/n)?");
        char odpoved1 = char.Parse(Console.ReadLine());
        bool jeHezky;
        if (odpoved1 == 'a')
        {
            jeHezky = true;
        }
        else { jeHezky = false; }

        Console.WriteLine("chce se ti ven? (a/n)?");
        char odpoved2 = char.Parse(Console.ReadLine());
        bool chciVen;
        if (odpoved2 == 'a')
        {
            chciVen = true;
        }
        else { chciVen = false; }

        // Konec vašeho kódu

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