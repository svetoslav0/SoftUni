using System;

namespace _09._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLine = GetLength(x1, y1, x2, y2);
            double secondLine = GetLength(x3, y3, x4, y4);


            if (firstLine >= secondLine)
            {
                if (CheckCloserPoint(x1, y1, x2, y2))
                {
                    Console.Write($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.Write($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else if (firstLine < secondLine)
            {
                if (CheckCloserPoint(x3, y3, x4, y4))
                {
                    Console.Write($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.Write($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        public static bool CheckCloserPoint(double x1, double y1, double x2, double y2)
        {
            bool isCloserToZero = false;
            double dist1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double dist2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (dist1 <= dist2)
            {
                isCloserToZero = true;
            }
            return isCloserToZero;
        }

        public static double GetLength(double x1, double y1, double x2, double y2)
        {
            double lineLength = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return lineLength;

        }
    }
    
}
