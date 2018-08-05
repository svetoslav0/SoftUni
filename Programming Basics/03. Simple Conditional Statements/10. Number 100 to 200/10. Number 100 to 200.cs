using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Number_100_to_200
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = int.Parse(Console.ReadLine());
            if (value < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (value >= 100 && value <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
