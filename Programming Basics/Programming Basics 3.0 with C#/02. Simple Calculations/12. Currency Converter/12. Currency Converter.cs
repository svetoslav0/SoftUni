using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            string inputValue = Console.ReadLine();
            string outputValue = Console.ReadLine();
            double result = 0.0;
            switch (inputValue)
            {
                case "BGN":
                    result = value * 1.0;
                    break;
                case "USD":
                    result = value * 1.79549;
                    break;
                case "EUR":
                    result = value * 1.95583;
                    break;
                case "GBP":
                    result = value * 2.53405;
                    break;
            }
            switch (outputValue)
            {
                case "BGN":
                    result = result / 1.0;
                    break;
                case "USD":
                    result = result / 1.79549;
                    break;
                case "EUR":
                    result = result / 1.95583;
                    break;
                case "GBP":
                    result = result / 2.53405;
                    break;
            }
            Console.WriteLine($"{Math.Round(result,2)} {outputValue}");
        }
    }
}
