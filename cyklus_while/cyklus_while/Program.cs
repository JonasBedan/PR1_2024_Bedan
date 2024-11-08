namespace cyklus_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocet = 10;
            int pruchod = 0;//promnena pro pocitani aktualniho pruchodu cyklem
            bool ok = false;    

            do {
                Console.Write("zadej hodnotu: ");
                //int.TryParse(Console.ReadLine(), out pocet);//misto pocet = int.Parse(Console.Readline()); //ošetří zadání jine hodnoty nez int
            } while (!int.TryParse(Console.ReadLine(), out pocet));

            while (pruchod <= pocet) 
            {
                Console.WriteLine("aktuální průchod je : "+pruchod);
                pruchod++;// pruchod = pruchod + 1, pruchod--, pruchod +=1
            }
        }
    }
}
