using System;

namespace InchToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double centimeters = 2.54 * input;
            Console.WriteLine(centimeters);
        }
    }
}
