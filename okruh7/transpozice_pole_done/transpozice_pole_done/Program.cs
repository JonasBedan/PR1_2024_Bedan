namespace transpozice_pole_done
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            int[,] tabulka1 =
            {
            {3, 4, 7},
            {5, 9, 1},
            {1, 3, 2}
        };

            Console.WriteLine();

            int[,] tabulka2 =
            {
            {3, 1, 0},
            {2, 4, 5},
            {6, 7, 1},
            {0, 1, 2}
        };

            Console.WriteLine();

            int[,] transpozice1 = Transponuj(tabulka1);
            Vypis2DPole(transpozice1);
            Console.WriteLine();

            int[,] transpozice2 = Transponuj(tabulka2);
            Vypis2DPole(transpozice2);
            Console.WriteLine();

            //tohle by mělo vypsat nezměněné pole tabulka1 - jsou tam 2 transpozice za sebou
            Vypis2DPole(Transponuj(Transponuj(tabulka1)));
        }

        //sem přijde kód vaší metody Transponuj
        public static int[,] Transponuj(int[,] pole)
        {
            int radky = pole.GetLength(0);
            int sloupce = pole.GetLength(1);
            int[,] nova = new int[sloupce, radky];

            for (int i = 0; i < radky; i++)
            {
                for (int j = 0; j < sloupce; j++)
                {
                    nova[j, i] = pole[i, j];
                }
            }
            return nova;
        }


        //konec vašeho kódu

        public static void Vypis2DPole(int[,] pole)
        {
            //do kódu této metody nezasahujte
            for (int y = 0; y < pole.GetLength(0); y++)
            {
                for (int x = 0; x < pole.GetLength(1); x++)
                {
                    Console.Write(pole[y, x]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
