using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number1 = 0;
            int number2 = 0;
            int sum = 0;
            for(int i=0; i<n; i++)
            {
                number1 = int.Parse(Console.ReadLine());
                number2 = int.Parse(Console.ReadLine());
                sum = number1 + number2;
            }
        }
    }
}
