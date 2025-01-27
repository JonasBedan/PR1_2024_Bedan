namespace done_je_v_norme_lvl2
{
    internal class Program
    {
        //tuto metodu neměňte
        public static void Main(string[] args)
        {
            Console.WriteLine(JeVNorme(52.1, 50, 10)); //true
            Console.WriteLine(JeVNorme(55.1, 50, 10)); //false
            Console.WriteLine(JeVNorme(128.3, 130, 1.5)); //true
            Console.WriteLine(JeVNorme(128, 130, 1.5)); //false
        }

        //zde pište váš kód
        public static bool JeVNorme(double skutecny, double spravny, double tolerance)
        {
            if ((skutecny/100 > (spravny/100)+(tolerance/100)) || (skutecny / 100 < (spravny / 100) - (tolerance / 100)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
