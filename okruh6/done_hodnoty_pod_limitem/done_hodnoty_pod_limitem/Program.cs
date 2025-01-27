namespace done_hodnoty_pod_limitem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double[] cisla = { -1.3, 2.2, 1.5, 1.4, 2.7 };
            Console.WriteLine(PodLimitem(cisla, 1.5)); //vypíše -1.3 a 1.4 
            Console.WriteLine(PodLimitem(cisla, 1.6)); //vypíše -1.3 , 1.5 a 1.4
        }

        //zde deklarujte vaši metodu
        public static double[] PodLimitem(double[] cisla, double value) 
        {
            double[] limit = new double[cisla.Length];
            for (int i = 0; i < cisla.Length; i++) 
            {
                if (cisla[i] < value) 
                {
                    limit[i] = cisla[i];
                }

            }
            return limit;
        }
    }
}
