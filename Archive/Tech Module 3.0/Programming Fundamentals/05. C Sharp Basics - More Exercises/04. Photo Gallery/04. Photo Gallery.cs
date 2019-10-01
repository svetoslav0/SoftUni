using System;

namespace _04._Photo_Gallery
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var photoNumber = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var bytes = double.Parse(Console.ReadLine());
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            string photoType = "";

            if (a > b)
            {
                photoType = "landscape";
            }
            else if (a < b)
            {
                photoType = "portrait";
            }
            else
            {
                photoType = "square";
            }
            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hour:d2}:{minutes:d2}");
            if (bytes >= 1000000)
            {
                Console.WriteLine($"Size: {bytes/1000000}MB");
            }
            else if(bytes >= 1000)
            {
                Console.WriteLine($"Size: {bytes/1000}KB");
            }
            else
            {
                Console.WriteLine($"Size: {bytes}B");
            }

            Console.WriteLine($"Resolution: {a}x{b} ({photoType})");
        }
    }
}