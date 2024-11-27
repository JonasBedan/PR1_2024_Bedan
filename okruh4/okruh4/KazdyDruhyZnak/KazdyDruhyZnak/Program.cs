using System;

class MainClass
{
    public static void Main(string[] args)
    {

        string text = "zadřeš on i co onsemnaí";

        //níže přijde váš kód
        string vysledek = "";
        string docasna_veta = "";
        

        for (int i = 0; i < text.Length; i++) 
        {
            char c = text[i];

            if (i % 2 == 0) 
            { 
                docasna_veta += c;

            }

            
        }
        Console.WriteLine(docasna_veta);


    }
}