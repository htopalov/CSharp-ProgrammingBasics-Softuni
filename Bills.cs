using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double totalElectricity = 0;
            double totalWater = months * 20;
            double totalInternet = months * 15;
            double Others = 0;
            for (int i = 1; i<=months; i++)
            {
                 double electricity = double.Parse(Console.ReadLine());
                totalElectricity += electricity;
                Others += (35 + electricity) * 1.2;

            }
            Console.WriteLine($"Electricity: {totalElectricity:f2} lv");
            Console.WriteLine($"Water: {totalWater:f2} lv");
            Console.WriteLine($"Internet: {totalInternet:f2} lv");
            Console.WriteLine($"Other: {Others:f2} lv");
            Console.WriteLine($"Average: {(totalWater+totalInternet+totalElectricity+Others)/months:f2} lv");
        }
    }
}
