using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = double.Parse(Console.ReadLine());
            double f = c * 9 / 5 + 32;
            Console.WriteLine(Math.Round(f,2));
        }
    }
}
