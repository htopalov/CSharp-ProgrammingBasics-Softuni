using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookpages = int.Parse(Console.ReadLine());
            double pagesperhour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double totaltime = (bookpages / pagesperhour)/days;
            Console.WriteLine(totaltime);

        }
    }
}
