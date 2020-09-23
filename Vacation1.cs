using System;

namespace vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double needMoney = double.Parse(Console.ReadLine());
            double availvableMoney = double.Parse(Console.ReadLine());
            int k = 0;
            int j = 0;
            while(availvableMoney<needMoney && j<5)
            {
                string action = Console.ReadLine();
                double spendSavedMoney = double.Parse(Console.ReadLine());
                k++;
                if(action == "save")
                {
                    availvableMoney += spendSavedMoney;
                    j = 0;
                }
                else if(action=="spend")
                {
                    availvableMoney -= spendSavedMoney;
                    j++;
                    if(availvableMoney<=0)
                    {
                        availvableMoney = 0;
                    }
                }
                if (j == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(j);
                    break;
                }
                if (availvableMoney >= needMoney)
                {
                    Console.WriteLine($"You saved the money for {k} days.");
                    break;
                }
            }
        }
    }
}
