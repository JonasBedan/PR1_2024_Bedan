using System;

class MainClass
{
    public static void Main(string[] args)
    {

        string text = "Toto je velice dlouhá věta, kdoby se ji obtěžoval číst.";
        string vysledek = "";

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != ' ') 
            {
                vysledek += text[i];
            }
        }
        Console.WriteLine(vysledek);
        


    }
}