using System;
using System.Security.Cryptography.X509Certificates;

namespace Return;

/* Я изначально хотел вынести оценки отдельно, чтобы потом их было легче менеджерить, но передумал.
Возможно их стоило вынести как диапазон и проверять введенное пользователем число с диапазонами */

// class Grades  
// {
//  int A = 100;
//  int B = 90;
//  int C = 80;
//  int D = 70;
//  int F = 60;
// }

class View
{
    public static void Greetings()
    {
        System.Console.WriteLine("Enter the student's grade");
    }
    public static void Response(int userNumber, string value)
    {   
        if (userNumber >= 0 && userNumber <= 100)
        {
            System.Console.WriteLine($"A score of {userNumber} is equal to a score of {value}");
        }
        else
        {
            System.Console.WriteLine( $"It's bullshit, he couldn't get {userNumber} points.");
        }
    }
}

class Program
{
    public static void Main()
    {   
        View.Greetings();   
        
        int userNumber = Convert.ToInt32(Console.ReadLine());
        string value = GradeCalculator(userNumber);
        
        View.Response(userNumber, value);
    }

    public static string GradeCalculator(int score)
    {
        if(score >= 90 && score <= 100 )
        {
            return "A";
        }
        else if(score >= 80 && score <= 89)
        {
            return "B";
        }
        else if(score >= 70 && score <= 79)
        {
            return "C";
        }
        else if(score > 60 && score >= 0)
        {
            return "D";
        }
         else if (score >= 60 && score <= 69)
        {
            return "D";
        }
        else if (score >= 0 && score < 60)
        {
            return "F";
        }
        else
        {
            return "Invalid score";
        }
    }
}