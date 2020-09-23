using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = null;
            double price = 0;
            string location = null;
                if(budget<=1000)
            {
                place = "Camp";
                if(season=="Summer")
                {
                    location = "Alaska";
                    price = budget * 0.65;
                }
                else
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }
            }
                if(budget>1000 && budget<=3000)
            {
                place = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.80;
                }
                else
                {
                    location = "Morocco";
                    price = budget * 0.60;
                }
            }
                if(budget>3000)
            {
                place = "Hotel";
                if(season=="Summer")
                {
                    location="Alaska";
                    price = budget * 0.90;
                }
                else
                {
                    location = "Morocco";
                    price = budget * 0.90;
                }
            }
            Console.WriteLine($"{location} - {place} - {price:f2}");

        }
    }
}
