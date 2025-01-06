namespace done_dlouhe_retezce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = new string[5];
            List<string> splnene_slova = new List<string>();
            for (int i = 0; i < strings.Length; i++) 
            {
                Console.Write((i+1)+". řetězec:");
                strings[i] = Console.ReadLine();
                if (strings[i].Length >= 6) 
                {
                    splnene_slova.Add(strings[i]);
                }
            }
            Console.WriteLine("slova která mají 6 a víc znaků jsou:");
            for (int i = 0; i < splnene_slova.Count; i++) 
            {
                Console.WriteLine(splnene_slova[i]);
            }
        }
    }
}