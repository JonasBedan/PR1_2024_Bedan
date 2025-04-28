using System.ComponentModel.Design;

namespace veterina_done
{
    internal class Program
    {
        static List<Klient> klienti = new List<Klient>();
        static List<Veterinar> veterinari = new List<Veterinar>();
        static LinkedList<Rezervace> rezervaces = new LinkedList<Rezervace>();
        static void Main(string[] args)
        {
            
            List<Rezervace> terminy = new List<Rezervace>();
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Nový termín");
                Console.WriteLine("2 - Nový klient");
                Console.WriteLine("3 - Nový veterinář");
                Console.WriteLine("4 - Navštěva");
                Console.WriteLine("5 - Ukončit program");
                Console.Write("Vyberte možnost: ");

                string volba = Console.ReadLine();

                switch (volba)
                {
                    case "1":
                        Klient vybrany_klient = null;
                        while (vybrany_klient == null)
                        {
                            Console.Write("\nJméno klienta:");
                            string klientJmeno = Console.ReadLine();

                            vybrany_klient = klienti.FirstOrDefault(k => k.jmeno == klientJmeno);
                            if (vybrany_klient == null)
                            {
                                Console.WriteLine("Klient nebyl nalezen. Zkuz znovu.");
                            }
                        }

                        Veterinar vybrany_veterinar = null;
                        while (vybrany_veterinar == null) 
                        {
                            Console.Write("\nJméno veterináře:");
                            string veterinarJmeno = Console.ReadLine();

                            vybrany_veterinar = veterinari.FirstOrDefault(k => k.jmeno == veterinarJmeno);
                            if (vybrany_veterinar == null)
                            {
                                Console.WriteLine("Veterinar nebyl nalezen. Zkuz znovu.");
                            }
                        }

                        Console.WriteLine("\ndůvod návštěvy:");
                        string duvodNavstevy = Console.ReadLine();

                        bool navstiveno = false;

                        if(vybrany_klient.zvirata.Count == 1) 
                        {
                            Zvire zvire = vybrany_klient.zvirata[0];
                            Rezervace rezervace = new Rezervace(vybrany_klient,vybrany_veterinar,duvodNavstevy,navstiveno,zvire);
                            rezervaces.AddFirst(rezervace);

                        }
                        else 
                        {
                            Rezervace rezervace = new Rezervace(vybrany_klient, vybrany_veterinar, duvodNavstevy, navstiveno, vybrany_klient.zvirata);
                            rezervaces.AddFirst(rezervace);
                        }
                        break;
                    case "2":
                        Console.Write("\njméno klienta: ");
                        string jmeno = Console.ReadLine();
                        Console.Write("\nadresa klienta: ");
                        string adresa = Console.ReadLine();
                        Console.WriteLine("\ntelefon na klienta: ");
                        string telefon = Console.ReadLine();

                        Console.Write("\nmá klient více zvířat(ano/ne): ");
                        string počet = Console.ReadLine();

                        if (počet == "ne")
                        {
                            Console.WriteLine("\njméno klientova zvířete: ");
                            string jmenoZ = Console.ReadLine();
                            Console.WriteLine("\ndruh zvířete: ");
                            string druh = Console.ReadLine();
                            int vek;
                            do { Console.Write("\nvěk zvířete: "); } while (!int.TryParse(Console.ReadLine(), out vek) || vek < 0);
                            Zvire z = new Zvire(jmenoZ, druh, vek);
                            Klient k = new Klient (jmeno,adresa,telefon,z);
                            klienti.Add(k);
                        }
                        else if (počet == "ano") 
                        {
                            List<Zvire> zvirata = new List<Zvire>();
                            int kusy;
                            do
                            {
                                Console.Write("\nkolik má klient zvířat: ");
                            }while (!int.TryParse(Console.ReadLine(), out kusy) || kusy < 0);

                            for (int i = 0; i < kusy; i++) 
                            {
                                Console.WriteLine("\njméno klientova zvířete: ");
                                string jmenoZ = Console.ReadLine();
                                Console.WriteLine("\ndruh zvířete: ");
                                string druh = Console.ReadLine();
                                int vek;
                                do { Console.Write("\nvěk zvířete: "); } while (!int.TryParse(Console.ReadLine(), out vek) || vek < 0);
                                zvirata.Add(new Zvire(jmenoZ, druh, vek));
                                Klient k = new Klient (jmeno,adresa,telefon, zvirata);
                                klienti.Add(k);

                            }
                            
                            
                        }
                        else 
                        {
                            Console.WriteLine("nezadal si ani ano ani ne");
                        }
                        break;
                    case "3":
                        Console.Write("\nJméno veterináře:");
                        string jmenoV = Console.ReadLine();
                        Console.Write($"\nSpecializace {jmenoV}:");
                        string specializace = Console.ReadLine();

                        Veterinar v = new Veterinar (jmenoV,specializace);
                        veterinari.Add(v);
                        break;
                    case "4":
                        if (rezervaces.Count == 0) 
                        {
                            Console.WriteLine("Neexistuje žádná rezervace.");
                        }
                        else
                        {
                            if (rezervaces.First.Value.navstiveno == false) 
                            {
                                rezervaces.First.Value.navstiveno = true;
                                Console.WriteLine(rezervaces.First+"hotovo");
                                Rezervace pom = rezervaces.First();
                                rezervaces.RemoveFirst();
                                rezervaces.AddLast(pom);
                            }
                            else 
                            {
                                Console.WriteLine("všchny rezervace jsou vyřízené :)");
                            }
                        }
                        break;
                    case "5":
                        Console.WriteLine("ukončuji...");
                        break;
                    default:
                        break;
                }
                if (volba == "5") break;
            }
        }
    }
}
