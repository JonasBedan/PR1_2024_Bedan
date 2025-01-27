using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace uloha_v_hodine
{
    internal class Program
    {
        public static string[] historie = new string[10];//proměnná pro všechny metody
        public static int pozice = 0;// proměnná pro všechny metody
        static void Main(string[] args)
        {
             
            Console.WriteLine("Vítej v programu kalkulačka.");
            int volba_uzivatel;
            int[] hodnoty;
            int vysledek;
            do
            {
                volba_uzivatel = Menu();
                switch (volba_uzivatel) 
                {
                    case 1:
                        
                        hodnoty = nacteniHodnot(2);
                        vysledek = soucet(hodnoty[0], hodnoty[1]);
                        Console.WriteLine($"{hodnoty[0]} + {hodnoty[1]} = {vysledek}");
                        break;
                    case 2:
                        hodnoty = nacteniHodnot(2);
                        vysledek = rozdil(hodnoty[0], hodnoty[1]);
                        Console.WriteLine($"{hodnoty[0]} - {hodnoty[1]} = {vysledek}");
                        break;
                    case 3:
                        hodnoty = nacteniHodnot(2);
                        vysledek = soucin(hodnoty[0], hodnoty[1]);
                         Console.WriteLine($"{hodnoty[0]} x {hodnoty[1]} = {vysledek}");
                        break;
                    case 4:
                        hodnoty = nacteniHodnot(2);
                        double vysledek2 = podil(hodnoty[0], hodnoty[1]);
                        Console.WriteLine($"{hodnoty[0]} ÷ {hodnoty[1]} = {vysledek2}");
                        break;
                    case 5:
                        hodnoty = nacteniHodnot(1);
                        long vysledek3 = faktorial(hodnoty[0]);
                        Console.WriteLine($"{hodnoty[0]}! = {vysledek3}");
                        break;
                    case 6:
                        hodnoty = nacteniHodnot(2);
                        long vysledek4 = mocnina(hodnoty[0], hodnoty[1]);
                        Console.WriteLine($"{hodnoty[0]} na {hodnoty[1]} = {vysledek4}");
                        break;
                    case 7:
                        vypisHistorii();
                        break;


                }
            } while (volba_uzivatel!=8);
            Console.WriteLine("Děkujeme za pouzití kalkulačky.");
        }
        //nacteni hodnot
        public static int[] nacteniHodnot(int pocetHodnot)
        {
            int[] hodnoty = new int[pocetHodnot];
            for (int i = 0; i < hodnoty.Length; i++) 
            {
                do
                {
                    Console.Write($"Zadej hodnotu {i + 1}. hdonotu: ");
                } while (!int.TryParse(Console.ReadLine(), out hodnoty[i]));
            }
            return hodnoty;
        }
        //rozhodnuti operace
        public static int Menu() 
        {
            
            int volba;
            do
            {
                Console.WriteLine("1: Soucet");
                Console.WriteLine("2: Rozdil");
                Console.WriteLine("3: Soucin");
                Console.WriteLine("4: Podil");
                Console.WriteLine("5: Faktorial");
                Console.WriteLine("6: Mocnina");
                Console.WriteLine("7: Historie");
                Console.WriteLine("8: Konec");
            }while(!int.TryParse(Console.ReadLine(), out volba)||volba<1||volba>8);
            if (pozice < 10) 
            {
                switch (volba)
                {
                    case 1:
                        historie[pozice] = "soucet";
                        break;
                    case 2:
                        historie[pozice] = "rozdil";
                        break;
                    case 3:
                        historie[pozice] = "soucin";
                        break;
                    case 4:
                        historie[pozice] = "podil";
                        break;
                    case 5:
                        historie[pozice] = "mocnina";
                        break;
                    case 6:
                        historie[pozice] = "faktorial";
                        break;
                    case 7:
                        historie[pozice] = "historie";
                        break;
                }
                pozice++;
            }
            return volba;
            
           
        }

        //metody početních operací
        public static int soucet(int a, int b) 
        { 
            return a + b;
        }

        public static int rozdil(int a, int b)
        {
            return a - b;
        }

        public static int soucin(int a, int b)
        {
            return a * b;
        }
        public static double podil(double a, double b)
        {
            if (b == 0)
            {
                return 0;
            }
            else
            {
                return (double)a / b;
            }
        }
        public static long faktorial(int a) 
        {
            int vysledek = 1;
            for (int i = 1; i <= a; i++) 
            {
                vysledek *= i;
            }
            return vysledek;
        }

        public static long mocnina(int a, int mocnitel)
        {
            long vysledek = 1;
            for (int i = 0; i < mocnitel; i++) 
            {
                vysledek = vysledek * a;
            }


            return vysledek;
        }

        public static void vypisHistorii() 
        {
            for (int i = 0; i < historie.Length; i++)
            {
                if (historie[i] != "")
                    Console.WriteLine(historie[i]);
            }
        }
        
       

    }

}
