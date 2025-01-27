namespace vymena2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int cislo = Generovani_cisel();
            int cislo2;
            Console.WriteLine("Mylím si číslo, dokážeš ho uhodnout?");
            
            do {
                cislo2 = nacteni();
                porovnani(cislo2, cislo);
            }while (cislo!=cislo2);
        }


        public static int Generovani_cisel()
        {
            Random generator = new Random();
            int vygenerovane_cislo = generator.Next(0, 101);

            return vygenerovane_cislo;
        }

        public static void porovnani(int guess, int Generovani_cisel)
        {
            if (guess < Generovani_cisel)
            {
                Console.WriteLine("Vyšší");
            }
            else if (guess > Generovani_cisel) 
            { 
                Console.WriteLine("Nižší"); 
            }
            else 
            {
                Console.WriteLine("Uhodl");
            }

        }

        public static int nacteni() 
        {
            int guess;
            do
            {
                Console.Write("Jaké číslo si myslím: ");
            } while (!int.TryParse(Console.ReadLine(), out guess));
            return guess;
        }
    }
}
