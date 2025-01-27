namespace done_obvod_kruhu
{
    internal class Program
    {
        public static double Obvod(double x) 
        {
            double vysledek = (2 * x) * 3.14;
            return vysledek;
        }
        //tuto metodu neměňte
        public static void Main(string[] args)
        {
            double polomer = 3;
            Console.WriteLine($"Obvod kruhu o poloměru {polomer} je {Obvod(polomer)}");
            polomer = 1.5;
            Console.WriteLine($"Obvod kruhu o poloměru {polomer} je {Obvod(polomer)}");
        }

        //Sem přijde váš kód
    }
}
