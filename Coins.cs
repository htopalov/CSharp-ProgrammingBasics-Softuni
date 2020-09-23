using System;
using System.Threading;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double convertToCoins = Math.Floor(change * 100);
            int count = 0;
            while(convertToCoins !=0)
            {
                if(convertToCoins>=200)
                {
                    convertToCoins -= 200;
                    count++;
                }
                else if(convertToCoins>=100)
                {
                    convertToCoins -= 100;
                    count++;
                }
                else if(convertToCoins>=50)
                {
                    convertToCoins -= 50;
                    count++;
                }
                else if(convertToCoins>=20)
                {
                    convertToCoins -= 20;
                    count++;
                }
                else if(convertToCoins>=10)
                {
                    convertToCoins -= 10;
                    count++;
                }
                else if(convertToCoins>=5)
                {
                    convertToCoins -= 5;
                    count++;
                }
                else if(convertToCoins>=2)
                {
                    convertToCoins -= 2;
                    count++;
                }
                else if(convertToCoins>=1)
                {
                    convertToCoins -= 1;
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
