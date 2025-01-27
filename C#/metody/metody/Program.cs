
namespace metody
{
    internal class Program
    {
        public static void Pozdrav(string jmenoUzivatele, int pocetPrihlaseni = 1) 
        {
            int prihlaseni = soucet(pocetPrihlaseni, 1);
            Console.WriteLine("ahoj "+jmenoUzivatele+" už jsi tady byl "+prihlaseni);            
        }
        public static int soucet(int a, int b) 
        {
            int soucet = a + b;
            Console.WriteLine(soucet);
            return soucet;  
        }
        public static int[] vratLiche(int[] polecisel) 
        {
            int[] vysledek = new int[polecisel.Length];
            int pozice = 0;
            for (int i = 0; i < polecisel.Length; i++) 
            {
                if (polecisel[i]%2 != 0) 
                {
                    vysledek[pozice] = polecisel[i];
                    pozice++;
                }
            }
            return vysledek;    
        }
        static void Main(string[] args)
        {
            string uzivatel = "jmeno";
            int prihlaseni = 4;
            Pozdrav(uzivatel, prihlaseni);
            soucet(prihlaseni, 1);

            int[] x = new int[10];
            Random rand = new Random();
            for (int i = 0; i < x.Length; i++) 
            {
                x[i] = rand.Next(1, 11);
            }

            int[] lichaCisla = vratLiche(x);
            foreach(int i in lichaCisla) 
            {
                if (i == 0)
                {
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
