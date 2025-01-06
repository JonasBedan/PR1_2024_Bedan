using System.Threading.Channels;

namespace zarotuj_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //level 1 a level 2 zvládnu ale u levelu 3 jsem si nevěděl rady tak jsem použil chat gpt na vysvětlení, nemohu si ale připisovat jeho zásluhy
            int[] ints = { 7, 2, 8, 1, -2, 9, -10, 0, 1 };
            int prvni = ints[0];
           
           
            for (int i = 0; i < ints.Length-1; i++) 
            {
                
                ints[i] = ints[i+1];
                

            }
            
            foreach (int i in ints) 
            {
                Console.Write(i+", ");
            }
        }
    }
}
