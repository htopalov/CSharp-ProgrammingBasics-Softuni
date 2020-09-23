using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int n = int.Parse(Console.ReadLine());
            for(int number1 = 0; number1<=n; number1++)
            {
                for(int number2 = 0; number2<=n; number2++)
                {
                    for(int number3=0; number3<=n; number3++)
                    {
                        if(number1+number2+number3 == n)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
