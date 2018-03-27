using System;
using System.Globalization;
namespace _03._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());
            DateTime examTime = DateTime.ParseExact($"{examHour}-{examMinutes}","H-m",CultureInfo.InvariantCulture);
            DateTime arrivalTime = DateTime.ParseExact($"{arrivalHour}-{arrivalMinutes}","H-m",CultureInfo.InvariantCulture);
            TimeSpan diff = examTime.Subtract(arrivalTime);
            if ((diff.ToString())[0] == '-')
            {
                Console.WriteLine("Late");
                if (-diff.Hours >= 1)
                {
                    Console.WriteLine($"{-diff.Hours}:{-diff.Minutes:d2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{-diff.Minutes} minutes after the start");
                }
            }
            else if (diff.Hours == 0 && diff.Minutes <= 30)
            {
                Console.WriteLine("On time");
                if (diff.Hours >= 1)
                {
                    Console.WriteLine($"{diff.Hours}:{diff.Minutes:d2} hours before the start");
                }
                else if(diff.Minutes != 0)
                {
                    Console.WriteLine($"{diff.Minutes} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Early");
                if (diff.Hours >= 1)
                {
                    Console.WriteLine($"{diff.Hours}:{diff.Minutes:d2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{diff.Minutes} minutes before the start");

                }
            }



        }
    }
}