namespace ceho_je_vic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pole = { -20, -11, 0, 10, -7, 12, -83, 0, 0, 15 };
            int zapornych = 0;
            int kladnych = 0;

            for (int i = 0; i < pole.Length; i++) 
            {
                if (pole[i] < 0)
                {
                    zapornych++;
                }
                else if (pole[i] > 0) 
                {
                    kladnych++;
                }
            }

            if (kladnych > zapornych)
            {
                Console.WriteLine("Kladných je víc než záporných.");
            }
            else if (kladnych < zapornych)
            {
                Console.WriteLine("Záporných je víc než kladných.");
            }
            else 
            {
                Console.WriteLine("záporných i kladných je stejně");
            }
        }
    }
}
