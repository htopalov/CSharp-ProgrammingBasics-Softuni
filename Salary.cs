using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for(int i =0; i<n; i++)
            {
                string tabs = Console.ReadLine();
                if(tabs=="Facebook")
                {
                    salary -= 150;
                }
                else if(tabs =="Instagram")
                {
                    salary -= 100;
                }
                else if(tabs =="Reddit")
                {
                    salary -= 50;
                }
                if(salary<=0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if(salary>0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
