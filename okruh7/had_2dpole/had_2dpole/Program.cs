using System;
using System.Collections.Generic;

namespace had_2dpole
{
    internal class Program
    {
        static int score = 0; 

        static void Main(string[] args)
        {
            char[,] pole = new char[10, 10];
            char smer = 'd';

            List<int[]> snakeBody = new List<int[]> // Ukládáme historii pozic hada
            {
                new int[] { 5, 2 }, // Hlava
                new int[] { 5, 3 }  // Ocas
            };

            int[] jablko = Jablko(); // Generujeme jablko pouze jednou na začátku

            while (true) 
            {
                Console.Clear();
                Pole(pole, snakeBody, jablko);

                if (Console.KeyAvailable) // Pouze pokud hráč stiskne klávesu
                {
                    char newDirection = Pohyb();

                    // Zabrání otočení o 180 stupňů
                    if ((smer == 'w' && newDirection != 's') ||
                        (smer == 's' && newDirection != 'w') ||
                        (smer == 'a' && newDirection != 'd') ||
                        (smer == 'd' && newDirection != 'a'))
                    {
                        smer = newDirection; // Aktualizace směru
                    }
                }

                pole = nove_pole(pole, snakeBody, smer, ref jablko);
                Thread.Sleep(200); // Rychlost pohybu hada

            }
        }

        public static void Pole(char[,] pole, List<int[]> snakeBody, int[] jablko)
        {
            Console.Clear();
            int[] head = new int[] { snakeBody[0][0], snakeBody[0][1] };

            // Vymazání starého pole
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    pole[i, j] = ' ';
                }
            }

            // Vykreslení hada
            foreach (var segment in snakeBody)
            {
                pole[segment[0], segment[1]] = '■';
            }

            // Kontrola, zda had snědl jablko
            if (head[0] == jablko[0] && head[1] == jablko[1])
            {
                score++; // Zvýšíme score
            }

            // Vykreslení jablka (stále na stejném místě, dokud ho had nesní)
            pole[jablko[0], jablko[1]] = 'a';

            // Vykreslení do konzole
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("|" + pole[i, j]);
                }
                Console.Write('|');
                Console.WriteLine();
            }
            Console.WriteLine("Score: " + score);
        }

        //načítá klavesy pro pohyb hada
        public static char Pohyb()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);//nechal jsem si poradit :)
            return keyInfo.KeyChar;
        }

        //generace jablka
        public static int[] Jablko()
        {
            Random random = new Random();
            return new int[] { random.Next(0, 10), random.Next(0, 10) };
        }

        //vytvoří pole které se promítne po tom které zrovna vidím
        public static char[,] nove_pole(char[,] pole, List<int[]> snakeBody, char stisknuta_klavesa, ref int[] jablko)
        {
            int[] head = new int[] { snakeBody[0][0], snakeBody[0][1] }; // Aktuální hlava
            char currentDirection = stisknuta_klavesa;

            

            // Posunutí hlavy podle vstupu 
            switch (stisknuta_klavesa)
            {
                case 'w': head[0]--; break; // Nahoru
                case 's': head[0]++; break; // Dolů
                case 'a': head[1]--; break; // Doleva
                case 'd': head[1]++; break; // Doprava
                default: return pole; // Pokud není stisknuta správná klávesa, neměníme směr
            }

            // Kontrola, zda had snědl jablko
            bool snedlJablko = (head[0] == jablko[0] && head[1] == jablko[1]);

            // Posunutí těla - Každý segment se přesune na pozici předchozího segmentu
            for (int i = snakeBody.Count - 1; i > 0; i--)
            {
                snakeBody[i][0] = snakeBody[i - 1][0];
                snakeBody[i][1] = snakeBody[i - 1][1];
            }

            // Aktualizace pozice hlavy
            snakeBody[0][0] = head[0];
            snakeBody[0][1] = head[1];

            for (int i = 1; i < snakeBody.Count; i++) // Začínáme od 1, protože index 0 je hlava
            {
                if (head[0] == snakeBody[i][0] && head[1] == snakeBody[i][1]) // Pokud hlava koliduje s částí těla
                {
                    Console.WriteLine("Game Over!");
                    Environment.Exit(0); // Ukončí program
                }
            }

            //nesmí se otočit o 180 stupňů
            if ((stisknuta_klavesa == 'w' && currentDirection == 's') || (stisknuta_klavesa == 's' && currentDirection == 'w') || (stisknuta_klavesa == 'a' && currentDirection == 'd') || (stisknuta_klavesa == 'd' && currentDirection == 'a'))
            {
                stisknuta_klavesa = currentDirection;
            }
            else 
            {
                currentDirection = stisknuta_klavesa;
            }

            // Pokud had snědl jablko, přidáme nový segment na konec těla a vygenerujeme nové jablko
            if (snedlJablko)
            {
                int[] newTailSegment = new int[2] { snakeBody[^1][0], snakeBody[^1][1] };
                snakeBody.Add(newTailSegment);
                score++; // Zvýšení skóre
                jablko = Jablko(); // Nové jablko se generuje pouze tehdy, když je snědené
            }

            return pole;
        }
    }
}
