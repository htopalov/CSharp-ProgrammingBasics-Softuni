using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeSeconds = double.Parse(Console.ReadLine());

            double mustSwim = distanceMeters * timeSeconds;
            double totalSeconds = Math.Floor(distanceMeters / 15) * 12.5;
            double totalTime = mustSwim + totalSeconds;

            if (recordInSeconds <= totalTime)
            {
                totalTime -= recordInSeconds;
                Console.WriteLine($"No, he failed! He was {totalTime:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
        }
    }
}
