using System;
namespace GuessTheNumber
{
    class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                int number;
                int lower, higher;
                int triesCount = 5;
                int userInput;
                Random rand = new Random();

                number = rand.Next(0, 101);
                
                do
                {
                    lower = Math.Max(0, rand.Next(number - 10, number));
                    higher = Math.Min(100, rand.Next(number + 1, number + 10));
                } while (higher - lower <= 5);

                System.Console.WriteLine($"We guessed a number between 0 and 100, it is greater than {lower}, but less than {higher}");
                System.Console.WriteLine($"What is this number? You have {triesCount} attempts to guess");

                while (triesCount -- > 0)
                {
                    System.Console.Write("Your Answer: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                    if(userInput == number)
                    {
                        System.Console.WriteLine($"You are right. It was number {number}");
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Not correct, try again");
                        System.Console.WriteLine($"You have {triesCount} attempts left");
                        System.Console.WriteLine("---------------------------------------");
                    }
                }

                if (triesCount < 0)
                {
                    System.Console.WriteLine("You lost, alas, but better luck next time. It was a number " + number);
                }
                else
                {
                    System.Console.WriteLine($"You guessed in {5 - triesCount} attempts");
                }

                System.Console.WriteLine("Do you want to play again? (y/n)");
                string? playAgain = Console.ReadLine();
                if (playAgain?.ToLower() != "y")
                {
                    break;
                }
                Console.Clear();
            }

        }
    }
}