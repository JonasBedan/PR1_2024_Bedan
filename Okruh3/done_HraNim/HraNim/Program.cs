using System;

class MainClass
{
    public static void Main(string[] args)
    {
        /*level 1
        int pocet_zapalek = 21;
        int tah;
        

        do
        {
            
            Console.WriteLine("Na stole je " + pocet_zapalek + " zápalek. Kolik bere hráč 1?");
            Console.Write("hráč 1: ");
            int.TryParse(Console.ReadLine(), out tah);

            if ((tah > 3) || (tah < 1))
            {
                Console.WriteLine("To nelze. Musíš zvolit číslo 1-3.");
                continue;
            }

            pocet_zapalek -= tah;
            if (pocet_zapalek <= 0)
            {
                Console.WriteLine("Hráč 2 vítězí");
                break;
            }

            
            do
            {
                //Nechal jsem si s touto smyčkou poradit, protože jsem nemohl přijít na to, jak program donutit, aby se vracel k hráči dvě.
                //naknoec to je primitivní
                Console.WriteLine("Na stole je " + pocet_zapalek + " zápalek. Kolik bere hráč 2?");
                Console.Write("hráč 2: ");
                int.TryParse(Console.ReadLine(), out tah);

                if ((tah > 3) || (tah < 1))
                {
                    Console.WriteLine("To nelze. Musíš zvolit číslo 1-3.");
                    continue;
                }

                break;
            } while (true);

            pocet_zapalek -= tah;
            if (pocet_zapalek <= 0)
            {
                Console.WriteLine("Hráč 1 vítězí");
                break;
            }

            

        } while (pocet_zapalek > 0);
        */


        /* level2
        int pocet_zapalek = 21;
        int tah;
        Random random = new Random();
        
        do
        {

            Console.WriteLine("Na stole je " + pocet_zapalek + " zápalek. Kolik bere hráč 1?");
            Console.Write("hráč 1: ");
            int.TryParse(Console.ReadLine(), out tah);

            if ((tah > 3) || (tah < 1))
            {
                Console.WriteLine("To nelze. Musíš zvolit číslo 1-3.");
                continue;
            }

            pocet_zapalek -= tah;
            if (pocet_zapalek <= 0)
            {
                Console.WriteLine("počítač vítězí");
                break;
            }

            int generator = random.Next(1, 4);
            pocet_zapalek -= generator;
            Console.WriteLine("Já beru " + generator + " zápalek");
            if (pocet_zapalek <= 0)
            {
                Console.WriteLine("Hráč 1 vítězí");
                break;
            }

        } while (pocet_zapalek > 0);
        */
    }
}