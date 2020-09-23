using System;

namespace TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int count = 0;
            double price=0;
            double total=0;
            while(true)
            {
               string name = Console.ReadLine();
                if (name == "Stop")
                {
                    Console.WriteLine($"You bought {count} products for {total:f2} leva.");
                    break;
                }
                price = double.Parse(Console.ReadLine());
                count++;
                if (count%3==0)
                {
                    price = price * 0.5;
                }
                if (price > budget)
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {Math.Abs(price - budget):f2} leva!");
                    break;
                }
                budget -= price;
                total += price;
            }   
        }
    }
}
