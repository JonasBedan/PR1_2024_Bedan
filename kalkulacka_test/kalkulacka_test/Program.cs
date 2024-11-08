namespace kalkulacka_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //přivítání
            Console.WriteLine("Vítej v kalkulačce s náhodnými čísly!");

            //režim zadávání
            Random generator = new Random();
            Console.WriteLine("Chceš zadat čísla ručně nebo použít náhodná čísla? (1 = ruční, 2 = náhodná) ");
            Console.Write("Tvá volba: ");
            int rozhodnuti = int.Parse(Console.ReadLine());

            // zadání čísel
            float prvni_cislo = 0;
            float druhe_cislo = 0;
            string operace;

            if (rozhodnuti == 1)
            {
                Console.Write("Zadej první číslo: ");
                prvni_cislo = int.Parse(Console.ReadLine());

                Console.Write("Zadej druhé číslo: ");
                druhe_cislo = int.Parse(Console.ReadLine());
            }
            else if (rozhodnuti == 2)
            {
                prvni_cislo = generator.Next(1, 101);
                Console.WriteLine("první číslo bude " + prvni_cislo);

                druhe_cislo = generator.Next(1, 101);
                Console.WriteLine("druhé číslo bude " + druhe_cislo);
            }
            else
            {
                Console.WriteLine("zadal jsi neplatnou hodnotu");
                druhe_cislo = 0;
                operace = "/";
            }

            //výběr operace
            Console.WriteLine("Vyber operaci: +, -, *, / ");
            Console.Write("Tvá volba: ");
            operace = Console.ReadLine();

            //výsleledek
            if ((druhe_cislo == 0) && (operace == "/"))
            {
                Console.WriteLine("nelze provést");
            }

            else
            {
                float vysledek = operace switch
                {
                    "*" => prvni_cislo * druhe_cislo,
                    "/" => prvni_cislo / druhe_cislo,
                    "+" => prvni_cislo + druhe_cislo,
                    "-" => prvni_cislo - druhe_cislo,
                };
                Console.WriteLine("Výseldek: " + prvni_cislo + operace + druhe_cislo + "=" + vysledek);
            }

            //opakování
            Console.Write("Chceš pokračovat? a/n: ");
            char pokracovat = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            if (pokracovat == 'a')
            {
                Main(args);
            }
        }
    }
}
