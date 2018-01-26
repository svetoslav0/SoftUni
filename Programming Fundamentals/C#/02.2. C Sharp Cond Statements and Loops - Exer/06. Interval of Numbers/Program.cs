using System;

namespace _06._Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                int c = a;
                a = b;
                b = c;
            }
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
