namespace tabulka_vzadelnosti_done
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mapa mapa = new Mapa();

            //do proměnné města uložíme všechna města z mapy
            string[] mesta = mapa.Rejstrik;
            //můžeme je i vypsat
            Console.WriteLine(String.Join(", ", mesta));

            //chceme-li zjistit vzdálenost dvou měst, zeptáme se na ni naší mapy takto
            double vzdalenost12 = mapa.Vzdalenost(1, 3);

            //takto bychom ji vypsali
            Console.WriteLine($"Vzdálenost {mesta[1]} a {mesta[2]} je {vzdalenost12} km");

            //nyní seskládejte a vypište tabulku vzdálenost
            double[,] vzdalenosti = new double[mesta.Length, mesta.Length];
            for (int i = 0; i < mapa.Rejstrik.Length-1; i++) 
            {
                for (int j = 0; i < mesta.Length-1; j++) 
                {
                    vzdalenosti[i, j] = mapa.Vzdalenost(i, j);
                    Console.Write(vzdalenosti[i,j]+"|");
                }
                Console.WriteLine();
            }


        }
    }
}
