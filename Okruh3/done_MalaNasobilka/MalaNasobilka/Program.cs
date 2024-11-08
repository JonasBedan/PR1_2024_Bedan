using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int zaklad;

        // zde začíná váš kód
        Console.Write("od jakého čísla chceš znát malou násobilku?");
        int.TryParse(Console.ReadLine(), out zaklad);
        int i=0;
        int vypocet;

        do {
            i++;
            vypocet = zaklad * i;
            Console.WriteLine(zaklad+"x"+i+" = "+ vypocet);
        } while (i != 10); 

    }
}