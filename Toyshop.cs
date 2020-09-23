using System;

namespace Toyshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int bearCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());
            int totalCount = puzzleCount + dollCount + bearCount + minionCount + truckCount;
            double totaltoyPrice = puzzleCount * 2.6 + dollCount * 3.0 + bearCount * 4.1 + minionCount * 8.2 + truckCount * 2.0;
            
            if (totalCount>=50)
            {
                totaltoyPrice = totaltoyPrice * 0.75;
            }
            totaltoyPrice = totaltoyPrice * 0.9;

            if (totaltoyPrice >= holidayPrice)
            {
                double differencePositive = totaltoyPrice - holidayPrice;
                Console.WriteLine($"Yes! {differencePositive:f2} lv left.");
            }
            else
            {
                double differenceNegative = holidayPrice - totaltoyPrice;
                Console.WriteLine($"Not enough money! {differenceNegative:f2} lv needed.");

            }
        }
    }
}
