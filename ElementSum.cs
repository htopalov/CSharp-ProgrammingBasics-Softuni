using System;

namespace ElementSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 0;
            int max = 0;
            for(int i=0; i<n; i++)
            {
                number = int.Parse(Console.ReadLine());
                sum += number;
                if(number>max)
                {
                    max = number;
                }
            }
            int sumwithoutMax = sum-max;
            if(max == sumwithoutMax)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            {
                int diff = Math.Abs(max - sumwithoutMax);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
