using System;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            double fans = double.Parse(Console.ReadLine());
            double sectorA = 0;
            double sectorB = 0;
            double sectorV = 0;
            double sectorG = 0;
            for(int i =0; i<fans; i++)
            {
                string sector = Console.ReadLine();
                if(sector=="A")
                {
                    sectorA++;
                }
                else if(sector=="B")
                {
                    sectorB++;
                }
                else if(sector=="V")
                {
                    sectorV++;
                }
                else if(sector=="G")
                {
                    sectorG++;
                }
            }
            Console.WriteLine($"{sectorA / fans * 100:f2}%");
            Console.WriteLine($"{sectorB / fans * 100:f2}%");
            Console.WriteLine($"{sectorV / fans * 100:f2}%");
            Console.WriteLine($"{sectorG / fans * 100:f2}%");
            Console.WriteLine($"{fans / capacity * 100:f2}%");
        }
    }
}
