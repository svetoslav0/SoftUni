using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0.0;
            switch (figure)
            {
                case "square":
                    var s = double.Parse(Console.ReadLine());
                    area = s * s;
                    break;
                case "rectangle":
                    var a = double.Parse(Console.ReadLine());
                    var b = double.Parse(Console.ReadLine());
                    area = a * b;
                    break;
                case "circle":
                    var r = double.Parse(Console.ReadLine());
                    area = r * r * Math.PI;
                    break;
                case "triangle":
                    var c = double.Parse(Console.ReadLine());
                    var h = double.Parse(Console.ReadLine());
                    area = c * h / 2;
                    break;
            }
            Console.WriteLine(Math.Round(area,3));
        }
    }
}
