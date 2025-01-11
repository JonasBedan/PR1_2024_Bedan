namespace done_druha_pismena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Statný valach ojnici zničil. Révou zhrdla žena ostrovana Claudia Pompeia. Ozvučení hnědé místnosti okamžitě zvýraznit! Běžný statkář to zvládne. Japonec Anihito rád označoval čárami. Asi sto pět kravských žaludků";
            string[] subs = text.Split(' ');
            string slovo;
            string veta = "";
            for (int i = 0; i < subs.Length; i++) 
            {
                slovo = subs[i];
                for (int j = 0; j < slovo.Length; j++) 
                {
                    char c = slovo[j];

                    if (j == 1)
                    {
                        veta += c;
                    }
                }
            }
            Console.WriteLine(veta);
        }
    }
}
