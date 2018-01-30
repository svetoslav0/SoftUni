using System;

namespace _02._Circle_Area_Precision_12
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            double area = r * r * Math.PI;
            Console.WriteLine($"{area:f12}");
        }
    }
}
