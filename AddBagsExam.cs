using System;

namespace bags
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOverTwenty = double.Parse(Console.ReadLine());
            double kilograms = double.Parse(Console.ReadLine());
            double daysToTrip = double.Parse(Console.ReadLine());
            double bagageCount = double.Parse(Console.ReadLine());
            double calc = 0;
            if(kilograms<10)
            {
                calc = priceOverTwenty * 0.2;
            }
            else if(kilograms>=10 && kilograms<=20)
            {
                calc = priceOverTwenty * 0.5;
            }
            else if(kilograms>20)
            {
                calc = priceOverTwenty;
            }
            if(daysToTrip>30)
            {
                calc = calc * 1.10;
            }
            else if(daysToTrip>=7 && daysToTrip<=30)
            {
                calc = calc * 1.15;
            }
            else if(daysToTrip<7)
            {
                calc = calc * 1.40;
            }
            Console.WriteLine($"The total price of bags is: {calc*bagageCount:f2} lv. ");
        }
    }
}
