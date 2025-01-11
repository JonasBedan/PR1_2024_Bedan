
string[] nazvy = ["kule", "zelený", "červený", "žaludy"];
string[] pocty = ["7", "8", "9", "10", "spodek", "svršek", "král", "eso"];
string[] karty = new string[32] ;
int x = 0;

for (int i = 0; i < nazvy.Length; i++) 
{
    for (int j = 0; j < pocty.Length; j++) 
    {
       
        karty[x] = nazvy[i] + pocty[j];
        Console.WriteLine(karty[x]);
        x++;
            
                
    }    
}

foreach (string s in karty) 
{
    Console.WriteLine(s);
}

