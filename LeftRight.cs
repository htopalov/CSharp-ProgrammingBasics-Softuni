using System;

namespace LeftRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            string output = null;
            for(int i = 0; i<n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum1 += number;
            }
            for (int i = 0; i<n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum2 += number;
            }
            if(sum1==sum2)
            {
                output = $"Yes, sum = { sum1}";
            }
            else
            {
                output = $"No, diff = {Math.Abs(sum1 - sum2)}";
            }
            Console.WriteLine(output);
        }
    }
}
