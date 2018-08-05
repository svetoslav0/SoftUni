using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            var s = double.Parse(Console.ReadLine());
            double commision = 0.0;
            switch (city)
            {
                case "sofia":
                    if (s >= 0 && s <= 500) commision = s * 0.05;
                    else if (s > 500 && s <= 1000) commision = s * 0.07;
                    else if (s > 1000 && s <= 10000) commision = s * 0.08;
                    else if (s > 10000) commision = s * 0.12;
                    else Console.WriteLine("error");
                    Console.WriteLine($"{commision:f2}");
                    break;
                case "varna":
                    if (s >= 0 && s <= 500) commision = s * 0.045;
                    else if (s > 500 && s <= 1000) commision = s * 0.075;
                    else if (s > 1000 && s <= 10000) commision = s * 0.1;
                    else if (s > 10000) commision = s * 0.13;
                    else Console.WriteLine("error");
                    Console.WriteLine($"{commision:f2}");
                    break;
                case "plovdiv":
                    if (s >= 0 && s <= 500) commision = s * 0.055;
                    else if (s > 500 && s <= 1000) commision = s * 0.08;
                    else if (s > 1000 && s <= 10000) commision = s * 0.12;
                    else if (s > 10000) commision = s * 0.145;
                    else Console.WriteLine("error");
                    Console.WriteLine($"{commision:f2}");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
