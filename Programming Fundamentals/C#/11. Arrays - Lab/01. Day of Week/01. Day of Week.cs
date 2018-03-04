using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysToText =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            int num = int.Parse(Console.ReadLine());
            if (num < 1 || num > 7)
            {
                Console.WriteLine("Invalid Day!");
                return;
            }
            Console.WriteLine(daysToText[num - 1]);
        }
    }
}
