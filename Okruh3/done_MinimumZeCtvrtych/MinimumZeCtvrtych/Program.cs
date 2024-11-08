using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int hodnota;
        int minimum = int.MaxValue;
        int pocet = 0;

        do
        {
            do
            {
                Console.Write("zadej hodnotu: ");
            } while (!int.TryParse(Console.ReadLine(), out hodnota));
            pocet++;
            if (hodnota > 0)
            {
                if (hodnota < minimum&&((pocet%4)==0)) { minimum = hodnota; }

            }


        } while (hodnota > 0);
        Console.WriteLine("aktualni hodnota: "+hodnota);
        Console.WriteLine("minimalni hodnota: "+minimum);
    }
}