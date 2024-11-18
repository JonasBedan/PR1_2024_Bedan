using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int tah = 0;
        Random rnd = new Random();
        int hod;
        int pozice = 0;

        Console.WriteLine("Start: Pozice 1");
        do
        {
            hod = rnd.Next(1, 7);
            tah++;
            Console.WriteLine("Tah "+tah+": Hod "+hod+", pozice"+pozice);

            if ((pozice % 11) == 0)
            {
                pozice = pozice + 10;
                Console.WriteLine("+ Žebřík: Pozice " + pozice);
            }
            else if ((pozice % 13) == 0)
            {
                pozice = pozice - 12;
                Console.WriteLine("+ Had: Pozice " + pozice);
            }
            else 
            {
                pozice = pozice + hod;
            }

        } while (pozice < 100);
        Console.WriteLine("Konec ve "+tah+". tahu");
    }
}