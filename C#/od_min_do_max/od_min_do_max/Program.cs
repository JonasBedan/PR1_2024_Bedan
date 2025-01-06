namespace od_min_do_max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 7, 2, 8, 1, -2, 9, -10, 0, 1 };
            int pozice;
            int min = int.MaxValue;
            int max = int.MinValue;
            string odpoved;

            
            Console.Write("Chceš seřadit pole vzestupně(A) nebo sestupně(B): ");
            odpoved = Console.ReadLine();


            if (odpoved == "A" || odpoved == "a")
            {
                Array.Sort(ints);
                foreach (int i in ints)
                {
                    Console.Write(i + ", ");
                }
                Console.WriteLine();
            }
            else if (odpoved == "a" || odpoved == "b")
            {
                Array.Sort(ints);
                Array.Reverse(ints);
                foreach (int i in ints)
                {
                    Console.Write(i + ", ");
                }
                Console.WriteLine();
            }
            else 
            {
                Console.WriteLine("nezadal jsi ani A ani B, zkus to znovu");
                Main(args);
            }


            for (int i = 0; i < ints.Length; i++) 
            {
                pozice = i;
                min = ints[i];
                for (int j = i+1; j < ints.Length; j++) {
                    if (ints[j] < min) 
                    {
                        pozice = j;
                        min = ints[j];
                    }
                }
                int pom = ints[i];
                ints[i] = min;
                ints[pozice] = pom;
            }
            foreach (int i in ints) 
            {
                Console.Write(i+", ");
            }
            Console.WriteLine();

            for (int i = 0; i < ints.Length; i++) 
            {
                pozice = i;
                max = ints[i];
                for (int j = i+1; j < ints.Length; j++) {
                    if (ints[j] > max) 
                    {
                        pozice = j;
                        max = ints[j];
                    }
                }
                int pom = ints[i];
                ints[i] = max;
                ints[pozice] = pom;
            }
            foreach (int i in ints) 
            {
                Console.Write(i+", ");
            }
            Console.WriteLine();
            
            
        }
    }
}
