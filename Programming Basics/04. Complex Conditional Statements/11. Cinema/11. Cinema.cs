using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            var c = double.Parse(Console.ReadLine());
            var r = double.Parse(Console.ReadLine());
            double totalPrice = 0.0;
            switch (type)
            {
                case "premiere":
                    totalPrice = r * c * 12;
                    break;
                case "normal":
                    totalPrice = r * c * 7.5;
                    break;
                case "discount":
                    totalPrice = r * c * 5;
                    break;

            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
