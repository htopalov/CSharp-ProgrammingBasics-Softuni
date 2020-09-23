using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string term = Console.ReadLine();
            string type = Console.ReadLine();
            string mNet = Console.ReadLine();
            int monthCount = int.Parse(Console.ReadLine());
            double price = 0;
            double mNetPrice = 0;
            if(term=="one")
            {
                switch(type)
                {
                    case "Small": price = 9.98; break;
                    case "Middle": price = 18.99; break;
                    case "Large": price = 25.98; break;
                    case "ExtraLarge": price = 35.99; break;
                }
            }
            else if(term=="two")
            {
                switch (type)
                {
                    case "Small": price = 8.58; break;
                    case "Middle": price = 17.09; break;
                    case "Large": price = 23.59; break;
                    case "ExtraLarge": price = 31.79; break;
                }
            }
            if(mNet=="yes")
            {
                if(price<=10)
                {
                    mNetPrice = 5.5;
                }
                else if(price<=30)
                {
                    mNetPrice = 4.35;
                }
                else if(price>30)
                {
                    mNetPrice = 3.85;
                }
            }
            double calculation = (price + mNetPrice) * monthCount;
            if(term=="two")
            {
                calculation *= 0.9625; 
            }
            Console.WriteLine($"{calculation:f2} lv.");
        }
    }
}
