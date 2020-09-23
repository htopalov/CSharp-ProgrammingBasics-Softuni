using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int wide = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int totalVolume = wide * lenght * height;
            int sumBoxesVolume = 0;
            while(true)
            {
                string input = Console.ReadLine();
                if (input=="Done")
                {
                    if(totalVolume>sumBoxesVolume)
                    {
                        Console.WriteLine($"{totalVolume-sumBoxesVolume} Cubic meters left.");
                        break;
                    }
                    else if(sumBoxesVolume>totalVolume)
                    {
                        Console.WriteLine($"No more free space! You need {sumBoxesVolume - totalVolume} Cubic meters more.");
                        break;
                    }
                }
                sumBoxesVolume += int.Parse(input);
                if (sumBoxesVolume > totalVolume)
                {
                    Console.WriteLine($"No more free space! You need {sumBoxesVolume - totalVolume} Cubic meters more.");
                    break;
                }
            }
        }
    }
}
