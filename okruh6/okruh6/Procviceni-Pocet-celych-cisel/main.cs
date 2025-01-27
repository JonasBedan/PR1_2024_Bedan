using System;

class MainClass {
    //tuto metodu neměňte
    public static void Main (string[] args) {
        double[] cisla = {1.3, 1.7, 2, 3.1, 0.1, -1}; 
        //obsahuje 2 celá čísla, 2 a -1

        Console.WriteLine(
            "Pole  [{0}] obsahuje {1} celých čísel", 
            string.Join("; ", cisla), 
            PocetCelych(cisla)
        );
    }

    //zde deklarujte vaši metodu
}