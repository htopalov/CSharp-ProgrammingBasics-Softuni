using System;

namespace IntervalsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            double moves = double.Parse(Console.ReadLine());
            double interval1 = 0;
            double interval2 = 0;
            double interval3 = 0;
            double interval4 = 0;
            double interval5 = 0;
            double invalidInterval = 0;
            double points = 0;

            for(int i =0; i<moves; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if(number>=0 && number<=9)
                {
                    interval1++;
                    points += number * 0.2;
                }
                else if(number>=10 && number<=19)
                {
                    interval2++;
                    points += number * 0.3;
                }
                else if(number>=20 && number <=29)
                {
                    interval3++;
                    points += number * 0.4;
                }
                else if(number>=30 && number<=39)
                {
                    interval4++;
                    points += 50;
                }
                else if(number>=40 && number<=50)
                {
                    interval5++;
                    points += 100;
                }
                else
                {
                    invalidInterval++;
                    points = points / 2;
                }
            }
            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {interval1 / moves * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {interval2 / moves * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {interval3 / moves * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {interval4 / moves * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {interval5 / moves * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {invalidInterval / moves * 100:f2}%");
        }
    }
}
