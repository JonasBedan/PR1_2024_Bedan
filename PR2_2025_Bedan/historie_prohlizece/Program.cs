namespace historie_prohlizece
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            //pridani stranky
            stack.Push(1);
            stack.Push(2);

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }

            //kouknuti se na predchozi stranku 
            Console.WriteLine(stack.Pop());

            //kouknuti se na posledni stranku
            Console.WriteLine(stack.Peek());
        }
    }
}
