using System;

namespace Fruit
{
    class Program
    {
        static void Main(string[] args)
        {
            double qgodicena = double.Parse(Console.ReadLine());//
            double bananakol = double.Parse(Console.ReadLine());//
            double orangekol = double.Parse(Console.ReadLine());//
            double malinikol = double.Parse(Console.ReadLine());//
            double qgodikol = double.Parse(Console.ReadLine());//

            //price calculation
            double maliniprice = qgodicena / 2.0;
            double orangeprice = maliniprice - (maliniprice * 0.4);
            double bananaprice = maliniprice - (maliniprice * 0.8);
            double total = qgodicena * qgodikol + bananakol * bananaprice + orangekol * orangeprice + malinikol * maliniprice;
            Console.WriteLine($"{total:f2}");

        }
    }
}
