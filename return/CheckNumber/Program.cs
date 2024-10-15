using System;

namespace Return;

class View
{
    public static void Greetings()
    {
        System.Console.WriteLine("Enter the number");
    }
    public static void Response(int userNumber, string numberType)
    {           
        System.Console.WriteLine($"Number {userNumber} is {numberType}");
    }
}

class Program
{
    public static void Main()
    {
        View.Greetings();
        int userNumber = Convert.ToInt32(Console.ReadLine());
        // string numberType = CheckNumber(userNumber);
        
        View.Response(userNumber, CheckNumber(userNumber));
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