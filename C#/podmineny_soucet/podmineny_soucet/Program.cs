namespace podmineny_soucet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { 25, -56, -88, 5, 10, 65, 584, -8, -120, 186};
            int soucet = 0;

            for (int i = 0; i < cisla.Length; i++) 
            {
                
                if ((cisla[i] > -10) && (cisla[i] < 10)) 
                {
                    soucet = soucet + cisla[i];
                    
                }
            }
            Console.WriteLine(soucet);
        }
    }
}
