using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            if (flowersType =="Roses")
            {
                totalPrice = count * 5;
                if(count >80)
                {
                    totalPrice *= 0.9;
                }
            }
            else if (flowersType== "Dahlias")
            {
                totalPrice = count * 3.8;
                if(count>90)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (flowersType == "Tulips")
            {
                totalPrice = count * 2.8;
                if (count>80)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (flowersType == "Narcissus")
            {
                totalPrice = count * 3;
                if (count<120)
                {
                    totalPrice *= 1.15;
                }
            }
            else if (flowersType == "Gladiolus")
            {
                totalPrice = count * 2.5;
                if (count<80)
                {
                    totalPrice *= 1.20;
                }
            }
            if(budget>=totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flowersType} and {budget-totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(totalPrice-budget):f2} leva more.");
            }
        }
    }
}
