using System;

class Program
{
    static int firstUserNumber;
    static int secondUserNumber;

    static int even;
    static int odd;

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        RequestData();

        if (secondUserNumber >=0)
        {
            PositiveNumbers();
        }
        else
        {
            NegativeNumbers();
        }
        
    }

    static void  RequestData()
    {
        Console.Write("Первое число: ");
        firstUserNumber = int.Parse(Console.ReadLine());

        Console.Write("Второе число: ");
        secondUserNumber = int.Parse(Console.ReadLine());
    }

    static void PositiveNumbers()
    {
        while (firstUserNumber <= secondUserNumber)
        {
            if (firstUserNumber % 2 == 0)
            {
                even += 1;
                firstUserNumber++;
            }
            else
            {
                odd += 1;
                firstUserNumber++;
            }
        }
        
        System.Console.WriteLine($"Четных: {even}\nНечетных: {odd}");
}

    static void NegativeNumbers()
    {
        while (firstUserNumber >= secondUserNumber)
        {
            if (secondUserNumber % 2 == 0)
            {
                even += 1;
                secondUserNumber++;
            }
            else
            {
                odd += 1;
                secondUserNumber++;
            }
        }
        
        System.Console.WriteLine($"Четных: {even}\nНечетных: {odd}");
    }
}
