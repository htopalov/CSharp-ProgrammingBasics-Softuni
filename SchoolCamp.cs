using System;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int stundetsCount = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double price = 0;
            string sport = null;
            if(season=="Winter")
            {
                if(groupType=="boys" || groupType=="girls")
                {
                    price = 9.60 * nights * stundetsCount;
                }
                else
                {
                    price = 10 * nights * stundetsCount;
                }
            }
            else if (season == "Spring")
            {
                if (groupType == "boys" || groupType == "girls")
                {
                    price = 7.20 * nights * stundetsCount;
                }
                else
                {
                    price = 9.50 * nights * stundetsCount;
                }
            }
            else if (season == "Summer")
            {
                if (groupType == "boys" || groupType == "girls")
                {
                    price = 15 * nights * stundetsCount;
                }
                else
                {
                    price = 20 * nights * stundetsCount;
                }
            }
            if(stundetsCount>=50)
            {
                price *= 0.5;
            }
            else if(stundetsCount>=20 && stundetsCount<50)
            {
                price *= 0.85;
            }
            else if(stundetsCount>=10 && stundetsCount<20)
            {
                price *= 0.95;
            }
            if(season=="Winter")
            {
                if(groupType=="girls")
                {
                    sport = "Gymnastics";
                }
                else if(groupType=="boys")
                {
                    sport = "Judo";
                }
                else
                {
                    sport = "Ski";
                }
            }
            else if (season == "Spring")
            {
                if (groupType == "girls")
                {
                    sport = "Athletics";
                }
                else if (groupType == "boys")
                {
                    sport = "Tennis";
                }
                else
                {
                    sport = "Cycling";
                }
            }
            else
            {
                if (groupType == "girls")
                {
                    sport = "Volleyball";
                }
                else if (groupType == "boys")
                {
                    sport = "Football";
                }
                else
                {
                    sport = "Swimming";
                }
            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
