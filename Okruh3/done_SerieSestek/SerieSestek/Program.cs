using System;

class MainClass
{
    public static void Main(string[] args)
    {
        /* level1
        Random kostka = new Random();
        int pocetHodu = 0;
        int aktHod = 0;
        int aktSerie = 0;
        int maxSerie = 0;
        int kostkaHod;

        do {
            Console.Write("Zadej počet hodu kostkou:");
        } while (int.TryParse(Console.ReadLine(), out pocetHodu)==false);

        while (aktHod < pocetHodu)
        { 
            kostkaHod = kostka.Next(1,7);
            Console.WriteLine(kostkaHod);
            aktHod++;

            if (kostkaHod == 6)
            {
                aktSerie++;
                if (aktSerie > maxSerie)
                {
                    maxSerie = aktSerie;
                }

            }
            else 
            { 
                aktSerie = 0; 
            }

            
        }
        Console.WriteLine("Maximální serie je: "+maxSerie); 
        */
        //level2
        Random kostka = new Random();
        int pocetSestek = 0;
        int aktHod = 0;
        int aktSerie = 0;
        int maxSerie = 0;
        int kostkaHod;

        do
        {
            Console.Write("Zadej jak dlouhá má být serie šestek:");
        } while (int.TryParse(Console.ReadLine(), out pocetSestek) == false);

        while (maxSerie != pocetSestek)
        {
            kostkaHod = kostka.Next(1, 7);
            Console.WriteLine(kostkaHod);
            aktHod++;

            if (kostkaHod == 6)
            {
                aktSerie++;
                if (aktSerie > maxSerie)
                {
                    maxSerie = aktSerie;
                }

            }
            else
            {
                aktSerie = 0;
            }

        }
        Console.WriteLine("Trvalo to " + aktHod + " hodů");
    }
}