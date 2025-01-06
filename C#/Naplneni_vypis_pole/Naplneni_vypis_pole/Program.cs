namespace Naplneni_vypis_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strany = { "sever", "jih", "zapad", "vychod" };

            for (int i = 0; i < strany.Length; i++)
            {
                Console.WriteLine("můžeš jít na " + strany[i]);
            }
        }
    }
}
