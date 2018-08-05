using System;

namespace _01._House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input from the console
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            // Calculate the areas of the walls...
            double sideWallsArea = x * y * 2 - 4.5;
            double backWallArea = x * x;
            double frontWallArea = x * x - 2.4;
            double totalWallsArea = sideWallsArea + backWallArea + frontWallArea;
            double greenPaint = totalWallsArea / 3.4;
            Console.WriteLine($"{greenPaint:f2}");

            // ... and the roof
            double rectanglesArea = 2 * x * y;
            double trianglesArea = x * h;
            double totalRoofArea = rectanglesArea + trianglesArea;
            double redPaint = totalRoofArea / 4.3;
            Console.WriteLine($"{redPaint:f2}");

        }
    }
}
