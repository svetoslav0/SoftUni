using System;

namespace _04._Hotel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string month = Console.ReadLine();
            var nights = double.Parse(Console.ReadLine());
            double studioNights = nights;
            double studioPrice = 0.0;
            double doublePrice = 0.0;
            double suitePrice = 0.0;
            if (nights > 7 && month == "September")
            {
                studioNights--;
            }
            if (nights > 7 && month == "October")
            {
                studioNights--;
            }
            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = studioNights * 50;
                    doublePrice = nights * 65;
                    suitePrice = nights * 75;
                    if (nights > 7)
                    {
                        studioPrice *= 0.95;
                    }
                    break;

                case "June":
                case "September":
                    studioPrice = studioNights * 60;
                    doublePrice = nights * 72;
                    suitePrice = nights * 82;
                    if (nights > 14)
                    {
                        doublePrice *= 0.9;
                    }
                    break;

                case "July":
                case "August":
                case "December":
                    studioPrice = studioNights * 68;
                    doublePrice = nights * 77;
                    suitePrice = nights * 89;
                    if (nights > 14)
                    {
                        suitePrice *= 0.85;
                    }
                    break;
            }

            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");
        }
    }
}