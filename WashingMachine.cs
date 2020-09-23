using System;

namespace washingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());
            double detergentConvertion = bottles * 750;
            int counter = 0;
            int totalPots = 0;
            int totalDish = 0;
            string command = null;
            while(detergentConvertion>=0)
            {
                command = Console.ReadLine();
                if(command=="End")
                {
                    if(detergentConvertion>=0)
                    {
                        Console.WriteLine("Detergent was enough!");
                        Console.WriteLine($"{totalDish} dishes and {totalPots} pots were washed.");
                        Console.WriteLine($"Leftover detergent {detergentConvertion} ml.");
                        break;
                    }
                }
                counter++;
                int sudove = int.Parse(command);
                if(counter%3==0)
                {
                    detergentConvertion -= sudove * 15;
                    totalPots += sudove;
                }
                else
                {
                    detergentConvertion -= sudove * 5;
                    totalDish += sudove;
                }
            }
            if (detergentConvertion < 0)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(detergentConvertion)} ml. more necessary!");
            }
            else if(command !="End")
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{totalDish} dishes and {totalPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergentConvertion} ml.");
            }
        }
    }
}
