namespace tolerance_done
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] sousedi = { "Mekuřan", "Venušan", "Pozemšťan", "Marťan", "Jupiteřan", "Saturňan", "Uraňan", "Neptuňan" };
            string[] respondenti = { "Alois", "Bedřich", "Cyril", "Dušan", "Emil", "Filip", "Gustav" };

            bool[,] vysledky =
            {
            {  true, false, false, false,  true,  true, true,  true },
            {  true,  true,  true,  true,  true, false, true,  true },
            {  true,  true, false,  true,  true,  true, true, false },
            { false,  true,  true,  true,  true, false, true,  true },
            {  true, false, false,  true, false, false, true, false },
            {  true, false, false,  true,  true, false, true, false },
            {  true, false, false,  true, false, false, true,  true },
            };

            int nej_soused = 0;
            int nej_respondent = 0;
            int schvaleni = int.MinValue;
            int pocet = 0;

            for (int i = 0; i < vysledky.GetLength(1); i++)
            {
                for (int j = 0; j < vysledky.GetLength(0); j++)
                {
                    if (vysledky[j, i] == true)
                    {
                        pocet++;
                    }
                }
                if (pocet > schvaleni)
                {
                    schvaleni = pocet;
                    nej_soused = i;
                    pocet = 0;
                }
            }
            Console.WriteLine($"nejtolerovanější soused je {sousedi[nej_soused]}");
            pocet = 0;
            schvaleni = int.MaxValue;
            for (int i = 0; i < vysledky.GetLength(0); i++)
            {
                for (int j = 0; j < vysledky.GetLength(1); j++)
                {
                    if (vysledky[i, j] == false)
                    {
                        pocet++;
                    }
                }
                if (pocet < schvaleni)
                {
                    schvaleni = pocet;
                    nej_respondent = i;
                    pocet = 0;
                }
            }
            Console.WriteLine($"nejtolerovanější soused je {respondenti[nej_respondent]}");

        }
    }
}
