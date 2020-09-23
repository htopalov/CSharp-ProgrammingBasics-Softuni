using System;

namespace Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double gas = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            double calculation = gas * 2.10 + 100;
            if(day=="Saturday")
            {
                calculation = calculation - calculation * 0.1;
            }
            else if(day=="Sunday")
            {
                calculation = calculation - calculation * 0.2;
            }
            if(budget>=calculation)
            {
                Console.WriteLine($"Safari time! Money left: {budget-calculation:f2} lv. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {Math.Abs(calculation-budget):f2} lv.");
            }
        }
    }
}
