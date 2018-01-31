using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Time_Plus_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            min += 15;
            if (min >= 60)
            {
                min -= 60;
                hour++;
            }
            if (hour == 24)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{min:d2}");
        }
    }
}
