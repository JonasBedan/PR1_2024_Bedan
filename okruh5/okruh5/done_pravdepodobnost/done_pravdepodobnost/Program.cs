namespace done_pravdepodobnost
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float[] pravdepodobnost = { 0, 0, 0, 0, 0, 0};
            Random rand = new Random();
            int odpoved;
            int kostka;
            do {
                Console.WriteLine("Kolikrát chceš hodit kostkou pro zjištění pravděpodbnosti: ");
            }while(!int.TryParse(Console.ReadLine(), out odpoved)&&(odpoved>0));

            for (int i = 0; i < odpoved ; i++) 
            {
                kostka = rand.Next(0, 6);

                switch (kostka)
                {
                    case 0: 
                        kostka = 1; 
                        pravdepodobnost[0]+=1;
                        break;
                    case 1:
                        kostka = 2;
                        pravdepodobnost[1] += 1;
                        break;
                    case 2:
                        kostka = 3;
                        pravdepodobnost[2] += 1;
                        break;
                    case 3:
                        kostka = 4;
                        pravdepodobnost[3] += 1;
                        break;
                    case 4:
                        kostka = 5;
                        pravdepodobnost[4] += 1;
                        break;
                    case 5:
                        kostka = 6;
                        pravdepodobnost[5] += 1;
                        break;
                }   
            }

            for (int i = 0; i < pravdepodobnost.Length; i++) 
            {
                pravdepodobnost[i] = pravdepodobnost[i] / odpoved;
                
                Console.WriteLine($"pravděpodobnost na to aby padla {i+1} je {pravdepodobnost[i]}");
                
            }
        }
    }
}
