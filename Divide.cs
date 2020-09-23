﻿using System;

namespace Divide
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            for(int i=0; i<n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(number%2==0)
                {
                    p1++;
                }
                if(number%3==0)
                {
                    p2++;
                }
                if(number%4==0)
                {
                    p3++;
                }
            }
            double result1 = p1 / n * 100;
            double result2 = p2 / n * 100;
            double result3 = p3 / n * 100;
            Console.WriteLine($"{result1:f2}%");
            Console.WriteLine($"{result2:f2}%");
            Console.WriteLine($"{result3:f2}%");
        }
    }
}
