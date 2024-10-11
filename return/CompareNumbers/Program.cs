using System;

namespace Return;

class Program
{
    public static void Main()
    {   
        int a = 2;
        int b = 5;
        string value = CompareNumbers(a, b);
        System.Console.WriteLine(CompareNumbers(a, b));
    }

    public static string CompareNumbers(int a, int b)
    {
        if(a > b)
        {
            return "A is greater than B";
        }
        else if(a < b)
        {
            return "B is greater than A";
        }
        else
        {
            return "Numbers are equal";
        }
    }
}