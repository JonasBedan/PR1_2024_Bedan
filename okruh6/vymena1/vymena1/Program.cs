namespace vymena1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int cislo;
            int cislo2 = generator();
            Console.WriteLine("myslím si číslo, uhodneš ho?");
            do
            {                
                cislo = nacteni();
                vyssi(cislo, cislo2);
            } while (generator != nacteni);
            
        }

        

        public static int nacteni() 
        {
            int guess;
            do {
                Console.Write("Jaké číslo si myslím: ");
            } while (!int.TryParse(Console.ReadLine(), out guess));
            return guess;
        }
        public static int generator() 
        {
            Random random = new Random();
            int cislo = random.Next(0,101);
            return cislo;
        }
        public static void vyssi(int guess, int cislo) 
        {
             
            if(guess > cislo) 
            {
                Console.WriteLine("číslo je nižší.");
            }
            else if (guess < cislo) 
            {
                Console.WriteLine("číslo je nižší.");
            }
            else
            {
                Console.WriteLine("!!!UHODL JSI!!!");
            }
            
        }

    }
}
