using System;

namespace Summer_outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            string clothes = "";
            string shoes = "";
            if(day=="Morning")
            {
                if(temp >=10 && temp <=18)
                {
                    clothes = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (temp > 18 && temp <= 24)
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temp >= 25)
                {
                    clothes = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            if (day == "Afternoon")
            {
                if (temp >= 10 && temp <= 18)
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temp > 18 && temp <= 24)
                {
                    clothes = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (temp >= 25)
                {
                    clothes = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            if (day == "Evening")
            {
                    clothes = "Shirt";
                    shoes = "Moccasins";
            }
            Console.WriteLine($"It's {temp} degrees, get your {clothes} and {shoes}.");
        }
    }
}
