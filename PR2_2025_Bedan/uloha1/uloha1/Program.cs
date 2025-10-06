using System;

namespace uloha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cislo;
            do
            {
                Console.Write("Napiš číslo: ");
            } while (!int.TryParse(Console.ReadLine(), out cislo));

            toBinary(cislo);

            int max = int.MinValue;
            int min = int.MaxValue;
            int[] ints = new int[10];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rnd.Next(1, 101);
                Console.Write(ints[i] + ",");
                if (ints[i] > max)
                    max = ints[i];
                else if (ints[i] < min)
                    min = ints[i];
            }
            Console.WriteLine($"minimum: {min}");
            Console.WriteLine($"maximum: {max}");

            int prumer = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                prumer += ints[i];
            }
            prumer = prumer / ints.Length;

            Array.Sort(ints);
            foreach (int i in ints)
            {
                Console.Write(i + ",");
            }

            int[,] matice = new int[5,5];
            int soucet = 0;
            List<int> list = new List<int>();
            Console.WriteLine();
            Console.WriteLine("---------------");
            for(int i = 0;i < matice.GetLength(0);i++)
            {
                
                Console.Write("|");
                for (int j = 0; j < matice.GetLength(1);j++)
                {
                    matice[i,j] = rnd.Next(1,51);
                    Console.Write(matice[i,j]+"|");
                    soucet += matice[i, j];

                    if (i == j) 
                    {
                        list.Add(matice[i,j]);    
                    }
                }
                Console.WriteLine();
                Console.WriteLine("---------------");
            }
            Console.WriteLine("součet:"+soucet);

            foreach (int i in list)
            {  Console.Write(i+","); }

            int[,] ints1 = new int[4,4];

        }

        static void toBinary(int x)
        {
            string binary = Convert.ToString(x, 2);
            Console.WriteLine(binary);
        }

        static int[] vytvorPole(int x)
        {
            int[] ints = new int[x];
            Random random = new Random();
            for (int i = 0; i < ints.Length; i++) 
            {
                ints[i] = random.Next(10, 51);
            }
            return ints;
        }

        static void vypisPole(int[] pole)
        {
            foreach (int x in pole)
                Console.WriteLine(x);
        }

        static int najdiMinimum(int[] pole) 
        {
            int min = int.MaxValue;
            for (int i = 0;i < pole.Length;i++)
            {
                if (pole[i] < min) 
                {
                    min = pole[i];
                }
            }
            return min;
        }

        static int najdiMaximum(int[] pole)
        {
            int max = int.MinValue;
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] > max)
                {
                    max = pole[i];
                }
            }
            return max;
        }

        static int vypocitejPrumer(int[] pole)
        {
            int prumer = 0;
            for (int i = 0; i < pole.Length; i++) 
            {
                prumer += pole[i];
            }
            prumer = prumer/pole.Length;
            return prumer;
        }
    }
}
