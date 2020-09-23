using System;

namespace cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int wide = int.Parse(Console.ReadLine());
            int lengh = int.Parse(Console.ReadLine());
            int cakeArea = wide * lengh;
            int peice = 0;
            while(cakeArea > 0)
            {
                string command = Console.ReadLine();
                if (command == "STOP")
                {
                    if (cakeArea > 0)
                    {
                        Console.WriteLine($"{cakeArea} pieces are left.");
                    }
                    break;
                }
                else
                {
                    peice = int.Parse(command);
                    cakeArea -= peice; 
                }
            }
            if(cakeArea<=0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeArea)} pieces more.");
            }
        }
    }
}
