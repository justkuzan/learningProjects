using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static double firstUserNumber;
    static double secondUserNumber;
    static string action;

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Start();
    }

    static void IfElse()
    {
        RequestData();
        IfElseLogic();
        Restart();
    }

   static void Switch()
    {
        RequestData();
        SwitchLogic();
        Restart();
    }

    static void RequestData()
    {
        Console.Write("Первое число: ");
        firstUserNumber = double.Parse(Console.ReadLine());

        Console.Write("Действие (+, -, *, /): ");
        action = Console.ReadLine();

        Console.Write("Второе число: ");
        secondUserNumber = double.Parse(Console.ReadLine());
    }

    static void IfElseLogic()
    {
        if (action == "+") {
            Console.WriteLine($"Результат: {firstUserNumber + secondUserNumber}");
        }
        if (action == "-") {
            Console.WriteLine($"Результат: {firstUserNumber - secondUserNumber}");
        }
        if (action == "*") {
            Console.WriteLine($"Результат: {firstUserNumber * secondUserNumber}");
        }
        if (action == "/") {
            if (secondUserNumber == 0) {
                Console.WriteLine("Ошибка: деление на ноль!");
            }
            else {
                double result = (double)firstUserNumber / secondUserNumber;
                Console.WriteLine($"Результат: {result}");
            }
        }
        else {
            Console.WriteLine("Неизвестная операция.");
            }
    }

    static void SwitchLogic()
    {
        switch(action)
        {
            case "+":
                Console.WriteLine($"Результат: {firstUserNumber + secondUserNumber}");
                break;
            case "-":
                Console.WriteLine($"Результат: {firstUserNumber - secondUserNumber}");
                break;
            case "*":
                Console.WriteLine($"Результат: {firstUserNumber * secondUserNumber}");
                break;
            case "/":
                if (secondUserNumber == 0) {
                    Console.WriteLine("Ошибка: деление на ноль!");
                }
                else {
                    double result = (double)firstUserNumber / secondUserNumber;
                    Console.WriteLine($"Результат: {result}");
                }
            break;
            
            default:
                Console.WriteLine("Неизвестная операция.");
                break;
        }
    } 

    static void Restart()
    {
        Console.WriteLine("Нажмите Enter");
        ConsoleKeyInfo key = Console.ReadKey();
        
        if (key.Key == ConsoleKey.Enter) {
            Start();
        }
    }

    static void Start()
    {
        Console.WriteLine("Выберите 1 для IF-ELSE метода или 2 для SWITCH метода: ");
        ConsoleKeyInfo key = Console.ReadKey(true);
        
        if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1) {
            Console.WriteLine("Вы выбрали IF-ELSE метод\n"); 
            IfElse();
        }
        else if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2) {
            Console.WriteLine("Вы выбрали SWITCH метод\n"); 
            Switch();
        }

        else
        {
            Console.WriteLine($"Вы нажали: {key.Key}, попробуйте еще раз");
            Start();
        }
    }
}
