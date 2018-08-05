using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            double totalPrice = 0.0;
            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        totalPrice = quantity * 2.5;
                        break;
                    case "apple":
                        totalPrice = quantity * 1.2;
                        break;
                    case "orange":
                        totalPrice = quantity * 0.85;
                        break;
                    case "grapefruit":
                        totalPrice = quantity * 1.45;
                        break;
                    case "kiwi":
                        totalPrice = quantity * 2.7;
                        break;
                    case "pineapple":
                        totalPrice = quantity * 5.5;
                        break;
                    case "grapes":
                        totalPrice = quantity * 3.85;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        totalPrice = quantity * 2.7;
                        break;
                    case "apple":
                        totalPrice = quantity * 1.25;
                        break;
                    case "orange":
                        totalPrice = quantity * 0.9;
                        break;
                    case "grapefruit":
                        totalPrice = quantity * 1.6;
                        break;
                    case "kiwi":
                        totalPrice = quantity * 3;
                        break;
                    case "pineapple":
                        totalPrice = quantity * 5.6;
                        break;
                    case "grapes":
                        totalPrice = quantity * 4.2;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
