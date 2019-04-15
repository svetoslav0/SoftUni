using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wedding_Investment
{
    class Program
    {
        static void Main(string[] args)
        {
            // one
            // Small
            // yes
            // 10
            string contractTerm = Console.ReadLine().ToLower();
            string contractSize = Console.ReadLine().ToLower();
            bool hasDessert = Console.ReadLine().ToLower() == "yes" ? true : false;
            double months = double.Parse(Console.ReadLine());

            double contractPrice = 0;

            // Base prices + extras
            switch (contractSize)
            {
                case "small":
                    if (contractTerm == "one")
                    {
                        contractPrice = 9.98;
                    }
                    else if (contractTerm == "two")
                    {
                        contractPrice = 8.58;
                    }

                    if (hasDessert)
                    {
                        contractPrice += 5.5;
                    }
                    break;

                case "middle":
                    if (contractTerm == "one")
                    {
                        contractPrice = 18.99;
                    }
                    else if (contractTerm == "two")
                    {
                        contractPrice = 17.09;
                    }

                    if (hasDessert)
                    {
                        contractPrice += 4.35;
                    }
                    break;

                case "large":
                    if (contractTerm == "one")
                    {
                        contractPrice = 25.98;
                    }
                    else if (contractTerm == "two")
                    {
                        contractPrice = 23.59;
                    }

                    if (hasDessert)
                    {
                        contractPrice += 4.35;
                    }
                    break;

                case "extralarge":
                    if (contractTerm == "one")
                    {
                        contractPrice = 35.99;
                    }
                    else if (contractTerm == "two")
                    {
                        contractPrice = 31.79;
                    }

                    if (hasDessert)
                    {
                        contractPrice += 3.85;
                    }
                    break;
            }

            // Discounts
            if (contractTerm == "two")
            {
                contractPrice *= 0.9625;
            }

            double totalPrice = contractPrice * months;

            Console.WriteLine($"{totalPrice:F2} lv.");
            
        }
    }
}
