using System;

namespace Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalMoney = 0;
            while(true)
            {
                string input = Console.ReadLine();
                if(input == "End")
                {
                    break;
                }
                double budget = double.Parse(Console.ReadLine());
                while (true)
                {
                    double currentMoney = double.Parse(Console.ReadLine());
                    totalMoney += currentMoney;
                    if(totalMoney>=budget)
                    {
                        Console.WriteLine($"Going to {input}!");
                        totalMoney = 0;
                        break;
                    }
                }
            }
        }
    }
}
