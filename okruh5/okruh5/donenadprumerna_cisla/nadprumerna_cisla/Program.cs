using System.Diagnostics;

namespace nadprumerna_cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[5];
            float prumer = 0;
            
            List<int> splnene_slova = new List<int>();
            for (int i = 0; i < ints.Length; i++)
            {
                do
                {
                    Console.Write((i + 1) + ". řetězec:");
                } while (!int.TryParse(Console.ReadLine(), out ints[i]));
                prumer += ints[i];
                
            }
            prumer = prumer / ints.Length;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > prumer)
                {
                    splnene_slova.Add(ints[i]);
                }
            }

            Console.WriteLine("hodnoty které byly větší než průměr byly tyto:");
            for (int i = 0; i < splnene_slova.Count; i++)
            {
                Console.WriteLine(splnene_slova[i]);
            }
            Console.WriteLine("průměr byl "+ prumer);
        }
    }
}
