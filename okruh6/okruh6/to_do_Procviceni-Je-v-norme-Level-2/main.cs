using System;

class MainClass {
    //tuto metodu neměňte
    public static void Main (string[] args) {
        Console.WriteLine (JeVNorme(52.1, 50, 10)); //true
        Console.WriteLine (JeVNorme(55.1, 50, 10)); //false
        Console.WriteLine (JeVNorme(128.3, 130, 1.5)); //true
        Console.WriteLine (JeVNorme(128, 130, 1.5)); //false
    }

    //zde pište váš kód
}