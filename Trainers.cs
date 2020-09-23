using System;

namespace trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            double trainers = double.Parse(Console.ReadLine());
            double total = 0;
            double count = 0;
            while(true)
            {
                string command = Console.ReadLine();
                if (command == "Finish")
                {
                    Console.WriteLine($"Student's final assessment is {total/count:f2}.");
                    break;
                }

                    count++;
                    double presentationGrade = 0;
                    for (int i = 0; i < trainers; i++)
                    {
                        double grade = double.Parse(Console.ReadLine());
                        presentationGrade += grade;
                    }
                    presentationGrade /= trainers;
                    total += presentationGrade;
                    Console.WriteLine($"{command} - {presentationGrade:f2}.");
            }
        }
    }
}
