using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().ToLower();
            string second = Console.ReadLine().ToLower();
            if (first == second)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}
