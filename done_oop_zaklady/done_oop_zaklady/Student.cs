using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace done_oop_zaklady
{
    class Student
    {
        private string jmeno;
        private int vek;
        private string adresa;
        private List<int> znamky;

        public void setZnamky(int znamka) 
        {
            this.znamky.Add(znamka);
        }
        public List<int> getZnamky()
        {
            return this.znamky;
        }

        public void setJmeno(string jmeno)
        {
            this.jmeno = jmeno;
        }

        public string getJmeno() 
        {
            return this.jmeno;
        }

        public void setVek(int vek)
        {
            this.vek = vek;
        }

        public int getVek()
        {
            return this.vek;
        }

        public void setAdresa(string adresa)
        {
            this.adresa = adresa;
        }

        public string getAdresa()
        {
            return this.adresa;
        }

        public Student()
        { 
            this.setVek(1);
            this.setJmeno("prazdne");
            this.setAdresa("prazdne");
            this.znamky = new List<int>();
        }

        public Student(string jmeno, int vek, string adresa)
        {
            this.setJmeno(jmeno);
            this.setVek(vek);
            this.setAdresa(adresa);
            
        }


        public void predstav_se(Student student) 
        {
            Console.WriteLine($"{student.getJmeno()}  {student.getVek()}  {student.getAdresa()}");
        }
    }
}
