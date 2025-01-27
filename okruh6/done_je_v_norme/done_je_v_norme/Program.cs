namespace done_je_v_norme
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(JeVNorme(35.1, 33, 3.5)); //true
            Console.WriteLine(JeVNorme(35.1, 33, 1.5)); //false
            Console.WriteLine(JeVNorme(11.8, 13, 1.3)); //true
        }

        //zde napište vaši metodu
        public static bool JeVNorme(double skutecny, double spravny, double tolerance) 
        {
            if ((skutecny - spravny > tolerance)||(skutecny - spravny < tolerance - (tolerance * 2)))
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
