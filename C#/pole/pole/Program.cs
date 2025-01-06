namespace pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int velikost;
            do {
                Console.Write("Zadej velikost pole: ");
            }while ((!int.TryParse(Console.ReadLine(), out velikost))|| velikost <=0);

            int[] pole = new int[velikost];

            for (int i = 0; i < pole.Length; i++) 
            {
                do {
                    Console.Write($"Zadej Hodnotu pro pozici {i+1} : ");
                } while (!int.TryParse(Console.ReadLine(), out pole[i]));
                
            }

            for (int i = 0; i < pole.Length; i++) 
            {
                Console.Write($"{pole[i]} ");
            }

            Console.WriteLine();

            foreach (int vcela in pole) 
            {
                Console.Write($"{vcela} ");
            }
        }
    }
}
