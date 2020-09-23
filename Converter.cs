using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string unitInput = Console.ReadLine();
            string unitOutput = Console.ReadLine();
            double convertion = 0.0;
            if (unitInput == "m")
            {
                if (unitOutput == "cm")
                {
                    convertion = number * 100;
                }
                else if (unitOutput == "mm")
                {
                    convertion = number * 1000;
                }
            }
            else if (unitInput == "mm")
            {
                if (unitOutput == "m")
                {
                    convertion = number / 1000;
                }
                else if (unitOutput == "cm")
                {
                    convertion = number / 10;
                }
            }
            else if (unitInput == "cm")
            {
                if (unitOutput == "m")
                {
                    convertion = number / 100;
                }
                else if (unitOutput == "mm")
                {
                    convertion = number * 10;
                }
            }
                Console.WriteLine($"{convertion:f3}");
            }
        }
    }

