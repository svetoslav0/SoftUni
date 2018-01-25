using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            double totalPrice = 0.0;
            switch (product)
            {
                case "coffee":
                    if (city == "sofia")
                    {
                        totalPrice = quantity * 0.5;
                    }
                    else if (city == "plovdiv")
                    {
                        totalPrice = quantity * 0.4;

                    }
                    else if (city == "varna")
                    {

                        totalPrice = quantity * 0.45;
                    }
                    break;
                case "water":
                    if (city == "sofia")
                    {

                        totalPrice = quantity * 0.8;
                    }
                    else if (city == "plovdiv")
                    {
                        totalPrice = quantity * 0.7;

                    }
                    else if (city == "varna")
                    {
                        totalPrice = quantity * 0.7;

                    }
                    break;
                case "beer":
                    if (city == "sofia")
                    {
                        totalPrice = quantity * 1.2;

                    }
                    else if (city == "plovdiv")
                    {
                        totalPrice = quantity * 1.15;

                    }
                    else if (city == "varna")
                    {
                        totalPrice = quantity * 1.1;

                    }
                    break;
                case "sweets":
                    if (city == "sofia")
                    {
                        totalPrice = quantity * 1.45;

                    }
                    else if (city == "plovdiv")
                    {

                        totalPrice = quantity * 1.3;
                    }
                    else if (city == "varna")
                    {
                        totalPrice = quantity * 1.35;

                    }
                    break;
                case "peanuts":
                    if (city == "sofia")
                    {
                        totalPrice = quantity * 1.6;

                    }
                    else if (city == "plovdiv")
                    {
                        totalPrice = quantity * 1.5;

                    }
                    else if (city == "varna")
                    {
                        totalPrice = quantity * 1.55;

                    }
                    break;
                    
            }
            Console.WriteLine(totalPrice);
        }
    }
}
