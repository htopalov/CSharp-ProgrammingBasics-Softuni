using System;

namespace Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int lenght = word.Length;
            for(int i=0; i<lenght; i++)
            {
                char letter = word[i];
                Console.WriteLine(letter);
            }
        }
    }
}
