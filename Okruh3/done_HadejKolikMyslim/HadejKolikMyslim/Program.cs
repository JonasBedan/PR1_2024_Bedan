using System;

class MainClass
{
    public static void Main(string[] args)
    {        
        Random rnd = new Random();
        int generator = rnd.Next(1,101);
        int cislo = 0;

        Console.WriteLine( generator);

        while (cislo != generator) 
        {
            Console.WriteLine("Jaké číslo si myslím?");
            int.TryParse(Console.ReadLine(), out cislo);

            if (cislo != generator)
            {
                Console.WriteLine("Ne nemyslím si číslo " + cislo);
                Console.WriteLine("");
                Console.WriteLine("");

            }
            else 
            {
                Console.WriteLine("Anooo!!!! Myslel jsem si číslo " + generator + ".");
                Console.WriteLine("");
            }

        } 




    }
}