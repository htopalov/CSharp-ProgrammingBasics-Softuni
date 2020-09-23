using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            double hrizantemi = double.Parse(Console.ReadLine());
            double rozi = double.Parse(Console.ReadLine());
            double laleta = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string hollyday = Console.ReadLine();
            if(season=="Spring" || season =="Summer")
            {
                hrizantemi = hrizantemi * 2;
                rozi = rozi * 4.1;
                laleta = laleta * 2.5;
            }
            else if(season =="Autumn" || season =="Winter")
            {
                hrizantemi = hrizantemi * 3.75;
                rozi = rozi * 4.5;
                laleta = laleta * 4.15;
            }
            double total = hrizantemi + rozi + laleta;
            if(hollyday =="Y")
            {
                total *= 1.15;
            }
            if(season =="Spring" && laleta>7)
            {
                total *= 0.95;
            }
            else if(season=="Winter" && rozi>=10)
            {
                total *= 0.9;
            }
            if(rozi>20 || laleta>20 || hrizantemi>20)
            {
                total *= 0.8;
            }
            Console.WriteLine($"{total+2:f2}");
        }
    }
}
