using System;

namespace _08._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"({ClosestToZero(x1, x2, y1, y2).Item1}, {ClosestToZero(x1, x2, y1, y2).Item2})");

        }
        static (double, double) ClosestToZero(double x1, double x2, double y1, double y2)
        {
            double line1 = Math.Sqrt(Math.Pow(x1,2) + Math.Pow(y1, 2));
            double line2 = Math.Sqrt(Math.Pow(x2,2) + Math.Pow(y2, 2));
            if (line1 < line2)
            {
                return (x1, y1);
            }
            else
            {
                return (x2, y2);
            }

        }

    }
}
