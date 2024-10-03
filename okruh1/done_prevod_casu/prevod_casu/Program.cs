namespace prevod_casu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kolik sekund uběhlo:");
            int sekundy = int.Parse(Console.ReadLine());
            int minuty_mezivypocet = sekundy / 60;
            int zbyle_sekundy = sekundy % 60;
            int hodiny = minuty_mezivypocet / 60;
            int minuty = minuty_mezivypocet % 60;
            Console.WriteLine(hodiny+"hodin, "+minuty + " minut a " + zbyle_sekundy + " sekund");
        }
    }
}
