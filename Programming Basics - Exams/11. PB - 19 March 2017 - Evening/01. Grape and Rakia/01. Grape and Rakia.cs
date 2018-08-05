using System;

namespace _01._Grape_and_Rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input data from the console
            double area = double.Parse(Console.ReadLine());
            double kilosPerSqMeter = double.Parse(Console.ReadLine());
            double waste = double.Parse(Console.ReadLine());

            double grape = area * kilosPerSqMeter - waste;
            double rakia = 0.45 * grape / 7.5;
            double earningFromRakia = rakia * 9.8;
            Console.WriteLine($"{earningFromRakia:f2}");

            double earningFromGrape = 0.55 * grape * 1.5;
            Console.WriteLine($"{earningFromGrape:f2}");


        }
    }
}
