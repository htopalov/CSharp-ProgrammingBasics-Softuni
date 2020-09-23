using System;

namespace Balans
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "NoMoreMoney")
                {
                    Console.WriteLine($"Total: {sum:f2}");
                    break;
                }
                double increaseMoney = double.Parse(input);
                if(increaseMoney>0)
                {
                    sum += increaseMoney;
                    Console.WriteLine($"Increase: {increaseMoney:f2}");
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {sum:f2}");
                    break;
                }
            }
        }
    }
}
