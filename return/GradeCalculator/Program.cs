using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class View
{
    public static int AskNumber()
    {
        Console.Clear();
        System.Console.WriteLine("Enter the student's grade");
        int userNumber = Convert.ToInt32(Console.ReadLine());
        return userNumber;
    }

    public static void ResponseNegative(int userNumber)
    {   
        System.Console.WriteLine( $"It's bullshit, he couldn't get {userNumber} points.");
    }

    public static void ResponsePositive(int userNumber, string value)
    {
        System.Console.WriteLine($"A score of {userNumber} is equal to a score of {value}");
    }
}

class Program
{
    public static void Main()
    {
        int userNumber = View.AskNumber();
        
        if (userNumber < 0 || userNumber > 100)
        {
            View.ResponseNegative(userNumber);
        }
        else
        {
            string value = GradeCalculator(userNumber);
            View.ResponsePositive(userNumber, value);
        }
    }

    public static string GradeCalculator(int score)
    {
        if (score >= 90)
            return "A";
        if (score >= 80)
            return "B";
        if (score >= 70)
            return "C";
        if (score >= 60)
            return "D";
        return "F";
    }
}