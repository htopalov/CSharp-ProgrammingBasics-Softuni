using System;

namespace Star_rectsngle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', num));

            for (int i = 0; i < num - 2; i++)
            {
                Console.WriteLine("*{0}*", new string(' ', num - 2));
            }
            Console.WriteLine(new string('*', num));
        }
    }
}
