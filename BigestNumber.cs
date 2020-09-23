using System;

namespace bigestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double minNumber = double.MaxValue;
            while (true)
            {
                string input = Console.ReadLine();
                if(input=="Stop")
                {
                    break;
                }
                double number = double.Parse(input);
                if(number<minNumber)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
