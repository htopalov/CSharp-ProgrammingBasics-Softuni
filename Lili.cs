using System;

namespace LILI
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double savedMoney = 0;
            double toyMoney = 0;
            for(int i =1; i<=age; i++)
            {
                if(i%2==0)
                {
                    savedMoney += ((i / 2.0) * 10.0) - 1.0;
                }
                else
                {
                    toyMoney += toyPrice;
                }
            }
            double totalMoney = savedMoney + toyMoney;
            if(totalMoney>=washingMPrice)
            {
                Console.WriteLine($"Yes! {totalMoney-washingMPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(washingMPrice - totalMoney):f2}");
            }
        }
    }
}
