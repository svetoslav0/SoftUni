using System;

namespace _19._Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long totalPictures = long.Parse(Console.ReadLine());
            double filterTime = double.Parse(Console.ReadLine());
            double filterPercentace = double.Parse(Console.ReadLine());
            double uploadTime = double.Parse(Console.ReadLine());
            long filteredPics = (long)Math.Ceiling(filterPercentace/100 * totalPictures);
            double totalFilterTime = totalPictures * filterTime;
            long totalUploadTime = (long)(uploadTime * filteredPics);
            long totalTimeNeeded = (long)(totalFilterTime + totalUploadTime);
            long seconds = totalTimeNeeded % 60;
            totalTimeNeeded -= seconds;
            totalTimeNeeded /= 60;
            long minutes = totalTimeNeeded % 60;
            totalTimeNeeded -= minutes;
            totalTimeNeeded /= 60;
            long hours = totalTimeNeeded % 24;
            totalTimeNeeded -= hours;
            totalTimeNeeded /= 24;
            long days = totalTimeNeeded;
            Console.WriteLine($"{days:d1}:{hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}
