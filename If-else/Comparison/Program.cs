using System;
using System.Threading;

namespace AgeChecker
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nice. Now enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"You entered {firstNumber} and {secondNumber}");
            Console.WriteLine("Please wait...");
            Thread.Sleep(3000);

            if (firstNumber < secondNumber)
            {
                Console.WriteLine($"{firstNumber} is less than {secondNumber}");
            }
            else if (firstNumber > secondNumber)
            {
                Console.WriteLine($"{firstNumber} is greater than {secondNumber}");
            }
            else
            {
                Console.WriteLine("These numbers are equal");
            }
        }
    }
}