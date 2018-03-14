using System;

namespace _03._Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var mile = double.Parse(Console.ReadLine());
            Console.WriteLine($"{mile* 1.60934 :f2}");
        }
    }
}
