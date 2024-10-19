namespace CompareNumbers
{
    class Program
    {
        private static class ProgramState
        {
            public static int Number1;
            public static int Number2;

            public static string Compare()
            {
                return  Number1 > Number2 ? "A is greater than B" :
                        Number1 < Number2 ? "B is greater than A" :
                        "Numbers are equal";
            }
        }
        private static void ProgramView()
        {
            Console.Write("Enter number 1: ");
            ProgramState.Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            ProgramState.Number2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(ProgramState.Compare());
        }
        public static void Main()
        {
            ProgramView();
        }
    }
}

