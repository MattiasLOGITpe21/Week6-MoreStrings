using System;

namespace ACharCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt eesnime
            //programm küsib kasutajalt perekonnanime
            //programm kuvab, mitu "a" tähte nimedes kokku on

            Console.WriteLine("Sisestage eesnimi:");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Sisestage perekonnanimi:");
            string perekonnanimi = Console.ReadLine();

            string fullname = $"{eesnimi} {perekonnanimi}".ToLower();
            int counter = 0;

            for (int i = 0; i < fullname.Length; i++)
            {
                if (fullname[i] == 'a')
                {         
                  counter++;
                }
               
            }
            if (counter == 1)
            {
                Console.WriteLine($"Sinu nimes on {counter} 'a' täht");
            }
            else
            {
                Console.WriteLine($"Sinu nimes on {counter} 'a' tähte");
            }
        }

    }
}
