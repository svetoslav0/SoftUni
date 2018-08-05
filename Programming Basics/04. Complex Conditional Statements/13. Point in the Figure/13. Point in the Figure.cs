using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            bool out1 = y > h && x < h;
            bool out2 = x < 0 || out1;
            bool out3 = y < 0 || out2;
            bool out4 = x > 3 * h || out3;
            bool out5 = y > 4 * h || out4;
            bool out6 = x > 2 * h && y > h || out5;
            bool border1 = y == 0 && x >= 0 && x <= 3 * h;
            bool border2 = x == 0 && y >= 0 && y <= h || border1;
            bool border3 = y == h && x >= 0 && x <= h || border2;
            bool border4 = x == h && y >= h && y <= 4 * h || border3;
            bool border5 = y == 4 * h && x >= h && x <= 2 * h || border4;
            bool border6 = x == 2 * h && y >= h && y <= 4 * h || border5;
            bool border7 = y == h && x >= 2 * h && x <= 3 * h || border6;
            bool border8 = x == 3 * h && y >= 0 && y <= h || border7;
            if (out6)
            {
                Console.WriteLine("outside");
            }
            else if (border8) 
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("inside");
            }

        }
    }
}
