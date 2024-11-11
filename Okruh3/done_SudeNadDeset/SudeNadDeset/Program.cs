using System;

class MainClass
{
    public static void Main(string[] args)
    {
        bool podminky = false;
        int vstup;
        Console.Write("Zadej sudé číslo větší než 10: ");

        do
        {
            int.TryParse(Console.ReadLine(), out vstup);

            if (((vstup % 2) == 0)&&(vstup>10))
            {
                podminky = true;
            }
            else
            {
                Console.Write("To nevyhovuje podmínkám (sudé větší než deset), zkus to znovu: ");
            }


        } while (podminky == false);        
        Console.WriteLine("zadal jsi: " + vstup);

    }
}