using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Sem přijde váš kód
        Console.WriteLine("Kolik jsi z testu získla procent?");
        double procenta = double.Parse(Console.ReadLine());

        if ((procenta <= 100) && (procenta >= 83))
        {
            Console.WriteLine("podle procent kterých si dosáhl bys měl dostat 1");
        }
        else if ((procenta < 83) && (procenta >= 67))
        {
            Console.WriteLine("podle procent kterých si dosáhl bys měl dostat 2");
        }
        else if ((procenta < 67) && (procenta >= 50))
        {
            Console.WriteLine("podle procent kterých si dosáhl bys měl dostat 3");
        }
        else if ((procenta < 50) && (procenta >= 33))
        {
            Console.WriteLine("podle procent kterých si dosáhl bys měl dostat 4");
        }
        else if ((procenta < 33)&&(procenta ==0))
        {
            Console.WriteLine("podle procent kterých si dosáhl bys měl dostat 5");
        }
        else 
        {
            Console.WriteLine("nezadávej nic jiného než procenta od 0% do 100%");
        }

    }
}