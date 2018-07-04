using System;

namespace _04._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading the number of all marks from the console
            int n = int.Parse(Console.ReadLine());

            // Count every mark
            double topMarks = 0;
            double veryGoodMarks = 0;
            double goodMarks = 0;
            double failMarks = 0;
            double total = 0;
            for (int i = 0; i < n; i++)
            {
                double currentMark = double.Parse(Console.ReadLine());
                total += currentMark;
                if (currentMark >= 5)
                {
                    topMarks++;
                }
                else if (currentMark >= 4)
                {
                    veryGoodMarks++;
                }
                else if (currentMark >= 3)
                {
                    goodMarks++;
                }
                else
                {
                    failMarks++;
                }
            }

            // Print the result in percentages
            Console.WriteLine($"Top students: {topMarks / n * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {veryGoodMarks / n * 100:f2}% ");
            Console.WriteLine($"Between 3.00 and 3.99: {goodMarks / n * 100:f2}% ");
            Console.WriteLine($"Fail: {failMarks / n * 100:f2}%");
            Console.WriteLine($"Average: {total / n:f2}");
            

        }
    }
}
