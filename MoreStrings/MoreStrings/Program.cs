using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja ees- ja perekonnanime
            //programm tervitab kasutajat initsiaalidega

            Console.WriteLine("Sisestage eesnimi:");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Sisestage perekonnanimi:");
            string perekonnanimi = Console.ReadLine();

            Console.WriteLine($"Tere! {eesnimi [0]}. {perekonnanimi [0]}.");
        }
    }
}
