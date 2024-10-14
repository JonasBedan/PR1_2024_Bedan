using System;

class MainClass
{
    public static void Main(string[] args)
    {

        // Nastavte si proměnné
        bool jeMlady = true;
        bool jeHezky = false;
        bool jeBohaty = true;

        // tuto podmínku je třeba doplnit
        if (((jeBohaty == false)&&(jeHezky==false)&&(jeBohaty==false))||((jeHezky==false)&&(jeMlady==true)))
        // zde končí úpravy
        {
            Console.WriteLine("Toho si neber!");
        }
        else
        {
            Console.WriteLine("Vezmi si ho!");
        }


    }
}