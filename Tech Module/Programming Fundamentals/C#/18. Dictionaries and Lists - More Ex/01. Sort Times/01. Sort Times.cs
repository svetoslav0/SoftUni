using System;
using System.Linq;

namespace _01._Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var times = Console.ReadLine().Split().OrderBy(t => t).ToList();
            Console.WriteLine(string.Join(", ", times.OrderBy(t => t)));

        }
    }
}
