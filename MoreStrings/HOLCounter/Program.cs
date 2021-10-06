using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu h, o ja l on lauses "Hello, World!"

            string hellow = "Hello, World!".ToLower();
            int counterh = 0;
            int countero = 0;
            int counterl = 0;

            for (int i = 0; i < hellow.Length; i++)
            {
                if (hellow[i] == 'h')
                {
                    counterh++;
                }
                if (hellow[i] == 'o')
                {
                    countero++;
                }
                if (hellow[i] == 'l')
                {
                    counterl++;
                }
                
            }
            Console.WriteLine($"Lauses on {counterh} 'h' tähte, {countero} 'o' tähte ja {counterl} 'l' tähte.");
        }
    }
}
