using System;

namespace reportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double needSum = int.Parse(Console.ReadLine());
            double totalCash = 0;
            double totalCard = 0;
            double totalSum = 0;
            string command = null;
            int Counter = 0;
            int cashCounter = 0;
            int cardCounter = 0;
            while(totalSum<=needSum)
            {
                Counter++;
                command = Console.ReadLine();
                if (command == "End")
                {
                    if (needSum >= totalSum)
                    {
                        Console.WriteLine("Failed to collect required money for charity.");
                        break;
                    }
                }
                int money = int.Parse(command);
                if (Counter % 2 == 0)//paying with card
                {
                    if(money<10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        totalCard += money;
                        cardCounter++;
                    }
                }
                else //paying with cash
                {
                    if(money>100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        totalCash += money;
                        cashCounter++;
                    }
                }
                totalSum = totalCash + totalCard;
                if(totalSum>=needSum)
                {
                    Console.WriteLine($"Average CS: {totalCash/cashCounter:f2}");
                    Console.WriteLine($"Average CC: {totalCard/cardCounter:f2}");
                    break;
                }
            }
        }
    }
}
