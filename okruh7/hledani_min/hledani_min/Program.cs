using System.ComponentModel.Design;

namespace hledani_min
{
    internal class Program
    {
        public static int soused(int[,] ; int i ; int j) 
            {

            }
        static void Main(string[] args)
        {
            int[,] matice = new int[5,5];
            Random random = new Random();
            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j < 5; j++) 
                {
                    int x = random.Next(0,2);
                    matice[i,j] = x;
                }
            }

            int sousedu = 0;

            for (int i = 0;i < 5; i++) 
            {
                for (int j = 0; j < 5; j++)
                {
                    
                        if (matice[i - 1, j - 1] == 1 && matice[i - 1, j - 1] != null)
                        {
                            sousedu++;
                        }

                        if (matice[i - 1, j] == 1 && matice[i - 1, j] != null)
                        {
                            sousedu++;
                        }

                        if (matice[i - 1, j + 1] == 1 && matice[i - 1, j + 1] != null)
                        {
                            sousedu++;
                        }

                        if (matice[i, j - 1] == 1 && matice[i, j - 1] != null)
                        {
                            sousedu++;
                        }

                        if (matice[i, j + 1] == 1 && matice[i, j + 1] != null)
                        {
                            sousedu++;
                        }

                        if (matice[i + 1, j - 1] == 1 && matice[i + 1, j - 1] != null)
                        {
                            sousedu++;
                        }

                        if (matice[i + 1, j] == 1 && matice[i + 1, j + 1] != null)
                        {
                            sousedu++;
                        }

                        if (matice[i + 1, j + 1] == 1 && matice[i+1, j+1]!=null)
                        {
                            sousedu++;
                        }
                   
                    Console.WriteLine( sousedu);
                    sousedu = 0;
                }
               
            }
        }
    }
}
