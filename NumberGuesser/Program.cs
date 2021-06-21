using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {
                //const number
                //int correctNumber = 7;

                //create a new random object
                Random randomNumber = new Random();
                int correctNumber = randomNumber.Next(1, 10);


                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a actual number!");
                        Console.ResetColor();
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number, please try again!");
                        Console.ResetColor();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You are correct!!");
                Console.ResetColor();

                //ask to play again
                Console.WriteLine("Play again? [Y or N]");
                //get the answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appAuthor = "Alexander Kagan";

            //change text color to green
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Mighty {0} by {1}", appName, appAuthor);

            //reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("what is your name?");
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}!! let's play a game...", inputName);
        }
    }
}
