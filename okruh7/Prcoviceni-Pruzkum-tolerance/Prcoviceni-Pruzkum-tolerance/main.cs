using System;

class MainClass {
    public static void Main (string[] args) 
    {
        string[] sousedi = {"Mekuřan", "Venušan", "Pozemšťan", "Marťan", "Jupiteřan", "Saturňan", "Uraňan", "Neptuňan"};
        string[] respondenti = {"Alois", "Bedřich", "Cyril", "Dušan", "Emil", "Filip", "Gustav"};

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

        string nej_soused;
        string nej_respondent;
        int schvaleni = int.MinValue;
        int pocet;

        for (int i = 0; i < vysledky.GetLength(1); i++) 
        {
            for (int j = 0; j < schvaleni.GetLength(0); i++) 
            {
                if (vysledky[i, j] == true) 
                {
                    pocet++;
                }
            }
            if (pocet > schvaleni) 
            {
                schvaleni = pocet;
                nej_soused = i
            }
        }
        Console.WriteLine()

    }
}