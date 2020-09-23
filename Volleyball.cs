using System;

namespace volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double hollyday = double.Parse(Console.ReadLine());
            double weekends = double.Parse(Console.ReadLine());//input for games played in hometown
            double calcWeekends = 48 - weekends; 
            double actualWeekends = calcWeekends * 3 / 4;//weekend games played in Sofia
            double calcHollyday = hollyday * 2 / 3; //games in Sofia during Hollydays
            double totalGames = weekends + actualWeekends + calcHollyday;
            if(year =="leap")
            {
                totalGames *= 1.15;
            }
            Console.WriteLine(Math.Floor(totalGames));
        }
    }
}
