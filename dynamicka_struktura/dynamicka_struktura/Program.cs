namespace dynamicka_struktura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> kosik = new Dictionary<string, int>();//vytvoreni slovniku

            while (true) 
            {
                
                int volba = menu();
                switch (volba)
                {
                    case 1:
                        Console.WriteLine("Jaký produkt chceš přidat?");//načtení key
                        string produkt = Console.ReadLine();
                        Console.WriteLine("produkt byl přidán!!");
                        int cena;
                        //načtení value
                        do
                        {
                            Console.WriteLine($"Kolik stojí {produkt}?");
                        } while (!int.TryParse(Console.ReadLine(), out cena) || cena < 1);
                        Console.WriteLine("cena byla načtena!!");
                        kosik.Add(produkt, cena);
                        break;
                    case 2:
                        foreach (var i in kosik)//vypsání produktů 
                        {
                            Console.WriteLine("Produkt = {0}", i.Key);   
                        }
                        break;
                    case 3:
                        int celk_cena = 0;
                        foreach(var i in kosik)//sečtení ceny 
                        {
                            celk_cena += i.Value;
                        }
                        Console.WriteLine("nákup tě bude stát: "+celk_cena);
                        break;
                    default:
                        break;
                }
                if (volba == 4) 
                {
                    break;
                }
            }
            

        }

       public static int menu() 
       {
            int volba;
            Console.WriteLine("1. Přidat produkt");
            Console.WriteLine("2. Vypsat košík");
            Console.WriteLine("3. Spočítat cenu celkem");
            Console.WriteLine("4. Konec");
            do { Console.WriteLine("Co si zvolíš? "); }while(!int.TryParse(Console.ReadLine(), out volba) || volba < 1 || volba > 4 );
            return volba;
       }
    }
}
