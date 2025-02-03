using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            int fanSpeed = 0;
            bool isHighTemperature = false;

            bool hasNoCooling = fanSpeed <= 0;
            
            if (isHighTemperature || hasNoCooling){
                System.Console.WriteLine("Угроза повреждения процессора!");
            }
        }
    }
}
