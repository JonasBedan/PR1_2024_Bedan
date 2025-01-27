namespace done_kbeliky
{
    internal class Program
    {
        //Napište metodu i její zavolání
        public static double kbeliky(double delka, double vyska, double sirka, double objem_kbeliku)
        {
            double plocha = ((delka * vyska) * 2) + ((sirka * vyska) * 2) + (sirka * delka);
            double kbeliky = plocha / objem_kbeliku;
            return kbeliky;
        }
        public static void Main(string[] args)
        {
            double vyska;
            double sirka;
            double delka;
            double objem_kbeliku;

            do
            {
                Console.Write("výška místnosti: ");
            }while(!double.TryParse(Console.ReadLine(), out vyska));

            do
            {
                Console.Write("šířka místnosti: ");
            } while (!double.TryParse(Console.ReadLine(), out sirka));

            do
            {
                Console.Write("délka místnoti: ");
            } while (!double.TryParse(Console.ReadLine(), out delka));

            do
            {
                Console.Write("kolik metrů čtverečných pokrije jeden kbelík barvy: ");
            } while (!double.TryParse(Console.ReadLine(), out objem_kbeliku));

            Console.WriteLine(kbeliky(delka,vyska, sirka, objem_kbeliku));

            //ověřte, že 
            // * pro hodnoty 3, 4, 2.8, 18 bude vráceno 3
            // * pro hodnoty 5, 6, 3.2, 32 bude vráceno 4
        }
    }
}

