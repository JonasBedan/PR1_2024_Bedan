using System;

class MainClass
{
    public static void Main(string[] args)
    {



        // Sem přijde váš kód

        /** 
         * Level 1:
         * 
        string zbozi1 = "Vejce";
        double cena1 = 3.5;

        string zbozi2 = "Rohlík";
        double cena2 = 1.9;

        string zbozi3 = "Chleba";
        double cena3 = 25;

        Console.WriteLine("PC: Vejce (3,50 kč/kus): Kolik kusů chcete?");
        Console.Write("Uživatel: ");
        int pocet_vajec = int.Parse(Console.ReadLine());
        Console.WriteLine("PC: Rohlík (1,90 kč/kus): Kolik kusů chcete?");
        Console.Write("Uživatel: ");
        int pocet_rohlik = int.Parse(Console.ReadLine());
        Console.WriteLine("PC: Chleba (25 kč/kus): Kolik kusů chcete");
        Console.Write("Uživatel: ");
        int pocet_chleba = int.Parse(Console.ReadLine());

        double cena = (cena3 * pocet_chleba) + (cena2 * pocet_rohlik) + (cena1 * pocet_vajec);
        Console.WriteLine("PC: Celkoví nákup bude stát " + cena + "kč");**/

        //level2
        Console.WriteLine("jaké jsi vzal zbozi?");
        string zbozi1 = Console.ReadLine();
        Console.WriteLine("kolik korun stojí "+ zbozi1+"?");
        decimal cena1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("kolik kusů " + zbozi1+" jsi vzal?");
        int pocet1 = int.Parse(Console.ReadLine());

        Console.WriteLine("jaké jsi vzal zbozi?");
        string zbozi2 = Console.ReadLine();
        Console.WriteLine("kolik korun stojí " + zbozi2 + "?");
        decimal cena2 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("kolik kusů " + zbozi2 + " jsi vzal?");
        int pocet2 = int.Parse(Console.ReadLine());

        Console.WriteLine("jaké jsi vzal zbozi?");
        string zbozi3 = Console.ReadLine();
        Console.WriteLine("kolik korun stojí " + zbozi3 + "?");
        decimal cena3 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("kolik kusů " + zbozi3 + " jsi vzal?");
        int pocet3 = int.Parse(Console.ReadLine());

        decimal celk_cena = (cena1*pocet1)+(cena2*pocet2)+(cena3*pocet3);
        Console.WriteLine("cena tvého nákupu je " + celk_cena + "kč");









        // Konec prostoru pro kód
    }
}