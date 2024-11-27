using System;

class MainClass
{

    public static void Main(string[] args)
    {
        int n, cislo = 1, predesle_cislo = 0,predesle_cislo2=1;
        Console.Write("Kolik Fibonacciho čísel chceš spočítat: ");
        int.TryParse(Console.ReadLine(), out n);

        for (int i = 0; i < n; i++)
        {
            cislo = predesle_cislo2 + predesle_cislo;
            predesle_cislo2 = predesle_cislo;
            predesle_cislo = cislo;

            Console.Write(cislo+" ");
            
            
            

        }
    }
}