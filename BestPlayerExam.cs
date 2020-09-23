using System;

namespace bestplayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = null;
            string previousPlayer = null;
            string name = null;
            int goals = 0;
            int currentGoals = 0;
            while (true)
            {
                command = Console.ReadLine();
                if (command != "END")
                {
                    currentGoals = int.Parse(Console.ReadLine());
                    if (currentGoals != goals)
                    {
                        previousPlayer = command;
                        name = command;
                    }
                    else
                    {
                        name = previousPlayer;
                    }
                }
                else
                {
                    break;
                }
                if (currentGoals >= goals)
                {
                    goals = currentGoals;
                }
                if (goals >= 10)
                {
                    break;
                }
            }
            Console.WriteLine($"{name} is the best player!");
            if (goals >= 3)
            {
                Console.WriteLine($"He has scored {goals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {goals} goals.");
            }
        }
    }
}