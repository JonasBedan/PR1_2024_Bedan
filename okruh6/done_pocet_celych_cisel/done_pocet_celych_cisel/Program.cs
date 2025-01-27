namespace done_pocet_celych_cisel
{
    internal class Program
    {
        public static int PocetCelych(double[] cisla)
        {
            int pocet = 0;
            for (int i = 0; i < cisla.Length; i++)
            {
                if (cisla[i] % 1 == 0)
                {
                   
                    pocet++;
                }

            }
            return pocet;

        }

        //tuto metodu neměňte
        public static void Main(string[] args)
            {
                double[] cisla = { 1.3, 1.7, 2, 3.1, 0.1, -1 };
                //obsahuje 2 celá čísla, 2 a -1

                Console.WriteLine(
                    "Pole  [{0}] obsahuje {1} celých čísel",
                    string.Join("; ", cisla),
                    PocetCelych(cisla)
                );
            }

        //zde deklarujte vaši metodu
        
    }
}
