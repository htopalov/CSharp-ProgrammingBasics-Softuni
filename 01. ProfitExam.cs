using System;

namespace profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameCompany = Console.ReadLine();
            double adultCount = double.Parse(Console.ReadLine());
            double kidCount = double.Parse(Console.ReadLine());
            double adultPrice = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());
            double calculationKid = adultPrice - adultPrice*0.7 +tax;
            double calculationAdult = adultPrice + tax;
            double total = calculationAdult * adultCount + calculationKid * kidCount;
            Console.WriteLine($"The profit of your agency from {nameCompany} tickets is {total*0.2:f2} lv.");
        }
    }
}
