using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceStudentu
{
    public class hodnoceni
    {
        public string Oznaceni { get; set; }
        public int Vaha { get; set; }
        public DateTime Datum { get; set; }

        public hodnoceni(string oznaceni, int vaha, DateTime datum)
        {
            Oznaceni = oznaceni;
            Vaha = vaha;
            Datum = datum;
        }
    }
}
