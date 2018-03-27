using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < 200)
                {
                    p1++;
                }
                else if (currentNumber >= 200 && currentNumber <= 399)
                {
                    p2++;
                }
                else if (currentNumber >= 400 && currentNumber <= 599)
                {
                    p3++;
                }
                else if (currentNumber >= 600 && currentNumber <= 799)
                {
                    p4++;
                }
                else if (currentNumber >= 800)
                {
                    p5++;
                }
            }
            Console.WriteLine($"{Math.Round(p1*100/n,2):f2}%");
            Console.WriteLine($"{Math.Round(p2*100/n,2):f2}%");
            Console.WriteLine($"{Math.Round(p3*100/n,2):f2}%");
            Console.WriteLine($"{Math.Round(p4*100/n,2):f2}%");
            Console.WriteLine($"{Math.Round(p5*100/n,2):f2}%");

        }
    }
}
