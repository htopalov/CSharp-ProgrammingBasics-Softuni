using System;

namespace _2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int k = 1;
            while(k<=inputNumber)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }
        }
    }
}
