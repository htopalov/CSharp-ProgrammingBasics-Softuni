using System;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double distance = double.Parse(Console.ReadLine());
            double salary = 0;
            if (distance <= 5000)
            {
                if (season == "Autumn" || season == "Spring")
                {
                    salary = distance * 0.75 * 4 * 0.9;
                }
                else if (season == "Summer")
                {
                    salary = distance * 0.90 * 4 * 0.9;
                }
                else
                {
                    salary = distance * 1.05 * 4 * 0.9;
                }
            }
            if (distance > 5000 && distance <= 10000)
            {
                if (season == "Autumn" || season == "Spring")
                {
                    salary = distance * 0.95 * 4 * 0.9;
                }
                else if (season == "Summer")
                {
                    salary = distance * 1.10 * 4 * 0.9;
                }
                else
                {
                    salary = distance * 1.25 * 4 * 0.9;
                }
            }
            if (distance > 10000 && distance <= 20000)
            {
                salary = distance * 1.45 * 4 * 0.9;
            }
            Console.WriteLine($"{salary:f2}");
        }
    }
}
