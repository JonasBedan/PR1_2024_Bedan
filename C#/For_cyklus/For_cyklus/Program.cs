namespace For_cyklus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(i);
            }*/

            /*for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }*/

            for (int i = 2; i <= 10; i = i+2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
