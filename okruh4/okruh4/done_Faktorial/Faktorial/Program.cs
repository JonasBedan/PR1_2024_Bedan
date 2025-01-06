using System;

class MainClass
{

    public static void Main(string[] args)
    {
        int n = 0;
        do { 
            Console.Write("Z jakého čísla chceš spočítat faktoriál: ");
        
        } while(!int.TryParse(Console.ReadLine(), out n)||n==0);

        int faktorial = 1;
        for (int i = 0; i<n; i++) 
        {
            faktorial *= i+1;
        }

        Console.WriteLine($"{n}! = {faktorial}");
        //zde končí váš kód
        
    }
}