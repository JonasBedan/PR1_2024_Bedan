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

    }
}