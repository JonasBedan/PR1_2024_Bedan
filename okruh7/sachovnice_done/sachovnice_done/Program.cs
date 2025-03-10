using System;

namespace sachovnice_done
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] sachovnice = {
                { 'R', 'k', 'B', 'Q', 'K', 'B', 'k', 'R' },
                { 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p' },
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                { 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p' },
                { 'R', 'k', 'B', 'Q', 'K', 'B', 'k', 'R' },
            };

            zobraz(sachovnice);

           
            for (int i = sachovnice.GetLength(0)-1; i > 0; i--)
            {
                for (int j = 0; j < sachovnice.GetLength(1); j++)
                {
                    if (i == 1 && j == 4) 
                    {
                        sachovnice[i + 2, j] = 'p';
                        sachovnice[i, j] = ' '; 
                    }
                }
            }

            Console.WriteLine();
            zobraz(sachovnice);
        }

        public static void zobraz(char[,] sachovnice)
        {
            for (int i = sachovnice.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < sachovnice.GetLength(1); j++)
                {
                    Console.Write(sachovnice[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static bool jeBile(int x, int y) 
        {
            if ((x % 2 == 0 && y % 2 == 0)||(x % 2 == 1 && y % 2 ==1))
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
    }
}
