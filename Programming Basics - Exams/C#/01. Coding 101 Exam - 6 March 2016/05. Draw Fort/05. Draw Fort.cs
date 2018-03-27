using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"/{new string('^',n/2)}\\{new string('_',2*n - 4 - 2 * (n / 2))}/{new string('^', n / 2)}\\");
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine($"|{new string(' ',2 * n - 2)}|");
            }
            Console.WriteLine($"|{new string(' ', n / 2 + 1)}{new string('_', 2 * n - 4 - 2 * (n / 2))}{new string(' ', n / 2 + 1)}|");
            Console.WriteLine($"\\{new string('_',n/2)}/{new string(' ', 2 * n - 4 - 2 * (n / 2))}\\{new string('_', n / 2)}/");
        }
    }
}
