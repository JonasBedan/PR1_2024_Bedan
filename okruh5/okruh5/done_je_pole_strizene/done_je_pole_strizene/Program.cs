namespace done_je_pole_strizene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zkuste jednu některou deklaraci zakomentovat a jinou odkomentovat
            // váš kód by měl dát pro všechny správnou odpověď

            double[] cisla = { -5, 4.3, 2.7, 6.41, 12 }; //není
            double[] cisla2 = { -5, 2.7, 4.3, 6.41, 12 }; //je
            double[] cisla3 = { -5, 2.7, 2.7, 4.3, 6.41, 12 }; //je

            //sem přijde váš kód
            double pomocna = double.MinValue;
            bool serazene = true;
            for (int i = 0; i < cisla2.Length; i++) 
            {
                if (cisla2[i] < pomocna) 
                {
                    Console.WriteLine("pole není seřazené");
                    serazene = false;
                }
                pomocna = cisla2[i];
                
            }
            if (serazene == true)
            {
                Console.WriteLine("pole je seřezené");
            }
        }
    }
}
