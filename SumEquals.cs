﻿using System;

namespace sumequals
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            for(int i = startNumber; i<=endNumber; i++)
            {
                string currentNumber = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for(int j = 0; j<currentNumber.Length; j++)
                {
                    int currentDigit = int.Parse(currentNumber[j].ToString());
                    if(j%2==0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                }
                if(evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
