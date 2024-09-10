using System;

namespace firstTry {

    class Program {
        public static void Main()
        {
            System.Console.WriteLine("Enter your age: ");
            byte user_input = Convert.ToByte(System.Console.ReadLine());
            /*Тип byte потому что я точно знаю что число, которое нам нужно обработать меньше 255.
            Получается что нет смысла тратить память на int */

            if (user_input >= 18){
                System.Console.WriteLine("Great, now keep watching porn you little perv");
            }

            else {
                System.Console.WriteLine("Access denied. Calling your family in 5...4...3...2...1...");
        }

    }
}
}