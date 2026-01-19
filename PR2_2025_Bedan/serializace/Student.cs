using System;
using System.Collections.Generic;
using System.Linq;

namespace Serializace
{
    class Student
    {
        public string Jmeno { get; set; } = "";
        public string Prijmeni { get; set; } = "";
        public List<int> Znamky { get; set; }

        public Student()
        {
            Znamky = new List<int>();
        }

        public double VypoctiPrumernouZnamku()
        {
            if (Znamky == null || Znamky.Count == 0)
            {
                return 0.0;
            }

            double soucet = 0;
            for (int i = 0; i < Znamky.Count; i++)
            {
                soucet += Znamky[i];
            }
            return soucet / Znamky.Count;
        }
    }
}

