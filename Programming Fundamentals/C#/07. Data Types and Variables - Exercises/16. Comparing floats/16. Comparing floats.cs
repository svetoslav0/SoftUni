using System;

namespace _16._Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            double diff = Math.Abs(a - b);
            double acceptable = 0.000001;
            bool isEqual = true;
            isEqual = (diff >= acceptable) ? false : true;
            Console.WriteLine(isEqual);
        }
    }
}
