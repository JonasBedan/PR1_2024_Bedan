namespace done_histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3,  7, 4, 9};

            for (int i = 0; i < array.Length; i++) 
            {
                for (int j = 0; j < array[i]; j++) 
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
