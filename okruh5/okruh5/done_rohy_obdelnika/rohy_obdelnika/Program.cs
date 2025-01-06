namespace rohy_obdelnika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] levyhorni = {0,0};
            
            int[] rozmery = {0,0};

            int[] pravyhorni = { levyhorni[0] + rozmery[0], levyhorni[1] };
            int[] pravydolni = { pravyhorni[0], pravyhorni[1] - rozmery[1] };
            int[] levydolni = { levyhorni[0], levyhorni[1] - rozmery[1] };

            Console.WriteLine($" levy horni roh je na ose x na pozici {levyhorni[0]} a na ose y je na pozici {levyhorni[1]}");
            Console.WriteLine($" levy dolní roh je na ose x na pozici {levydolni[0]} a na ose y je na pozici {levydolni[1]}");
            Console.WriteLine($" pravy horni roh je na ose x na pozici {pravyhorni[0]} a na ose y je na pozici {pravyhorni[1]}");
            Console.WriteLine($" pravy dolni roh je na ose x na pozici {pravydolni[0]} a na ose y je na pozici {pravydolni[1]}");
            
        }
    }
}
