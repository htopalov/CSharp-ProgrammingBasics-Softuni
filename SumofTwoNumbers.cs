using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combos = 0;
            int sum;

            for (int i = startNumber; i <= endNumber; i++) 
            {
                for (int j = startNumber; j <= endNumber; j++)
                {
                    sum = i + j;
                    combos++;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combos} ({i} + {j} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combos} combinations - neither equals {magicNumber}");
        }
    }
}