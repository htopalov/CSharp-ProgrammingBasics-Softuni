using System;

namespace SumPrimeNotPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = null;
            int sumPrime = 0;
            int sumNonprime = 0;
            while (true)
            {
                command = Console.ReadLine();
                if(command =="stop")
                {
                    break;
                }
                int inputNumber = int.Parse(command);
                if (inputNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    bool isPrime = true;
                    for (int i = 2; i <= inputNumber - 1; i++)
                    {
                        if(inputNumber%i==0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        sumPrime += inputNumber;
                    }
                    else
                    {
                        sumNonprime += inputNumber;
                    }
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonprime}");
        }
    }
}
