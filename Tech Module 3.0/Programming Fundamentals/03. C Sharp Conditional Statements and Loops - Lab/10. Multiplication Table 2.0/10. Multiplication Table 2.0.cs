using System;

namespace _10._Multiplication_Table_2._0
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{a} X {b} = {a*b}");
                b++;
            } while (b <= 10);
        }
    }
}