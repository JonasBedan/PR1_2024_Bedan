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
        double odvesna1sqr = odvesna1*odvesna1;
        double odvesna2sqr = odvesna2*odvesna1;
        double prepona_sqr = odvesna1sqr + odvesna2sqr;
        double prepona = Math.Sqrt(prepona_sqr);
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
            double preponasqr = prepona * prepona;
            double odvesnasqr = odvesna * odvesna;
            double odvesna2 = Math.Sqrt(preponasqr - odvesnasqr);
            Console.WriteLine("druhá odvěsna je dlouhá " + odvesna2 + "cm");
        }
        // Konec prostoru pro kód
    }
}