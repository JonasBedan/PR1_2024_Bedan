using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Sem přijde váš kód
        Console.Write("napiš mi polohu bodu v grafu na ose x:");
        int osaX = int.Parse(Console.ReadLine());

        Console.Write("napiš mi polohu bodu v grafu na ose y:");
        int osaY = int.Parse(Console.ReadLine());

        if ((osaX > 0) && (osaY > 0)) { Console.WriteLine("bod se nachází v prvním kvadrantu"); }
        else if ((osaX < 0) && (osaY < 0)) { Console.WriteLine("bod se nachází ve třetím kvadrantu"); }
        else if ((osaX > 0) && (osaY < 0)) { Console.WriteLine("bod se nachází ve čtvrtém kvadrantu"); }
        else { Console.WriteLine("bod se nachází ve druhém kvadrantu"); }
        // Konec vašeho kódu
    }
}