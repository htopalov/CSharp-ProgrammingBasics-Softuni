using System;

namespace balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int ballsCount = int.Parse(Console.ReadLine());
            int points = 0;
            int otherColorsCount = 0;
            int devideCount = 0;
            int redCount = 0;
            int orangeCount = 0;
            int yellowCount = 0;
            int whiteCount = 0;
            for(int i =0; i<ballsCount; i++)
            {
                string color = Console.ReadLine();
                if(color =="red")
                {
                    points += 5;
                    redCount++;
                }
                else if(color=="orange")
                {
                    points += 10;
                    orangeCount++;
                }
                else if(color=="yellow")
                {
                    points += 15;
                    yellowCount++;
                }
                else if(color=="white")
                {
                    points += 20;
                    whiteCount++;
                }
                else if(color=="black")
                {
                    points = points / 2;
                    devideCount++;
                }
                else
                {
                    otherColorsCount++;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Points from red balls: {redCount}");
            Console.WriteLine($"Points from orange balls: {orangeCount}");
            Console.WriteLine($"Points from yellow balls: {yellowCount}");
            Console.WriteLine($"Points from white balls: {whiteCount}");
            Console.WriteLine($"Other colors picked: {otherColorsCount}");
            Console.WriteLine($"Divides from black balls: { devideCount}");
        }
    }
}
