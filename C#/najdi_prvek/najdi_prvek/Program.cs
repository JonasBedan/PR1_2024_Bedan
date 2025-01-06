using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] cisla = { -11, 0, 5, -12, 13, 24, 19, 13, -17 };
        int hodnota = 0;
        bool exist = true;
        
        //sem přijde váš kód
        do {
            Console.Write("Zadej hodnotu kterou chceš najít: ");
        }while (!int.TryParse(Console.ReadLine(), out hodnota));

        for (int i = 0; i < cisla.Length; i++) 
        {
            if (hodnota == cisla[i])
            {
                Console.WriteLine("Číslo které si zadal je na pozici " + i);
                exist = true;
                break;
                
            }

            else 
            {
                exist = false;
                continue;
             
            }
        }
        if (exist == false) 
        {
            Console.WriteLine("Tvoje číslo nebylo nalezeno.");
        }



    }
}