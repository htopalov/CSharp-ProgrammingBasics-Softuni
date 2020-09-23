using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string delivery = Console.ReadLine();
            double calculation = 0;
            switch(type)
            {
                case "90X130":
                    calculation = count * 110;
                    if(count>30 && count<=60)
                    {
                        calculation = calculation - (calculation * 0.05);
                    }
                    else if(count>60)
                    {
                        calculation = calculation - (calculation * 0.08);
                    }
                    break;
                case "100X150":
                    calculation = count * 140;
                    if (count > 40 && count <= 80)
                    {
                        calculation = calculation - (calculation * 0.06);
                    }
                    else if (count > 80)
                    {
                        calculation = calculation - (calculation * 0.1);
                    }
                    break;
                case "130X180":
                    calculation = count * 190;
                    if (count > 20 && count <= 50)
                    {
                        calculation = calculation - (calculation * 0.07);
                    }
                    else if (count > 50)
                    {
                        calculation = calculation - (calculation * 0.12);
                    }
                    break;
                case "200X300":
                    calculation = count * 250;
                    if (count > 25 && count <= 50)
                    {
                        calculation = calculation - (calculation * 0.09);
                    }
                    else if (count > 50)
                    {
                        calculation = calculation - (calculation * 0.14);
                    }
                    break;
            }
            if (delivery == "With delivery")
            {
                calculation += 60;
            }
            if (count>99)
            {
                calculation = calculation - calculation * 0.04;
            }
            if(count<10)
            {
                Console.WriteLine("Invalid order");
            }
            else
            {
                Console.WriteLine($"{calculation:f2} BGN");
            }
        }
    }
}
