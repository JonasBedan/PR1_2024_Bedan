namespace NamalujTrojuhelnikTyp_q
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vyska;

            Console.Write("Jaká má být výška trojúhelníku: ");
            int.TryParse(Console.ReadLine(), out vyska);

            for (int i = 0; i < vyska; i++) 
            {
                for (int j = 0; j < vyska+1; j++) 
                {
                    Console.Write("");
                }
                for (int j = 0; j < vyska - 1-i; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
