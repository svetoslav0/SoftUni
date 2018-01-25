using System;

namespace _06._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int min = Int32.MaxValue;
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine(min);
        }
    }
}
