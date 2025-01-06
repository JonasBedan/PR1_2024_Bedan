using System;

class MainClass
{
    public static void Main(string[] args)
    {
        double[] teploty = { 13.7, 14.2, 14.3, 14.8, 15.2, 16.0, 16.3, 17.1 };
        //sem přijde váš kód
        int hodiny = 5;
        int minuty = 30;

        Console.WriteLine(" čas | teplota ");
        for (int i = 0; i < teploty.Length; i++) 
        {            
            Console.WriteLine($"{hodiny}:{minuty:D2} | {teploty[i]} °C");
            minuty += 30;

            if (minuty == 60) 
            { 
                hodiny += 1; 
                minuty = 0; 
            }
        }

    }
}