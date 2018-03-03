using System;

namespace _06._Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(GetTriangleArea(side, height));
        }
        static double GetTriangleArea(double side, double height)
        {
            return side * height / 2;
        }
    }
}
