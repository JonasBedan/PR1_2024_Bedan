namespace napln_a_vypis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "sever", "jih", "západ", "východ" };

            for (int i = 0; i < strings.Length; i++) 
            {
                Console.WriteLine("jdi na " + strings[i]);
            }
        }
    }
}
