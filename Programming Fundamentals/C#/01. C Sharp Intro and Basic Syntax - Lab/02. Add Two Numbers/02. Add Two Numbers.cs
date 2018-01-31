using System;

namespace _02._Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a+b}");
        }
    }
}
