using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            int mydogs = int.Parse(Console.ReadLine());
            int otherdogs = int.Parse(Console.ReadLine());
            double myfood = mydogs * 2.50;
            int otherfood = otherdogs * 4;
            double subirane = myfood + otherfood;
            Console.WriteLine(subirane + " lv.");
        }
    }
}
