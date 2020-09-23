using System;

namespace RentCar
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string clas = null;
            string carType = null;
            double price = 0;
            if(budget<=100)
            {
                clas = "Economy class";
                if(season=="Summer")
                {
                    carType = "Cabrio";
                    price = budget * 0.35;
                }
                else
                {
                    carType = "Jeep";
                    price = budget * 0.65;
                }
            }
            if(budget>100 && budget<=500)
            {
                clas = "Compact class";
                if(season=="Summer")
                {
                    carType = "Cabrio";
                    price = budget * 0.45;
                }
                else
                {
                    carType = "Jeep";
                    price = budget * 0.80;
                }
            }
            if(budget>500)
            {
                clas = "Luxury class";
                carType = "Jeep";
                price = budget * 0.9;
            }
            Console.WriteLine(clas);
            Console.WriteLine($"{carType} - {price:f2}");
        }
    }
}
