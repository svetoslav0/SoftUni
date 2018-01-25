using System;

namespace _01._Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var third = int.Parse(Console.ReadLine());
            var fourth = int.Parse(Console.ReadLine());
            Console.WriteLine($"{first:d4} {second:d4} {third:d4} {fourth:d4}");
        }
    }
}
