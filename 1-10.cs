using System;

namespace _1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = double.Parse(Console.ReadLine());
            while (i >=0)
            {
                if (i < 0)
                {
                    Console.WriteLine("Negative number!");
                }
                else
                {
                    Console.WriteLine($"Result: {i * 2:f2}");
                }
            }
        }
    }
}
