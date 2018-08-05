using System;

namespace _01._Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input from the console
            double speed = double.Parse(Console.ReadLine());
            double timeOne = double.Parse(Console.ReadLine()) / 60;
            double timeTwo = double.Parse(Console.ReadLine()) / 60;
            double timeThree = double.Parse(Console.ReadLine()) / 60;

            // Calculate the total distance with the speed changes
            double totalDistance = speed * timeOne;
            speed *= 1.1;
            totalDistance += speed * timeTwo;
            speed *= 0.95;
            totalDistance += speed * timeThree;

            // Print the result
            Console.WriteLine($"{totalDistance:f2}");
        }
    }
}
