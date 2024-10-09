using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace GuessTheNumber
{
    static class Config
    {
        public const int MAX_ATTEMPTS = 5;
    }
    
    static class View
    {
        public static void ShowIntro(int lower, int higher)
        {
            Console.Clear();
            System.Console.WriteLine($"We guessed a number between 0 and 100, it is greater than {lower}, but less than {higher}");
            System.Console.WriteLine($"What is this number? You have {Config.MAX_ATTEMPTS} attempts to guess");            
        }
        
        public static void Lose(int number)
        {
            System.Console.WriteLine("You lost, alas, but better luck next time. It was a number " + number);
        }

        public static void Win(int number, int triesCount)
        {
            System.Console.WriteLine($"You are right. It was number {number}");
            System.Console.WriteLine($"You guessed in {Config.MAX_ATTEMPTS - triesCount} attempts");
        }

        public static void AnotherAttempt(int triesCount)
        {
            System.Console.WriteLine("Not correct, try again");
            System.Console.WriteLine($"You have {triesCount - 1} attempts left");
            System.Console.WriteLine("---------------------------------------");
        }

        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();            
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
    }

    static class GameModel // попробовал убрать логику игры в отдельный обслуживающий класс
    {
        public static int GenerateNumber()
        {
            Random rand = new Random();
            return rand.Next(0, 101); //я честно не понимаю как работает return. Не только здесь, но и в целом
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
    

    class GameController
    {
        private static int number;
        private static int lower;
        private static int higher;
        private static int userInput;

        public static void PlayGame()
        {
            number = GameModel.GenerateNumber(); //попросил тут чат гпт помочь, чтобы он помог мне не запутаться, что кого вызывает
            (lower, higher) = GameModel.GenerateBounds(number); //и тут тоже

            View.ShowIntro(lower, higher); 
            GuessTheNumber(Config.MAX_ATTEMPTS);
        }

        private static void GuessTheNumber(int triesCount) //вот это как будто бы все можно вынести отдельно и вызывать только 1 процесс
        {
            System.Console.Write("Your Answer: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            if (triesCount <= 1)
            {
                View.Lose(number);
                AskToPlayAgain();
                return;
            }
            
            if(userInput == number)
            {
                View.Win(number, triesCount);
                AskToPlayAgain();
                return;
            }

            else
            {
                View.AnotherAttempt(triesCount);   
                GuessTheNumber(triesCount - 1);
            }
        }

        private static void AskToPlayAgain()
        {
            string choice = View.AskToPlayAgain();

            if (choice == "continue")
            {
                PlayGame();
            }
            else
            {
                View.Exit();
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