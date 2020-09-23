using System;

namespace DotRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            string output = null;
                if ((x == x1 || x == x2) && (y >= y1 && y <= y2))
                {
                    output = "Border";
                }
                else if ((y == y1 || y == y2) && (x >= x1 && x <= x2))
                {
                    output = "Border";
                }
                else
                {
                    output = "Inside / Outside";
                }
                Console.WriteLine(output);
        }
    }
}
