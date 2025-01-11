namespace pracovní_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocet_studentu;
            do 
            {
                Console.Write("kolik je ve třídě studentů: ");
            }while(!int.TryParse(Console.ReadLine(), out pocet_studentu));
            int[] vysledky = new int[pocet_studentu];
            string[] jmena_studentu = new string[pocet_studentu];

            Console.WriteLine();

            for (int i = 0; i < vysledky.Length; i++) 
            {
                Console.Write((i+1)+". student se jmenuje: ");
                jmena_studentu[i] = Console.ReadLine();
            }

            for (int i = 0; i < jmena_studentu.Length; i++)
            {
                do
                {
                    Console.WriteLine("jakou známku dostal/a " + jmena_studentu[i] + ":");
                } while (!int.TryParse(Console.ReadLine(), out vysledky[i]));
            }

            int prumer = 0;
            for (int i = 0; i < vysledky.Length; i++)
            {
                prumer += vysledky[i];
            }

            prumer = prumer / pocet_studentu;
            Console.WriteLine("průměrná známka byla:"+prumer);

            int max = int.MinValue;
            int min = int.MaxValue;
            int vyssi = 0;
            int[] nizsi = new int[2];

            for (int i = 0; i < vysledky.Length; i++) 
            {
                if (min < vysledky[i]) 
                {
                    min = vysledky[i];
                }
                if (max > vysledky[i])
                {
                    max = vysledky[i];
                }
                if (vysledky[i] >= prumer) 
                {
                    vyssi++;
                }
                if (vysledky[i] < 3) 
                {
                    if (vysledky[i] == 1)
                    {
                        nizsi[0] = 1;
                    }
                    else 
                    {
                        nizsi[1] = 2;
                    }
                    
                }
            }

            Console.WriteLine("nejhorší známka byla "+max);
            Console.WriteLine("nejlepší známka byla "+min);


        }
    }
} 