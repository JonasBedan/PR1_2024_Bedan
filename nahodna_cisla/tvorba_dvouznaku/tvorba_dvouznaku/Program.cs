namespace tvorba_dvouznaku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int velikost = generator.Next(1,3);
            int velikost2 = generator.Next(1, 3);
            int kodPismeno;
            int kodPismeno2;

            if (velikost == 1)
            {
                kodPismeno = generator.Next(65, 91);
            }
            else
            {
                kodPismeno = generator.Next(97, 122);
            }

            if (velikost2 == 1)
            {
                kodPismeno2 = generator.Next(65, 91);
            }
            else
            {
                kodPismeno2 = generator.Next(97, 122);
            }

            char pismeno = (char)kodPismeno;
            char pismeno2 = (char)kodPismeno2;
            Console.WriteLine(pismeno.ToString() + pismeno2.ToString());
        }
    }
}
