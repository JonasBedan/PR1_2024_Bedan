using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Console.Write("Stiskni klávesu: ");
        char znak = Console.ReadKey().KeyChar;
        Console.WriteLine();
        int kodZnak = (int)znak;
        // Sem přijde váš kód
        switch (kodZnak)
        {
            case >= 48 and <= 57:
                Console.WriteLine("Jedná se o číslo.");
                break;
            case >= 65 and <= 90:
                Console.WriteLine("Jedná se o velké písmeno.");
                break;
            case >= 97 and <= 122:
                Console.WriteLine("Jedná se o malé písmeno.");
                break;
            default:
                Console.WriteLine("Jedná se o speciální znak.");
                break;
                
        }
        // Konec vašeho kódu
    }
}



            