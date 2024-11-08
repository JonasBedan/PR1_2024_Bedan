using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int hornihranice;
        int dolnihranice;
        int soucet = 0;
        bool ok = false;
        int i;

        do {
            Console.Write("zadej dolni hranici: ");
        }while(!int.TryParse(Console.ReadLine(), out dolnihranice));

        do
        {
            Console.Write("zadej horni hranici: ");
            int.TryParse(Console.ReadLine(), out hornihranice);
        } while (!ok==false||hornihranice<dolnihranice);

        i = dolnihranice;
        while (i <= hornihranice) 
        { 
            soucet = soucet + i;
            i++;
        }
        Console.WriteLine("součet všech čísel v rozpětí "+dolnihranice+" a "+hornihranice+" je "+soucet);

    }
}