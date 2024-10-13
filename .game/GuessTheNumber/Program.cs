using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace GuessTheNumber
{
    static class Config
    {
        public const int MAX_ATTEMPTS = 5;
    }
    
    static class GameState //Model
    {
        public static int number;
        public static int lower;
        public static int higher;
        public static int triesCount;

        public static void InitGame()
        {
            triesCount = Config.MAX_ATTEMPTS;
            number = GenerateNumber();
            (lower, higher) = GenerateBounds(number);  
        }

        public static int GenerateNumber()
        {
            Random rand = new Random();
            return rand.Next(0, 101);
        }

        public static (int lower, int higher) GenerateBounds(int number) 
        {
            Random rand = new Random();
            int lower, higher;

            do
            {
                lower = Math.Max(0, rand.Next(number - 10, number));
                higher = Math.Min(100, rand.Next(number + 1, number + 10));
            } while (higher - lower <= 5);

            return (lower, higher);
        }
    }
    

    static class GameView //View
    {
        public static void Intro()
        {
            Console.Clear();
            System.Console.WriteLine($"We guessed a number between 0 and 100, it is greater than {GameState.lower}, but less than {GameState.higher}");
            System.Console.WriteLine($"This number is {GameState.number}"); //Check
            System.Console.WriteLine($"What is this number? You have {Config.MAX_ATTEMPTS} attempts to guess");            
        }
        
        public static void Lose()
        {
            System.Console.WriteLine("You lost, alas, but better luck next time. It was a number " + GameState.number);
        }

        public static void Win()
        {
            System.Console.WriteLine($"You are right. It was number {GameState.number}");
            System.Console.WriteLine($"You guessed in {Config.MAX_ATTEMPTS - GameState.triesCount + 1} attempts");
        }

        public static void AnotherAttempt()
        {
            System.Console.WriteLine("Not correct, try again");
            System.Console.WriteLine($"You have {GameState.triesCount - 1} attempts left");
            System.Console.WriteLine("---------------------------------------");
        }

        public static int AskNumber()
        {
            System.Console.Write("Your Answer: ");
            return Convert.ToInt32(Console.ReadLine());

        }
        
        public static string AskToPlayAgain()
        {
            System.Console.WriteLine("Do you want to play again? (y/n)");
            string? input = Console.ReadLine();
            if (input?.ToLower() == "y")
            {
                return "continue";
            }
            else
            {
                return "exit";
            }
        }

        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();            
        }
    }

    class GameController //Controller
    {
        public static void PlayGame()
        {   
            GameState.InitGame();
            GameView.Intro(); 
            GuessTheNumber();
        }

        private static void GuessTheNumber()
        {   
            //1.
            int triesCount = GameState.triesCount;
            int number = GameState.number;
            int userInput = GameView.AskNumber();
            
            //2.

            if(userInput == number)
            {
                GameView.Win();
                AskToPlayAgain();
                return;
            }

            if (triesCount <= 1)
            {
                GameView.Lose();
                AskToPlayAgain();
                return;
            }

            else
            {
                GameView.AnotherAttempt();
                GameState.triesCount--;   
                GuessTheNumber();
            }
        }

        private static void AskToPlayAgain()
        {
            string choice = GameView.AskToPlayAgain();

            if (choice == "continue")
            {
                PlayGame();
            }
            else
            {
                GameView.Exit();
            }
        }
    }
    
    class Program
    {
        public static void Main()
        { 
            GameController.PlayGame();
        }
    }
}