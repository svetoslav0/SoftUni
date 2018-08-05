using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            string inputString = Console.ReadLine();
            string outputString = Console.ReadLine();
            double outputValue = 0.0;
            switch (inputString)
            {
                case "mm":
                    outputValue = value / 1000;
                    break;
                case "cm":
                    outputValue = value / 100;
                    break;
                case "m":
                    outputValue = value;
                    break;
                case "mi":
                    outputValue = value / 0.000621371192;
                    break;
                case "in":
                    outputValue = value / 39.3700787;
                    break;
                case "km":
                    outputValue = value / 0.001;
                    break;
                case "ft":
                    outputValue = value / 3.2808399;
                    break;
                case "yd":
                    outputValue = value / 1.0936133;
                    break;

            }
            switch (outputString)
            {
                case "mm":
                    outputValue *= 1000;
                    break;
                case "cm":
                    outputValue *= 100;
                    break;
                case "m":
                    outputValue *= 1;
                    break;
                case "mi":
                    outputValue *= 0.000621371192;
                    break;
                case "in":
                    outputValue *= 39.3700787;
                    break;
                case "km":
                    outputValue *= 0.001;
                    break;
                case "ft":
                    outputValue *= 3.2808399;
                    break;
                case "yd":
                    outputValue *= 1.0936133;
                    break;
            }
            Console.WriteLine($"{outputValue:f8}");
        }
    }
}
