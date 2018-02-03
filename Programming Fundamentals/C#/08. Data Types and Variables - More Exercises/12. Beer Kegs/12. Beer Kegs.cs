using System;

namespace _12._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentModel = "";
            double currentRadius = 0.0;
            double currentHeight = 0.0;
            double currentVolume = 0.0;
            string finalModel = "";
            double finalVolume = 0.0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                currentModel = Console.ReadLine();
                currentRadius = double.Parse(Console.ReadLine());
                currentHeight = double.Parse(Console.ReadLine());
                currentVolume = Math.PI * Math.Pow(currentRadius, 2) * currentHeight;
                if (currentVolume > finalVolume)
                {
                    finalModel = currentModel;
                    finalVolume = currentVolume;
                }
            }
            Console.WriteLine(finalModel);
        }
    }
}
