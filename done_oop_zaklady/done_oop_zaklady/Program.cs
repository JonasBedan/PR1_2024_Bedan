namespace done_oop_zaklady
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine($"{student.getJmeno()}  {student.getVek()}  {student.getAdresa()}");
            Student student2 = new Student("Pepa", 5, "sluníčková 9");
            student2.setZnamky(1);
            student2.setZnamky(2);
            foreach(int znamka in student.getZnamky()) 
            {
                Console.WriteLine(znamka+" ");
            }
            Console.WriteLine($"{student2.getJmeno()}  {student2.getVek()}  {student2.getAdresa()}");
            Student student3 = new Student("Někdo", 8, "Někde");
            student3.predstav_se(student3 );

        }
    }
}
