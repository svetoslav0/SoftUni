using System;

namespace _10._Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string toCalculate = Console.ReadLine();
            PrintCubeCalculations(side, toCalculate);
        }

        static void PrintCubeCalculations(double side, string toCalculate)
        {
            switch (toCalculate)
            {
                case "face":
                    Console.WriteLine($"{Math.Sqrt(2) * side:f2}");
                    break;
                case "space":
                    Console.WriteLine($"{Math.Sqrt(3)*side:f2}");
                    break;
                case "volume":
                    Console.WriteLine($"{Math.Pow(side,3):f2}");
                    break;
                case "area":
                    Console.WriteLine($"{6*Math.Pow(side,2):f2}");
                    break;

            }
        }
    }
}
