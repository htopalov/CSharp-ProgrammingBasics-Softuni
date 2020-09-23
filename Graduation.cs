using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int k = 0;
            int j = 0;
            double sumGrade = 0;
            while(true)
            {
                if(k==12)
                {
                    Console.WriteLine($"{studentName} graduated. Average grade: {sumGrade / 12.00:f2}");
                    break;
                }
                else if(j==1)
                {
                        Console.WriteLine($"{studentName} has been excluded at {j+k} grade");
                        break;
                }
                double grade = double.Parse(Console.ReadLine());
                if (grade>=4.00)
                {
                    k++;
                    sumGrade += grade;
                }
                else if(grade<=3.99)
                {
                    j++;     
                }
            }
        }
    }
}
