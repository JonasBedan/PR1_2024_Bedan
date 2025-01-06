namespace done_MiniMax
{
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            /** double[] array = { 1.22, -1.20, -2,2.35,4.75, 100, -200 };
            double minimum = double.MaxValue;
            double maximum = double.MinValue;

            foreach (double d in array) 
            {
                if (d < minimum) 
                {
                    minimum = d;
                }
                if (d > minimum) 
                {
                    maximum = d;
                }
                
            }
            Console.WriteLine($"maximální číslo je {maximum}, minimální číslo je {minimum}");**/
            double[] array = { 1.22, -1.20, -2, 2.35, 4.75, 100, -200 };
            double minimum = array.Min();
            double maximum = array.Max();
            Console.WriteLine($"{maximum} je maximum, {minimum} je minimum");
        }
    }
}
