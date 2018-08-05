using System;

namespace _04._Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read months as number
            double months = double.Parse(Console.ReadLine());

            double electricity = 0.0;
            double water = 0.0;
            double internet = 0.0;
            double other = 0.0;

            // Read the bills for every month
            for (int i = 0; i < months; i++)
            {
                double current = double.Parse(Console.ReadLine());
                electricity += current;
                water += 20;
                internet += 15;
                other += (current + 35) * 1.2;
            }
            double average = (electricity + water + internet + other) / months;

            // Print the bills
            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {other:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");

        }
    }
}
