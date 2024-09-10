using System;

namespace LeapYear
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter a year: ");
            string? input = Console.ReadLine();

             if (int.TryParse(input, out int year))
             {
                if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                    Console.WriteLine("This year is a LEAP year");
                else
                    Console.WriteLine("This year is NOT a leap year");
             }  
                
            else
                Console.WriteLine("Invalid input. Please, enter a valid number.");
        }
    }
}