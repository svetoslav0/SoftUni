using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long nInt = 0;
            double nDouble = 0;
            bool tryParseLong = long.TryParse(input, out nInt);
            if (tryParseLong)
            {
                nInt = long.Parse(input);
                if (nInt >= sbyte.MinValue && nInt <= sbyte.MaxValue)
                {
                    Console.WriteLine($"Sunny");
                }
                else if (nInt >= int.MinValue && nInt <= int.MaxValue)
                {
                    Console.WriteLine($"Cloudy");
                }
                else
                {
                    Console.WriteLine($"Windy");
                }
            }
            else
            {
                nDouble = double.Parse(input);
                Console.WriteLine("Rainy");
            }
        }
    }
}