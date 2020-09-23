using System;

namespace Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int personel = int.Parse(Console.ReadLine());
            double clothesprice = double.Parse(Console.ReadLine());
            double decor = budget * 0.1;
            double totalclothesprice = clothesprice * personel;
            if (personel>150)
            {
                totalclothesprice = totalclothesprice - (totalclothesprice * 0.1);
            }
            double totalPRICE = decor + totalclothesprice;
            if (totalPRICE>budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalPRICE - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-totalPRICE:f2} leva left.");
            }
        }
    }
}
