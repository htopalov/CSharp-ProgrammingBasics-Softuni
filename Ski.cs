using System;

namespace Ski
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string opinion = Console.ReadLine();
            double price = 0.0;
            double discount = 0.0;
            double priceAfterOpinion = 0.0;
            switch(type)
            {
                case "room for one person": price = 18.00; break;
                case "apartment": price = 25.00; break;
                case "president apartment": price = 35.00; break;
            }
            double totalPrice = (period - 1) * price;
            if(period <10)
            {
                switch(type)
                {
                    case "room for one person": discount = (period - 1) * price; break;//zero discount for "room for one person"
                    case "apartment":  discount = totalPrice - (totalPrice * 0.3); break;
                    case "president apartment": discount = totalPrice - (totalPrice * 0.1); break;
                }
            }
            else if (period >= 10 && period<=15)
            {
                switch (type)
                {
                    case "room for one person": discount = (period - 1) * price; break;
                    case "apartment": discount = totalPrice - (totalPrice * 0.35); break;
                    case "president apartment": discount = totalPrice - (totalPrice * 0.15); break;
                }
            }
            else if (period > 15)
            {
                switch (type)
                {
                    case "room for one person": discount = (period - 1) * price; break;
                    case "apartment": discount = totalPrice - (totalPrice * 0.5); break;
                    case "president apartment": discount = totalPrice - (totalPrice * 0.2); break;
                }
            }

            if(opinion=="positive")
            {
                priceAfterOpinion = discount + (discount * 0.25);
            }
            else
            {
                priceAfterOpinion = discount - (discount * 0.1);
            }
            Console.WriteLine($"{priceAfterOpinion:f2}");
        }
    }
}
