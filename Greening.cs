using System;

namespace Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double price = 7.61;
            double calprice = area * price;
            double discount = calprice * 0.18;
            Console.WriteLine($"The final price is: {calprice-discount:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");
        }
    }
}
