using System;

namespace _03._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the count of the people and the trace type from the console
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string traceType = Console.ReadLine();
            double earned = 0.0;

            // Calculate the earned money depending on the trace type
            switch (traceType)
            {
                case "trail":
                    earned = juniors * 5.5 + seniors * 7;
                    break;
                case "cross-country":
                    earned = juniors * 8 + seniors * 9.5;
                    break;
                case "downhill":
                    earned = juniors * 12.25 + seniors * 13.75;
                    break;
                case "road":
                    earned = juniors * 20 + seniors * 21.5;
                    break;
            }

            if (traceType == "cross-country" && juniors + seniors >= 50)
            {
                earned *= 0.75;
            }

            double net = earned * 0.95;

            // Print the result
            Console.WriteLine($"{net:f2}");
        }
    }
}
