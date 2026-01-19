namespace datove_struktury_studenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string> studenti = new List<string> ();
            while (true) {
                bool skoncit;
                Console.WriteLine("1 - pridej studenta");
                Console.WriteLine("2 - odeber studenta");
                Console.WriteLine("3 - vypis studenty");
                Console.WriteLine();
                Console.WriteLine("tovje volba: ");
                string volba = Console.ReadLine();

                switch (volba)
                {
                    case "0":
                        skoncit = true;
                        break;
                    case "1":
                        Console.WriteLine("Jak se student jemnuje?");
                        Console.WriteLine();
                        Console.Write("jmeno:");
                        string jmenoPridat = Console.ReadLine();
                        studenti.Add (jmenoPridat);
                        break;
                    case "2":
                        Console.WriteLine("Jak se student jemnuje?");
                        Console.WriteLine();
                        Console.Write("jmeno:");
                        string jmenoOdebrat = Console.ReadLine();
                        bool smazano = studenti.Remove(jmenoOdebrat); 

                        if (smazano)
                        {
                            Console.WriteLine($"Jméno {jmenoOdebrat} bylo odstraněno.");
                        }
                        else
                        {
                            Console.WriteLine($"Jméno {jmenoOdebrat} nebylo nalezeno.");
                        }
                        break;

                     case "3":
                        foreach (string i in studenti)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                }
            }
        }
    }
}
