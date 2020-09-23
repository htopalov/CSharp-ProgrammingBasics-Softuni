using System;

namespace grade
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentCount = double.Parse(Console.ReadLine());
            double excellentStudents = 0;
            double veryGoodStudents = 0;
            double averageStudents = 0;
            double failStudents = 0;
            double totalMark = 0;
            for(int i=1; i<=studentCount; i++)
            {
                double mark = double.Parse(Console.ReadLine());
                if(mark>=2.00 && mark<=2.99)
                {
                    failStudents++;
                }
                else if(mark>= 3.00 && mark <=3.99)
                {
                    averageStudents++;
                }
                else if(mark >= 4.00 && mark<=4.99)
                {
                    veryGoodStudents++;
                }
                else
                {
                    excellentStudents++;
                }
                totalMark += mark;
            }
            double averageMark = totalMark / studentCount;
            Console.WriteLine($"Top students: {excellentStudents / studentCount * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {veryGoodStudents / studentCount * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {averageStudents / studentCount * 100:f2}%");
            Console.WriteLine($"Fail: {failStudents / studentCount * 100:f2}%");
            Console.WriteLine($"Average: {averageMark:f2}");
        }
    }
}
