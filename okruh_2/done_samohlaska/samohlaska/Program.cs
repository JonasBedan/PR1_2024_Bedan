using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Console.Write("Stiskni klávesu: ");
        char znak = Console.ReadKey().KeyChar;
        Console.WriteLine();
        

        // Sem přijde váš kód
        string souhlaska = (znak) switch
        {
            //nevím jestli mám doplnit i diakritiku
            'a'or'e'or'i'or'o'or'u'or'y'or 'A' or 'E' or 'I' or 'O' or 'U' or 'Y' => "samohláska",
            'b'or'c'or'd'or'f'or'g'or'h'or'j'or'k'or'l'or'm'or'n'or'q'or'r'or's'or't'or'v'or'w'or'x'or'z'or 'B' or 'C' or 'D' or 'F' or 'G' or 'H' or 'J' or 'K' or 'L' or 'M' or 'N' or 'Q' or 'R' or 'S' or 'T' or 'V' or 'W' or 'X' or 'Z' => "souhláska",
            '_'=>"neplatný znak",

        };
        Console.WriteLine("znak který jsi napsal je "+souhlaska);

        // Konec vašeho kódu

    }
}