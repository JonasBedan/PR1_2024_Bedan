using System;

class MainClass
{

    public static void Main(string[] args)
    {
        int n = 0;
        Console.Write("Z jakého čísla chceš spočítat faktoriál: ");
        //dál pokračujte vy, počet členů uložte do proměnné n, faktoriál do prměnné faktorial
        int.TryParse(Console.ReadLine(), out n);
        int faktorial = 1;
        for (int i = 1; i<=n; i++) 
        {
            faktorial *= i;
        }

        //zde končí váš kód
        Console.WriteLine($"{n}! = {faktorial}");
    }
}