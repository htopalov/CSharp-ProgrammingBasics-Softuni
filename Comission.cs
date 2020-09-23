using System;

namespace Comission
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double discount = 0.0;
            if ((town == "Sofia" || town == "Varna" || town == "Plovdiv") && sales > 0)
            {
                if(sales >= 0 && sales <=500)
                {
                    switch(town)
                    {
                        case "Sofia": discount = sales * 0.05; break;
                        case "Varna": discount = sales * 0.045; break;
                        case "Plovdiv": discount = sales * 0.055; break;
                    }
                }
                else if (sales > 500 && sales <= 1000)
                {
                    switch (town)
                    {
                        case "Sofia": discount = sales * 0.07; break;
                        case "Varna": discount = sales * 0.075; break;
                        case "Plovdiv": discount = sales * 0.08; break;
                    }
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    switch (town)
                    {
                        case "Sofia": discount = sales * 0.08; break;
                        case "Varna": discount = sales * 0.1; break;
                        case "Plovdiv": discount = sales * 0.12; break;
                    }
                }
                else if (sales > 10000)
                {
                    switch (town)
                    {
                        case "Sofia": discount = sales * 0.12; break;
                        case "Varna": discount = sales * 0.13; break;
                        case "Plovdiv": discount = sales * 0.145; break;
                    }
                }
                Console.WriteLine($"{discount:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
