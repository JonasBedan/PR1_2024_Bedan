namespace done_nahodne_rozmisteni
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool[,] mapa = VytvorMapu(8, 12, 30);
            VykresliPole(mapa, '#', ' ');
        }

        static bool[,] VytvorMapu(int vyska, int sirka, int pocetMinci)
        {
            //sem přijde váš kód pro tuto úlohu
            Random random = new Random();
            int x;
            int y;

            
            bool[,] matice = new bool[vyska, sirka];
            for (int i = 0; i < pocetMinci; i++) 
            { 
                 
                 x = random.Next(0, sirka);
                 y = random.Next(0, vyska);
                    
                 matice[x, y] = true;
                 
            }
            return matice;

           
        }

        //sem si vložte překopírovanou metodu VykresliPole z úlohy 07 / 020
        
    }
}
