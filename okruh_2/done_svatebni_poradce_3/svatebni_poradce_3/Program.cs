using System;

class MainClass
{
    public static void Main(string[] args)
    {

        // Nastavte si proměnné
        bool jeStary = true;
        bool jeHezky = true;
        bool jeChudy = true;

        // tuto podmínku je třeba doplnit
        if (((jeStary==true)&&(jeHezky==false)&&(jeChudy==false))||(jeHezky==true))
        // zde končí úpravy
        {
            Console.WriteLine("Vezmi si ho!");
        }
        else
        {
            Console.WriteLine("Toho si neber!");
        }


    }
}