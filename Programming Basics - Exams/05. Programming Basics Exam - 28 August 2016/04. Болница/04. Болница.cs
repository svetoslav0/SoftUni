using System;

namespace _04._Болница
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading the input data from the console
            int days = int.Parse(Console.ReadLine());

            int treated = 0;
            int untreated = 0;
            int doctors = 7;

            // This loops count the patients for each day
            for (int i = 1; i <= days; i++)
            {
                if (untreated > treated && i % 3 == 0)
                {
                    doctors++;
                }

                int patientsPerDay = int.Parse(Console.ReadLine());
                treated += doctors >= patientsPerDay ? patientsPerDay : doctors;
                if (patientsPerDay > doctors)
                {
                    untreated += patientsPerDay - doctors;
                }
            }

            // Print the results
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");

        }
    }
}
