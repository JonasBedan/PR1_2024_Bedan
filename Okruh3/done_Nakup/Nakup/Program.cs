using System;

class MainClass
{
    public static void Main(string[] args)
    {
        double rohlik = 3.5;
        double houska = 5.5;
        double chleba = 10;
        int kusy = 0;
        double celk_Cena = 0;
        string vstup;
        int polozka = 0;

        do {
            Console.Write("chceš do nákupního seznamu přidat rohlík, housku nebo chleba:");
            vstup = Console.ReadLine();

            switch (vstup) {
                case "0"or"nic"or"Nic":
                    kusy = 10;
                    break;

                case "rohlik"or"rohlík"or"Rohlík"or"Rohlik":
                    celk_Cena = celk_Cena + rohlik;
                    kusy += 1;
                    polozka += 1;   
                    break;

                case "Chleba"or"chleba":
                    celk_Cena += chleba;
                    kusy += 1;
                    polozka += 1;
                    break;

                case "houska" or "Houska"or"housku"or"hosuku":
                    celk_Cena += houska;
                    kusy += 1;
                    polozka += 1;
                    break;

                default:
                    Console.WriteLine("zadal jsi neplatnou hodnotu");
                    break;
            };
        }while (kusy != 10) ;
        Console.WriteLine("tvůj nákup bude stát "+celk_Cena+"Kč");
        Console.WriteLine("na seznamu máš celkem "+polozka+" potravin");
    }
}