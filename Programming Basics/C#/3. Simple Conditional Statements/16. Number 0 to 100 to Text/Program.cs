using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Number_0_to_100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            int units = num % 10;
            int tens = num / 10;
            string unitsString = "";
            string tensString = "";
            switch (units)
            {
                case 1:
                    unitsString = " one";
                    break;
                case 2:
                    unitsString = " two";
                    break;
                case 3:
                    unitsString = " three";
                    break;
                case 4:
                    unitsString = " four";
                    break;
                case 5:
                    unitsString = " five";
                    break;
                case 6:
                    unitsString = " six";
                    break;
                case 7:
                    unitsString = " seven";
                    break;
                case 8:
                    unitsString = " eight";
                    break;
                case 9:
                    unitsString = " nine";
                    break;
            }
            switch (tens)
            {
                case 2:
                    tensString = "twenty";
                    break;
                case 3:
                    tensString = "thirty";
                    break;
                case 4:
                    tensString = "forty";
                    break;
                case 5:
                    tensString = "fifty";
                    break;
                case 6:
                    tensString = "sixty";
                    break;
                case 7:
                    tensString = "seventy";
                    break;
                case 8:
                    tensString = "eighty";
                    break;
                case 9:
                    tensString = "ninety";
                    break;
            }
            if (num >= 20 && num <= 99)
            {
                Console.WriteLine(tensString + unitsString);
            }
            else if (num >= 1 && num <= 9)
            {
                Console.WriteLine(unitsString.Substring(1));
            }
            else if((num >= 10 && num <= 19) || num == 100 || num == 0)
            {
                switch (num)
                {
                    case 0:
                        Console.WriteLine("zero");
                        break;
                    case 10:
                        Console.WriteLine("ten");
                        break;
                    case 11:
                        Console.WriteLine("eleven");
                        break;
                    case 12:
                        Console.WriteLine("twelve");
                        break;
                    case 13:
                        Console.WriteLine("thirteen");
                        break;
                    case 14:
                        Console.WriteLine("fourteen");
                        break;
                    case 15:
                        Console.WriteLine("fifteen");
                        break;
                    case 16:
                        Console.WriteLine("sixteen");
                        break;
                    case 17:
                        Console.WriteLine("seventeen");
                        break;
                    case 18:
                        Console.WriteLine("eighteen");
                        break;
                    case 19:
                        Console.WriteLine("nineteen");
                        break;
                    case 100:
                        Console.WriteLine("one hundred");
                        break;

                }
            }
            else
            {
                Console.WriteLine("invalid number");
            }

        }
    }
}
