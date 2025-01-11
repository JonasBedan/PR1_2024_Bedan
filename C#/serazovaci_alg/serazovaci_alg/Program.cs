using System.Diagnostics;
namespace serazovaci_alg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[100000];
            int x;
            Random random = new Random();
            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < pole.Length; i++) 
            {
                pole[i] = random.Next(1,101);
                //Console.Write(pole[i]+",");
            }

            //bubble sort
            sw.Start();
            for (int i = 0; i < pole.Length - 1; i++) 
            {
                for (int j = 0; j < pole.Length - 1 - i; j++) 
                {
                    if (pole[j] > pole[j + 1]) 
                    {
                        x = pole[j];
                        pole[j] = pole[j + 1];
                        pole[j+1] = x;
                    } 
                }
            }
            sw.Stop();
            long casBubble = sw.ElapsedMilliseconds;
            Console.WriteLine("Bubble sort: " + casBubble + " ms");

            //min sort
            sw.Restart();
            int min = int.MaxValue;
            for (int i = 0; i < pole.Length - 1; i++)
            {
                if (pole[i] < min) 
                {
                    min = pole[i];
                    pole[i] = pole[0];
                }
            }
            sw.Stop();
            long casMin = sw.ElapsedMilliseconds;
            Console.WriteLine("Min sort: " + casMin + " ms");


        }
    }
}
