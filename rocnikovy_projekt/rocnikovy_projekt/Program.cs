using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using BCrypt.Net;

namespace rocnikovy_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UserManager userManager = new UserManager();
            string loggedInUser = null;

            while (true) 
            {
                Console.WriteLine("Správce úkolů - hlavní menu");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1 - registrace");
                Console.WriteLine("2 - přihlášení");
                Console.WriteLine("0 - konec");
                Console.Write("\nZadej volbu:");

                string volba1 = Console.ReadLine();
                Console.WriteLine("---------------------------");

                switch (volba1) 
                {
                    case "1":
                        Console.Write("Zadej uživatelské jméno: ");
                        string regUser = Console.ReadLine();

                        Console.Write("Zadej heslo: ");
                        string regPass = Console.ReadLine();

                        // Vytvoření hashe
                        string hash = BCrypt.Net.BCrypt.HashPassword(regPass);

                        // Uložení uživatele
                        if (userManager.Register(regUser, hash))
                            Console.WriteLine("Registrace úspěšná!");
                        else
                            Console.WriteLine("Uživatel už existuje!");
                        break;



                    case "2":
                        while(true)
                        {
                            Console.Write("Zadej uživatelské jméno: ");
                            string loginUser = Console.ReadLine();

                            Console.Write("Zadej heslo: ");
                            string loginPass = Console.ReadLine();

                            // Získání uloženého hashe podle jména
                            string ulozenyHash = userManager.GetHashForUser(loginUser);

                            // Ověření hesla
                            if (ulozenyHash != null && BCrypt.Net.BCrypt.Verify(loginPass, ulozenyHash))
                            {
                                Console.WriteLine("Uživatel úspěšně přihlášen!");
                                loggedInUser = loginUser;

                                while (true) 
                                {
                                    Console.WriteLine($"\nMenu uživatele {loggedInUser}:");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("1 - přidat úkol");
                                    Console.WriteLine("2 - splnit úkol");
                                    Console.WriteLine("3 - vypsat úkoly");
                                    Console.WriteLine("4 - odebrat úkol");
                                    Console.WriteLine("0 - odhlásit se");
                                    Console.Write("\nZadej volbu:");

                                    string volba2 = Console.ReadLine();

                                    switch (volba2)
                                    {
                                        case "1":
                                            Console.Write("Jméno ůkolu:");
                                            string assingment = Console.ReadLine();

                                            userManager.AddAssingmentToUser(loggedInUser, assingment);
                                            break;
                                        case "2":
                                            List<Assingment> assingments = userManager.GetAssingmentOfUser(loggedInUser);
                                            Console.Write("Jméno ůkolu:");
                                            string assingmentToFinish = Console.ReadLine();

                                            userManager.CompleteAssingmentToUser(loggedInUser, assingmentToFinish);

                                            break;
                                        case "3":
                                            List<Assingment> ass = userManager.GetAssingmentOfUser(loggedInUser);

                                            foreach(Assingment a in ass)
                                                Console.WriteLine(a);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            break;
                                        case "4":
                                            Console.Write("Jméno ůkolu:");
                                            string assingment1 = Console.ReadLine();

                                            userManager.RemoveAssingmentToUser(loggedInUser, assingment1);
                                            break;
                                        case "0":
                                            Console.WriteLine("odhlašuji...");
                                            break;

                                    }
                                    if (volba2 == "0")break;

                                }

                            }

                            else 
                            {
                                Console.WriteLine("Neplatné přihlašovací údaje.");
                            }
                            
                        }
                        break;
                    case "0":
                        Console.WriteLine("ukončuji...");
                        break;
                }
                if (volba1 == "0") break;
            }
        }
    }
}
