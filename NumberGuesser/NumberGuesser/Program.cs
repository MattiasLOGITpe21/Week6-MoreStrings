using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0.";
            string appAuthor = "Mattias Stražev";

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a little game", userName);

            //int CorrectNumber = 7;
            Random random = new Random();
            int correctNumber = random.Next(1, 11);
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            while (guess != correctNumber) {
                string input1 = Console.ReadLine();
                if(!int.TryParse(input1 , out guess))
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Please enter an actual number");
                    Console.ResetColor();
                }
                guess = Int32.Parse(input1);

                if (guess != correctNumber) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong number, please try again");
                    Console.ResetColor();

                    continue;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("YOU ARE CORRECT!");
            Console.ResetColor();

            Console.WriteLine("Want to play again [Y or N]");

            string answer = Console.ReadLine().ToUpper();

           /* if (answer == "Y") 
            {
                continue;
            }
            else 
            {
                return;
            }*/

        }
    }
}
