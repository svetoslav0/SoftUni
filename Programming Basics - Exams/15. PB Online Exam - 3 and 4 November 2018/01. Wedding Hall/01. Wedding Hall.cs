using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wedding_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double barLength = double.Parse(Console.ReadLine());

            double hallArea = width * length;
            double barArea = barLength * barLength;

            double freeSpace = hallArea - barArea - 0.19 * hallArea;
            double guests = Math.Ceiling(freeSpace / 3.2);

            Console.WriteLine(guests);
        }
    }
}
