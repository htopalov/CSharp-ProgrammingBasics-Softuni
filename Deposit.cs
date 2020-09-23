using System;

namespace Deposit
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            double lihva = double.Parse(Console.ReadLine());
            //calculations
            double calclihva1 = deposit * (lihva)/100;
            double calclihva2 = calclihva1 / 12;
            double obshtasuma = deposit + (time * calclihva2);
            Console.WriteLine(obshtasuma);
        }
    }
}
