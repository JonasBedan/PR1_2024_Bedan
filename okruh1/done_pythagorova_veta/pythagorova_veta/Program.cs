using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Sem přijde váš kód
        /**
         * level1
         * 
        Console.Write("Jak dlouhá je první odvěsna (cm):");
        double odvesna1 = double.Parse(Console.ReadLine());
        Console.Write("Jak dlouhá je druhá odvěsna (cm):");
        double odvesna2 = double.Parse(Console.ReadLine());
        double prepona = Math.Sqrt(Math.Pow(odvesna1,2)+Math.Pow(odvesna2,2));
        Console.WriteLine("přepona je dlouhá "+prepona+"cm");**/

        Console.Write("jak dlouhá je přepona (cm):");
        double prepona = double.Parse(Console.ReadLine());
        Console.Write("jak dlouhá je odvěsna (cm):");
        double odvesna = double.Parse(Console.ReadLine());
        if (prepona < odvesna)
        {
            Console.WriteLine("přepona nemůže být menší než odvěsna");
        }
        else
        {
            double odvesna2 = Math.Sqrt(Math.Pow(prepona,2) - Math.Pow(odvesna,2));
            Console.WriteLine("druhá odvěsna je dlouhá " + odvesna2 + "cm");
        }
        // Konec prostoru pro kód
    }
}