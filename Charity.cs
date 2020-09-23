using System;

namespace Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int gofreti = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            double moneycakes = cakes * 45;
            double gofretimoney = gofreti * 5.80;
            double pancakesmoney = pancakes * 3.20;
            double daymoney = (moneycakes + gofretimoney + pancakesmoney) * bakers;
            double allmoney = daymoney * days;
            double razhodi = allmoney * (1 / 8.0);
            Console.WriteLine(allmoney-razhodi);
        }
    }
}
