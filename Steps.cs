using System;

namespace steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;
            while(totalSteps<=10000)
            {
                string action = Console.ReadLine();
                if(action =="Going home")
                {
                    int steps = int.Parse(Console.ReadLine());
                    totalSteps += steps;
                    break;
                }
                else
                {
                    int steps2 = int.Parse(action);
                    totalSteps += steps2;
                }
            }
            if(totalSteps>=10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps-10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000-totalSteps} more steps to reach goal.");
            }
        }
    }
}
