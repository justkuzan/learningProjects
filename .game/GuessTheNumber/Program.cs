using System;

namespace GuessTheNumber
{
    class Program
    {
        
        private static int number;
        private static int lower;
        private static int higher;
        private const int MAX_ATTEMPTS = 5;
        private static int userInput;

        public static void Main()
        { 
            PlayGame();
        }

        public static void PlayGame()
        {
            Random rand = new Random();
            number = rand.Next(0, 101);
            
            do
            {
                lower = Math.Max(0, rand.Next(number - 10, number));
                higher = Math.Min(100, rand.Next(number + 1, number + 10));
            } while (higher - lower <= 5);
            
            System.Console.WriteLine($"We guessed a number between 0 and 100, it is greater than {lower}, but less than {higher}");
            System.Console.WriteLine($"What is this number? You have {MAX_ATTEMPTS} attempts to guess");
            
            GuessTheNumber(MAX_ATTEMPTS);
        }

        private static void GuessTheNumber(int triesCount)
        {
            System.Console.Write("Your Answer: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            if (triesCount <= 1)
            {
                System.Console.WriteLine("You lost, alas, but better luck next time. It was a number " + number);
                AskToPlayAgain();
                return;
            }
            
            if(userInput == number)
            {
                System.Console.WriteLine($"You are right. It was number {number}");
                System.Console.WriteLine($"You guessed in {MAX_ATTEMPTS - triesCount} attempts");
                AskToPlayAgain();
                return;
            }

            else
            {
                System.Console.WriteLine("Not correct, try again");
                System.Console.WriteLine($"You have {triesCount - 1} attempts left");
                System.Console.WriteLine("---------------------------------------");
                
                GuessTheNumber(triesCount - 1);
            }
        }

        private static void AskToPlayAgain()
        {
            System.Console.WriteLine("Do you want to play again? (y/n)");
            string? playAgain = Console.ReadLine();

            if (playAgain?.ToLower() == "y")
            {
                Console.Clear();
                PlayGame();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Thanks for playing!");
                Console.ReadKey();
            }
        }
    }
}