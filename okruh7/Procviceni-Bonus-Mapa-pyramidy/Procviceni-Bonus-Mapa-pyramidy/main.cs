using System;

class MainClass {
    public static void Main (string[] args) {
        
        //VypisPole(Pyramida(3)); //až bude hotovo, odkomentujte
        //VypisPole(OtocenaPyramida(4));  //až bude hotovo, odkomentujte
    }

    public static void VypisPole(int[,] pole)
    {
        //do kódu této metody nezasahujte
        for (int y = 0; y < pole.GetLength(0); y++)
        {
            for (int x = 0; x < pole.GetLength(1); x++)
            {
                Console.Write(pole[y, x]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }      
}