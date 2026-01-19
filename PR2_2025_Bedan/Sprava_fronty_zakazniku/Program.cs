namespace Sprava_fronty_zakazniku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("jmeno");
            queue.Dequeue();
            foreach (var item in queue) { Console.WriteLine(item); }
        }
    }
}
