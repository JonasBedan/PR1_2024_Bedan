using System;

class MainClass
{
    public static void Main(string[] args)
    {

        // Nastavte si proměnné
        
        bool jeMlady = true;
        bool jeHezky = false;
        bool jeBohaty = false;

        // tuto podmínku je třeba doplnit
        if (((jeHezky == true))||((jeHezky==false)&&(jeMlady==false)&&(jeBohaty==true)))
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