using System;

namespace _01._Dog_House
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input data from the console
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            // Calculate each wall's and roof's area
            double sideWalls = a * a;
            double backWall = Math.Pow(a / 2, 2) + (a / 2) * (b - a / 2) / 2;
            double frontWall = backWall - Math.Pow(a / 5, 2);
            double totalWalls = sideWalls + backWall + frontWall;
            double roofArea = Math.Pow(a, 2);

            // Calculate the paint for the walls and the roof
            double greenPaint = totalWalls / 3;
            double redPaint = roofArea / 5;

            // Print the result
            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");

        }
    }
}
