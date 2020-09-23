﻿using System;

namespace PreparationExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedThreshold = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            int solvedProblemsCount = 0;
            double gradeSum = 0;
            string lastProblem = null;
            bool isFailed = true;
            while(failedTimes<failedThreshold)
            {
                string problemName = Console.ReadLine();
                if(problemName =="Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if(grade<=4)
                {
                    failedTimes++;
                }
                gradeSum += grade;
                solvedProblemsCount++;
                lastProblem = problemName;
            }
            if(isFailed)
            {
                Console.WriteLine($"You need a break, {failedThreshold} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradeSum/solvedProblemsCount:F2}");
                Console.WriteLine($"Number of problems: {solvedProblemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}