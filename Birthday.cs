using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double rentprice = double.Parse(Console.ReadLine());
            double cake = rentprice * 0.20;
            double drinks = cake -(cake* 0.45);
            double animator = rentprice/3.0;
            Console.WriteLine(rentprice+cake+drinks+animator);

        }
    }
}
