﻿using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while(sum<number)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                sum += inputNumber;
            }
            Console.WriteLine(sum);


        }
    }
}
