using System;

namespace _04._Own_Bussiness
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double totalSpace = width * lenght * height;
            double takenSpace = 0;

            string currentComputers = Console.ReadLine();
            while (currentComputers != "Done")
            {
                double currentSpace = int.Parse(currentComputers);
                takenSpace += currentSpace;
                if (takenSpace > totalSpace)
                {
                    Console.WriteLine($"No more free space! You need {takenSpace - totalSpace} Cubic meters more.");
                    break;
                }
                currentComputers = Console.ReadLine();
            }

            if (takenSpace < totalSpace)
            {
                Console.WriteLine($"{totalSpace - takenSpace} Cubic meters left.");
            }
        }
    }
}
