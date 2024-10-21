namespace hadani_cisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //první vstupy
            Random random = new Random();
            Console.WriteLine("Vítej v hádání čísel.");
            Console.WriteLine("Jaký má být rozměr čísel ze kterých budeš hádat (dvě čísla bez mezer)?");
            int rozmer = int.Parse(Console.ReadLine());

            //výpočet rozměrů
            int rozmer1 = rozmer / 10;
            int rozmer2mezi = rozmer % 10;
            int rozmer2 = rozmer2mezi + 1;

            //vygenerovani cisla
            Console.WriteLine("");
            int cislo = random.Next(rozmer1, rozmer2);
            Console.WriteLine("číslo bylo vybráno, máš tři pokusy na uhodnutí");

            //konečné vstupy
            Console.Write("1. pokus: ");
            int pokus1 = int.Parse(Console.ReadLine());
            Console.Write("2. pokus: ");
            int pokus2 = int.Parse(Console.ReadLine());
            Console.Write("3. pokus: ");
            int pokus3 = int.Parse(Console.ReadLine());

            //validace vítězství
            Console.WriteLine("");
            if ((pokus1 == cislo) || (pokus2 == cislo) || (pokus3 == cislo))
            {
                Console.WriteLine("Uhodl jsi, číslo bylo "+cislo);
            }
            else 
            { 
                Console.WriteLine("Neuhodl jsi, číslo bylo "+cislo); 
            }
        }
    }
}
