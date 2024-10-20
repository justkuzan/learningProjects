namespace CheckNumber
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number");
            var userNumber = Convert.ToInt32(Console.ReadLine());
            
            var result = userNumber > 0 ? "Positive" : 
                userNumber < 0 ? "Negative" : "Zero";
            
            Console.WriteLine($"Number {userNumber} is {result}");
        }
    }
}