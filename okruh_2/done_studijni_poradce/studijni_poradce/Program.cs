using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Sem přijde váš kód
        Console.WriteLine("Kolik jsi měl procent z matematického testu?");
        int mat_procenta = int.Parse(Console.ReadLine());

        Console.WriteLine("Kolik jsi měl procent z jazykového test?");
        int jazyk_procenta = int.Parse(Console.ReadLine());

        if ((mat_procenta < 66) || (jazyk_procenta < 66)) { Console.WriteLine("Měl by si jít studovat řemeslo."); }
        else if (mat_procenta > jazyk_procenta) { Console.WriteLine("Měl by si jít na technický obor."); }
        else if (mat_procenta < jazyk_procenta) { Console.WriteLine("Měl by si jít na humanitární obor."); }
        else { Console.WriteLine("zadal jsi neplatnou hodnotu"); }

    }
}