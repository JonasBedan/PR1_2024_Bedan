﻿using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string text = "Aspoň trochu ovsa, Karlíku, tomu koni dej. Copak nevidíš, že mu Eva zapomněla nasypat a Zdeněk tu dnes není. Ani Čeněk nedělá, co by měl. Nevím proč vás Evelína nevyhnala. Všichni byste Evelíně měli poděkovat. Třeba Řehoř a Iva, taky se pořád někde potulují. Dejvice, Emauzy, Strašnice, Ejpovice, ale být doma, to ne. To bych toho po vás chtěl moc.";

        //sem přijde váš kód
        int delka_slova = 0;
        

        for (int i = 0; i < text.Length-1; i++) 
        {
            char c = text[i];

            if (c >= 'A' && c <= 'Z') 
            {
                do {
                    
                    Console.Write(c);
                    i++;
                    c = text[i];
                } while (c!= ' '&&c!=',');
                Console.WriteLine();

                
            }
        }

    }
}