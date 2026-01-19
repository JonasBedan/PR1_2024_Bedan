using System.Collections.Generic;

namespace Serializace
{
    class Trida
    {
        public string Nazev { get; set; } = "";
        public List<Student> SeznamStudentu { get; set; }

        public Trida()
        {
            SeznamStudentu = new List<Student>();
        }
    }
}

