using System;

namespace hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days =int.Parse(Console.ReadLine());
            int patients = 0;
            int doctors = 7;
            int uncheckPatients = 0;
            int checkPatients = 0;
            for(int i = 1; i<=days; i++)
            {
                patients = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && uncheckPatients > checkPatients)
                {
                    doctors++;
                }
                if (patients<doctors)
                {
                    checkPatients += patients;
                }
                else
                {
                    checkPatients += doctors;
                    uncheckPatients += patients - doctors;
                }
            }
            Console.WriteLine($"Treated patients: {checkPatients}.");
            Console.WriteLine($"Untreated patients: {uncheckPatients}.");
        }
    }
}
