using System;

namespace Stipendii
{
    class Program
    {
        static void Main(string[] args)
        {
            double inCome = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double wage = double.Parse(Console.ReadLine());
            double socialStipend = Math.Floor(wage * 0.35);
            double excellentStipend = Math.Floor(averageGrade * 25);
            //Stipendiq za otlichen uspeh ako vzema i dvete i tq e po-golqma
            if(averageGrade>=5.50 && inCome < wage && excellentStipend>= socialStipend)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentStipend} BGN");
            }
            //**********************************
            //Socialna stipendiq ako vzema i dvete i tq e po-golqma
            else if (averageGrade >= 5.50 && inCome < wage && excellentStipend < socialStipend)
            {
                Console.WriteLine($"You get a scholarship for excellent results {socialStipend} BGN");
            }
            //Stipendiq za otlichen uspeh
            else if(averageGrade >=5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentStipend} BGN");
            }
            //Socialna stipendiq
            else if(averageGrade > 4.50 && inCome < wage)
            {
                Console.WriteLine($"You get a Social scholarship {socialStipend} BGN");
            }
            //********************************
            //No stipend
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }


        }
    }
}
