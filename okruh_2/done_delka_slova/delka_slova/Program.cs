using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Napiš mi solovo1: ");
        string slovo1 = Console.ReadLine();

        Console.Write("Napiš mi solovo2: ");
        string slovo2 = Console.ReadLine();

        if (slovo1.Length < slovo2.Length)
        {
            Console.WriteLine("slovo " + slovo2 + " je delší");
        }
        else if (slovo1.Length > slovo2.Length)
        {
            Console.WriteLine("slovo " + slovo1 + " je delší");
        }
        else { Console.WriteLine("slova jsou stejně dlouhá"); }
    }
}