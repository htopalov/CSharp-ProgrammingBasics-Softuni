using System;

namespace matchtickes
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string categoryOfTicket = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double totalTicketPrice = 0;
            double transport = 0;
            string output = null;
            if(people >= 1 && people <= 4)
            {
                transport = 0.75 * budget;
            }
            else if(people >= 5 && people <= 9)
            {
                transport = 0.60 * budget;
            }
            else if(people >= 10 && people <= 24)
            {
                transport = 0.5 * budget;
            }
            else if(people >= 25 && people <= 49)
            {
                transport = 0.4 * budget;
            }
            else if(people >= 50)
            {
                transport = 0.25 * budget;
            }
            if(categoryOfTicket =="VIP")
            {
                totalTicketPrice = people * 499.99;
            }
            else
            {
                totalTicketPrice = people * 249.99;
            }
            double total = totalTicketPrice + transport;
            if (total<budget)
            {
                output = $"Yes! You have {Math.Abs(budget - total):f2} leva left.";
            }
            else
            {
                output = $"Not enough money! You need {Math.Abs(budget - total):f2} leva.";
            }
            Console.WriteLine(output);
        }
    }
}
