namespace done_nuly_nakonec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { 1, -5, 0,0, 4, 0, 7, 12, 0, 4 };
            int[] cisla2 = new int[cisla.Length];
            int j = 0;
            for (int i = 0; i < cisla.Length; i++) //trochu překombinované ale dělal jsem to pod stresem
            {
                while (cisla[i] == 0) 
                {
                    i++;
                }
                cisla2[j] = cisla[i];
                j++;
              
            }

            Console.WriteLine(String.Join(", ", cisla2));
        }
    }
}
