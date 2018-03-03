using System;

namespace _05._Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = ConvertFahrToCel(fahrenheit);
            Console.WriteLine($"{celsius:f2}");
        }
        static double ConvertFahrToCel(double fahr)
        {
            double cel = (fahr - 32) * 5 / 9;
            return cel;
        }
    }
}
