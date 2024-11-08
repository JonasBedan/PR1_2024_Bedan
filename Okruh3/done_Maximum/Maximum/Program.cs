using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int maximum = int.MinValue;
        int hodnota;
        do {
            do
            {
                Console.Write("zadej hodnotu: ");
            } while (!int.TryParse(Console.ReadLine(), out hodnota));

            if (hodnota > 0) 
            {
                if (hodnota > maximum) { maximum = hodnota; }    

            }

            
        } while (hodnota>0);
        Console.WriteLine("atuální hodnota je: "+hodnota);
        Console.WriteLine("maximalni hodnota je: "+maximum);

    }
}