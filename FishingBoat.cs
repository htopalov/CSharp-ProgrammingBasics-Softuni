using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            string output = string.Empty;
            //check season
            if (season == "Spring")
            {
                totalPrice = 3000;
            }
            if(season== "Summer" || season == "Autumn")
            {
                totalPrice = 4200;
            }
            if(season== "Winter")
            {
                totalPrice = 2600;
            }
            if (fisherman <= 6)
            {
                totalPrice *= 0.9;
            }
            else if (fisherman >= 7 && fisherman <= 11)
            {
                totalPrice *= 0.85;
            }
            else if (fisherman >= 12)
            {
                totalPrice *= 0.75;
            }
            if (fisherman%2==0)
            {
                if (season == "Spring" || season == "Summer" || season == "Winter")
                {
                    totalPrice *= 0.95;
                }
            }
            if(budget>=totalPrice)
            {
                output = $"Yes! You have {Math.Abs(budget - totalPrice):f2} leva left.";
            }
            else
            {
                output = $"Not enough money! You need {totalPrice - budget:f2} leva.";
            }
            Console.WriteLine(output);
        }
    }
}
