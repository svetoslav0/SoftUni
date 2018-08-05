using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var third = int.Parse(Console.ReadLine());
            int sec = first + second + third;
            int min = 0;
            while(sec >= 60)
            {
                sec -= 60;
                min++;
            }
            Console.WriteLine($"{min}:{sec:d2}");
        }
    }
}
