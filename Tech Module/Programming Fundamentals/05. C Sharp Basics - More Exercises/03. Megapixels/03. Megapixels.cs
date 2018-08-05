using System;

namespace _03._Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            double pixels = a * b;
            pixels /= 1000000.0;
            Console.WriteLine($"{a}x{b} => {Math.Round(pixels,1)}MP");
        }
    }
}
