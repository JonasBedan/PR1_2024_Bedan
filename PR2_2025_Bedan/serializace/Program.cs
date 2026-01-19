using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Serializace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Serializace a deserializace dat ===\n");

            Console.WriteLine("--- Úloha 1: XML Serializace ---");
            SerializujDoXML();
            Console.WriteLine();

            Console.WriteLine("--- Úloha 2: JSON Serializace ---");
            SerializujDoJSON();
            Console.WriteLine();

            Console.WriteLine("--- Úloha 3: Porovnání výstupů ---");
            PorovnejVystupy();
            Console.WriteLine();

            Console.WriteLine("=== Deserializace dat ===\n");
            
            Console.WriteLine("--- Načítání z XML souboru ---");
            NactiXML("trida.xml");
            Console.WriteLine();

            Console.WriteLine("--- Načítání z JSON souboru ---");
            NactiJSON("trida.json");
            Console.WriteLine();

            Console.WriteLine("\nProgram ukončen. Stiskněte libovolnou klávesu...");
            Console.ReadKey();
        }

        static Trida VytvorTestovaciTridu(string nazevTridy)
        {
            List<Student> studenti = new List<Student>();

            Student student1 = new Student();
            student1.Jmeno = "Jan";
            student1.Prijmeni = "Novák";
            student1.Znamky = new List<int> { 1, 2, 1, 2, 1 };
            studenti.Add(student1);

            Student student2 = new Student();
            student2.Jmeno = "Marie";
            student2.Prijmeni = "Svobodová";
            student2.Znamky = new List<int> { 2, 2, 3, 2, 1 };
            studenti.Add(student2);

            Student student3 = new Student();
            student3.Jmeno = "Petr";
            student3.Prijmeni = "Dvořák";
            student3.Znamky = new List<int> { 3, 3, 2, 3, 4 };
            studenti.Add(student3);

            Student student4 = new Student();
            student4.Jmeno = "Anna";
            student4.Prijmeni = "Černá";
            student4.Znamky = new List<int> { 1, 1, 1, 2, 1 };
            studenti.Add(student4);

            Student student5 = new Student();
            student5.Jmeno = "Tomáš";
            student5.Prijmeni = "Procházka";
            student5.Znamky = new List<int> { 2, 3, 4, 3, 2 };
            studenti.Add(student5);

            Trida trida = new Trida();
            trida.Nazev = nazevTridy;
            trida.SeznamStudentu = studenti;

            return trida;
        }

        static void SerializujDoXML()
        {
            Trida trida = VytvorTestovaciTridu("3.A");

            XmlSerializer serializer = new XmlSerializer(typeof(Trida));
            FileStream stream = new FileStream("trida.xml", FileMode.Create);
            serializer.Serialize(stream, trida);
            stream.Close();

            Console.WriteLine("Třída byla úspěšně serializována do souboru 'trida.xml'");

            Console.WriteLine("\nObsah XML souboru:");
            Console.WriteLine("----------------------------------------");
            string xmlContent = File.ReadAllText("trida.xml");
            Console.WriteLine(xmlContent);
            Console.WriteLine("----------------------------------------");
        }

        static void SerializujDoJSON()
        {
            Trida trida = VytvorTestovaciTridu("2.B");

            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize(trida, options);
            File.WriteAllText("trida.json", jsonString);

            Console.WriteLine("Třída byla úspěšně serializována do souboru 'trida.json'");

            Console.WriteLine("\nObsah JSON souboru:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(jsonString);
            Console.WriteLine("----------------------------------------");
        }

        static void PorovnejVystupy()
        {
            Console.WriteLine("Porovnání formátů XML a JSON:\n");

            Console.WriteLine("XML formát:");
            Console.WriteLine("+ Strukturovaný, hierarchický formát");
            Console.WriteLine("+ Čitelné pro člověka i stroje");
            Console.WriteLine("+ Podporuje atributy a metadata");
            Console.WriteLine("- Větší velikost souboru");
            Console.WriteLine("- Více verbózní syntaxe\n");

            Console.WriteLine("JSON formát:");
            Console.WriteLine("+ Kompaktnější než XML");
            Console.WriteLine("+ Snadno čitelný a parsovatelný");
            Console.WriteLine("+ Široce používaný v moderních aplikacích");
            Console.WriteLine("+ Menší velikost souboru");
            Console.WriteLine("- Méně strukturovaný než XML\n");

            Console.WriteLine("Oba formáty správně reflektují strukturu školních tříd:");
            Console.WriteLine("  - Název třídy");
            Console.WriteLine("  - Seznam studentů s jménem, příjmením a známkami");
            Console.WriteLine("  - Data jsou čitelně organizovaná a snadno pochopitelná");
        }

        static void NactiXML(string nazevSouboru)
        {
            if (!File.Exists(nazevSouboru))
            {
                Console.WriteLine("Soubor '" + nazevSouboru + "' nebyl nalezen.");
                Console.WriteLine("Nejdříve spusťte serializaci do XML (úloha 1).");
                return;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Trida));
            FileStream stream = new FileStream(nazevSouboru, FileMode.Open);
            Trida trida = (Trida)serializer.Deserialize(stream);
            stream.Close();

            ZobrazTridu(trida);
        }

        static void NactiJSON(string nazevSouboru)
        {
            if (!File.Exists(nazevSouboru))
            {
                Console.WriteLine("Soubor '" + nazevSouboru + "' nebyl nalezen.");
                Console.WriteLine("Nejdříve spusťte serializaci do JSON (úloha 2).");
                return;
            }

            string jsonString = File.ReadAllText(nazevSouboru);
            Trida trida = JsonSerializer.Deserialize<Trida>(jsonString);

            ZobrazTridu(trida);
        }

        static void ZobrazTridu(Trida trida)
        {
            Console.WriteLine("Název třídy: " + trida.Nazev);
            Console.WriteLine("Počet studentů: " + trida.SeznamStudentu.Count);
            Console.WriteLine();
            Console.WriteLine("Seznam studentů:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Jméno           Příjmení        Průměrná známka");
            Console.WriteLine("----------------------------------------");

            for (int i = 0; i < trida.SeznamStudentu.Count; i++)
            {
                Student student = trida.SeznamStudentu[i];
                double prumer = student.VypoctiPrumernouZnamku();
                Console.WriteLine(student.Jmeno.PadRight(15) + student.Prijmeni.PadRight(15) + prumer.ToString("F2"));
            }

            Console.WriteLine("----------------------------------------");
        }
    }
}

