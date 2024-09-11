using System;

namespace ageChecker {

    class Program
    {
        public const byte userAge = 18;

        public static void Main()
        {
            Console.WriteLine("Enter your age: ");
            int input = Convert.ToByte(Console.ReadLine());

            if(input < userAge)
             {
                Console.WriteLine("You are to young. Access denied");
             }
             
             else
             {
                Console.WriteLine("Your age is acceptable. You can enter");
             }
        }
    }
}