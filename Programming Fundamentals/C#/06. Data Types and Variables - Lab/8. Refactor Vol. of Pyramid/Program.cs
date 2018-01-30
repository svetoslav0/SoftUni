using System;

namespace _8._Refactor_Vol._of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = 0;
            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            volume = lenght * width * height / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
