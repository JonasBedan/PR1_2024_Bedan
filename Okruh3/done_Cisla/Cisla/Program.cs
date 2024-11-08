using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int zadane;
        int nejvyssi = 0;
        int nejmensi = 99999999;
        int lichych = 0;
        int sudych = 0;
        

        do 
        {
            Console.Write("Zadej číslo (napsáním čísla 0 akci zrušíš):");
            int.TryParse(Console.ReadLine(), out zadane);


            if ((zadane % 2) == 0)
            {
                lichych = lichych + 1;
            }
            else 
            {
                sudych = sudych + 1;
            }

            if ((zadane < nejmensi)&&(zadane != 0)) 
            {
                nejmensi = zadane;
            }

            if (zadane > nejvyssi)
            {
                nejvyssi = zadane;
            }



          

            
        } while (zadane != 0);
        Console.WriteLine("nejvyssi zadane cislo je "+nejvyssi);
        Console.WriteLine("nejmensi zadane cislo je "+nejmensi);
        Console.WriteLine("sudych cisel jsi zadal "+sudych);
        Console.WriteLine("lichych cisel jsi zadal "+lichych);
    }
}