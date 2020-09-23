using System;

namespace minMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            for(int i=0; i<count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(maxNumber<number)
                {
                    maxNumber = number;
                }
                if(minNumber>number)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");

        }
    }
}
