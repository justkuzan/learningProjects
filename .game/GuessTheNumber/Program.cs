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

                System.Console.WriteLine($"Мы загадали число от 0 до 100, оно больше чем {lower}, но меньше чем {higher}");
                System.Console.WriteLine($"Что это за число? У вас {triesCount} попыток отгадать");

                while (triesCount -- > 0)
                {
                    System.Console.Write("Ваш ответ: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                    if(userInput == number)
                    {
                        System.Console.WriteLine($"Вы правы. Это было число {number}");
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Не верно, попробуйте еще раз");
                        System.Console.WriteLine($"У вас осталось {triesCount} попыток");
                        System.Console.WriteLine("---------------------------------------");
                    }
                }

                if (triesCount < 0)
                {
                    System.Console.WriteLine("Вы проиграли, увы, но повезет в следующий раз. Это было число " + number);
                }
                else
                {
                    System.Console.WriteLine($"Вы отгадали за {5 - triesCount} попытки");
                }

                System.Console.WriteLine("Хотите сыграть еще раз? (y/n)");
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