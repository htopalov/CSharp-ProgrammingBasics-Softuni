using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int loadCount = int.Parse(Console.ReadLine());
            double busLoad = 0;
            double truckLoad = 0;
            double trainLoad = 0;
            double totalLoad = 0;
            double busPerc = 0;
            double truckPerc = 0;
            double trainPerc = 0;
            for(int i=1; i<=loadCount; i++)
            {
                int load = int.Parse(Console.ReadLine());
                totalLoad += load;
                if (load<=3)
                {
                    busLoad += load;
                }
                else if(load >=4 && load<=11)
                {
                    truckLoad += load;
                }
                else
                {
                    trainLoad += load;
                }
            }
            busPerc = busLoad / totalLoad * 100;
            truckPerc = truckLoad / totalLoad * 100;
            trainPerc = trainLoad / totalLoad * 100;
            double averagePrice = (busLoad * 200 + truckLoad * 175 + trainLoad * 120) / totalLoad;
            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{busPerc:f2}%");
            Console.WriteLine($"{truckPerc:f2}%");
            Console.WriteLine($"{trainPerc:f2}%");
        }
    }
}
