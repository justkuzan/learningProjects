﻿
namespace GuessTheNumber
{
    internal static class Config
    {
        internal const int MaxAttempts = 5;
        internal const int MinNumberLimit = 0;
        internal const int MaxNumberLimit = 100;
    }
    
    internal static class GameState //Model
    {
        public static int LeftBound;
        public static int RightBound;
        public static int LengthOfTheGuessedNumbers;
        public static int AttemptsLeft;
        public static int GuessedNumber;

        public static void InitGame()
        {
            AttemptsLeft = Config.MaxAttempts;
            GenerateGuessedNumber();
        }

        public static void GenerateGuessedNumber()
        {
            var randomGenerator = new Random();
            
            LengthOfTheGuessedNumbers = randomGenerator.Next(Config.MaxAttempts, Config.MaxAttempts * 2);
            LeftBound = randomGenerator.Next(Config.MinNumberLimit, (Config.MaxNumberLimit-LengthOfTheGuessedNumbers));
            RightBound = LeftBound + LengthOfTheGuessedNumbers;
            GuessedNumber = randomGenerator.Next(LeftBound, RightBound);
        }
    }

    internal static class GameView //View
    {
        public static void Intro()
        {
            Console.Clear();
            Console.WriteLine($"We guessed a number between {Config.MinNumberLimit} and {Config.MaxNumberLimit}," +
                              $"it is greater than {GameState.LeftBound}, but less than {GameState.RightBound}");
            Console.WriteLine($"This number is {GameState.GuessedNumber}"); //Check
            Console.WriteLine($"What is this number? You have {Config.MaxAttempts} attempts to guess");            
        }
        
        public static void Lose()
        {
            Console.WriteLine("You lost, alas, but better luck next time. It was a number " + GameState.GuessedNumber);
        }

        public static void Win()    
        {
            Console.WriteLine($"You are right. It was number {GameState.GuessedNumber}");
            Console.WriteLine($"You guessed in {Config.MaxAttempts - GameState.AttemptsLeft + 1} attempts");
        }

        public static void AnotherAttempt()
        {
            Console.WriteLine("Not correct, try again");
            Console.WriteLine($"You have {GameState.AttemptsLeft - 1} attempts left");
            Console.WriteLine("---------------------------------------");
        }

        public static int AskNumber()
        {
            Console.Write("Your Answer: ");
            return Convert.ToInt32(Console.ReadLine());

        }
        
        public static string AskToPlayAgain()
        {
            Console.WriteLine("Do you want to play again? (y/n)");
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
            var attemptsLeft = GameState.AttemptsLeft;
            var number = GameState.GuessedNumber;
            var userInput = GameView.AskNumber();
            
            //2.
            if(userInput == number)
            {
                GameView.Win();
                AskToPlayAgain();
                return;
            }

            if (attemptsLeft <= 1)
            {
                GameView.Lose();
                AskToPlayAgain();
                // return;
            }

            else
            {
                GameView.AnotherAttempt();
                GameState.AttemptsLeft--;   
                GuessTheNumber();
            }
        }

        private static void AskToPlayAgain()
        {
            var choice = GameView.AskToPlayAgain();

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