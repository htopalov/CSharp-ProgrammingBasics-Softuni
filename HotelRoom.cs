using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio = 0;
            double apartment = 0;
            double totalStudio = 0;
            double totalApartment = 0;
            if( month == "May" || month== "October")
            {
                studio = 50;
                apartment = 65;
                totalApartment = apartment * nights;
                totalStudio = studio * nights;
                if (nights>7 && nights <14)
                {
                    totalStudio = (nights * studio) * 0.95;
                }
                else if(nights>14)
                {
                    totalStudio = (nights * studio) * 0.7;
                    totalApartment *= 0.9;
                }
                
            }
            if(month == "June" || month == "September")
            {
                studio = 75.20;
                apartment = 68.70;
                totalApartment = apartment * nights;
                totalStudio = nights * studio;
                if (nights > 14)
                {
                    totalStudio = (nights * studio) * 0.8;
                    totalApartment *= 0.9;
                }
            }
            if(month == "July" || month== "August")
            {
                studio = 76;
                apartment = 77;
                totalStudio = studio * nights;
                totalApartment = apartment * nights;
                if(nights>14)
                {
                    totalApartment *= 0.9;
                }
            }
            Console.WriteLine($"Apartment: {totalApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalStudio:f2} lv.");
        }
    }
}
