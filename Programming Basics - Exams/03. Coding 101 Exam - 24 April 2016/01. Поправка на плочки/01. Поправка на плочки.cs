using System;

namespace _01._Поправка_на_плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());

            double totalArea = n * n;
            double benchArea = m * o;
            double areaToCover = totalArea - benchArea;
            double talesArea = w * l;
            double talesNeeded = areaToCover / talesArea;
            Console.WriteLine($"{talesNeeded:f2}");
            double timeNeeded = talesNeeded / 5.0;
            Console.WriteLine($"{timeNeeded:f2}");
        }
    }
}
