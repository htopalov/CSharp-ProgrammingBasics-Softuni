using System;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double tripPercentage = 0;
            string destination = string.Empty;
            string place = string.Empty;
            if(budget<=100)
            {
                destination = "Bulgaria";
                if(season =="summer")
                {
                    tripPercentage = budget * 0.3;
                    place = "Camp";
                }
                else
                {
                    tripPercentage = budget * 0.7;
                    place = "Hotel";
                }
            }
            else if(budget<=1000)
            {
                destination = "Balkans";
                if(season=="summer")
                {
                    tripPercentage = budget * 0.4;
                    place = "Camp";
                }
                else
                {
                    tripPercentage = budget * 0.8;
                    place = "Hotel";
                }
            }
            else if(budget>1000)
            {
                place = "Hotel";
                destination = "Europe";
                tripPercentage = budget * 0.9;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {tripPercentage:f2}");
        }
    }
}
