using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int polomer = 10;

        //dál pokračujte vy
        int velikost = polomer * 2+1;

        for (int y = 0; y < velikost; y++) 
        {
            for (int x = 0; x < velikost; x++)
            {
                //přepočet souřadnic do středu
                double dx = x - polomer;
                double dy = y - polomer;

                //kontrola, zda bod leží blízko kružnice
                double vzdalenost = Math.Sqrt(dx * dx + dy * dy);
                if (Math.Abs(vzdalenost - polomer) < 0.5) 
                {
                    Console.Write("# ");
                }
                else
                {
                    Console.Write("  ");
                }
                
            }
            Console.WriteLine();
        }
    }
}