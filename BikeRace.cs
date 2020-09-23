using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorsCount = int.Parse(Console.ReadLine());
            int seniorsCount = int.Parse(Console.ReadLine());
            string traceType = Console.ReadLine();
            double money = 0;
            if(traceType == "trail")
            {
                money = juniorsCount * 5.50 + seniorsCount * 7;
            }
            else if(traceType =="cross-country")
            {
                if (juniorsCount + seniorsCount >= 50)
                {
                    money = (juniorsCount * 8 + seniorsCount * 9.5) * 0.75;
                }
                else
                {
                    money = juniorsCount * 8 + seniorsCount * 9.5;
                }
            }
            else if (traceType =="downhill")
            {
                money = juniorsCount * 12.25 + seniorsCount * 13.75;
            }
            else if(traceType =="road")
            {
                money = juniorsCount * 20 + seniorsCount * 21.50;
            }
            money = money - (money * 0.05);
            Console.WriteLine($"{ money:f2}");
        }
    }
}
