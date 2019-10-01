using System;

namespace _11._Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            PrintArea(figure);

        }

        static void PrintArea(string figure)
        {
            double side, width, radius, height;
            switch (figure)
            {
                case "triangle":
                    side = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{side*height/2:f2}");
                    break;
                case "square":
                    side = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{Math.Pow(side,2):f2}");
                    break;
                case "rectangle":
                    width = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{width*height:f2}");
                    break;
                case "circle":
                    radius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{Math.PI*Math.Pow(radius,2):f2}");
                    break;
            }
        }
    }
}
