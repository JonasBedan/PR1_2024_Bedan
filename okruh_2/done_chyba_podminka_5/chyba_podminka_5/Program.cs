using System;

class MainClass
{
    public static void Main(string[] args)
    {

        // Nastavíme proměnnou
        bool mamHlad = true;


        // A teď ji otestujeme
        if (mamHlad == false)
        {
            Console.WriteLine("Nežer, ztloustneš!");
        }
        else
        {
            Console.WriteLine("Je čas se najíst.");
        }

    }
}