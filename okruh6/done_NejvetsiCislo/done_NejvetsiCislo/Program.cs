namespace done_NejvetsiCislo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double cislo1 = 1.3;
            double cislo2 = 4.6;
            double cislo3 = -3.3;
            double maximum = maximu(cislo1,cislo2, cislo3);//sem doplňte zavolání metody
            Console.WriteLine($"Největší ze zadaných čísel je {maximum}.");
        }

        //sem napište deklaraci metody
        public static double maximu(double cislo1, double cislo2, double cislo3) 
        {

            return Math.Max(cislo1, Math.Max(cislo2, cislo3));
        }
    }
}
