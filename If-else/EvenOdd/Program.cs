namespace EvenOdd
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter the number: ");
            string? input = Console.ReadLine();

            //Logic for null value
            if (int.TryParse(input, out int userInput))
            {
                //Basic logic
                if (userInput % 2 == 0)
                    Console.WriteLine($"Number {userInput} is even");
                else
                    Console.WriteLine($"Number {userInput} is NOT even");
            }
            else
                Console.WriteLine("Invalid input. Please, enter a valid number.");
        }
    }
}