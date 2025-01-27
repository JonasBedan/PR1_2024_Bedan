
using System;

class MainClass {
    public static void Main (string[] args) {
        int[] cisla1 = {-5, -3, 1, 7, 50};
        int[] cisla2 = {-5, 1, -3, 7, 50};
        int[] cisla3 = {-5, -3, 1, 1, 7, 50};

        //je
        Console.WriteLine("První pole {0} rostoucí.", JeRostouci(cisla1) ? "je" : "není"); 
        
        //není
        Console.WriteLine("Druhé pole {0} rostoucí.", JeRostouci(cisla2) ? "je" : "není");
        
        //není
        Console.WriteLine("Třetí pole {0} rostoucí.", JeRostouci(cisla3) ? "je" : "není");   
    }

    //sem deklarujte metodu dle zadání

}