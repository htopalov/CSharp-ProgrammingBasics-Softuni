using System;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int duljina = int.Parse(Console.ReadLine());
            int shirochina = int.Parse(Console.ReadLine());
            int visochina = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            int volume = duljina * shirochina * visochina;
            double totalvolume = volume * 0.001;
            double percentcalc = percent * 0.01;
            Console.WriteLine(totalvolume * (1 - percentcalc));
        }
    }
}
