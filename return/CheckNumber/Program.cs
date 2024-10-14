using System;

namespace Return;

class View
{
    public static void Greetings()
    {
        System.Console.WriteLine("Enter the number");
    }
    public static void Response(int userNumber, string value)
    {           
        System.Console.WriteLine($"Number {userNumber} is {value}");
    }
}

class Program
{
    public static void Main()
    {
        View.Greetings();
        int userNumber = Convert.ToInt32(Console.ReadLine());
        string value = CheckNumber(userNumber);
        View.Response(userNumber, value);
    }

    public static string CheckNumber(int x)
    {
        if(x>0)
        {
            return "positive";
        }
        else if (x<0)
        {
            return "negative";
        }
        else
        {
            return "zero";
        }
    }
}