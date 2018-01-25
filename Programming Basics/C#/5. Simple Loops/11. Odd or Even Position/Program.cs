using System;

namespace _11._Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double num = 0;
            double oddSum = 0.0;
            double oddMin = Int32.MaxValue;
            double oddMax = Int32.MinValue;
            double evenSum = 0.0;
            double evenMin = Int32.MaxValue;
            double evenMax = Int32.MinValue;
            for (int i = 0; i < n; i++)
            {
                num = double.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    oddSum += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                }
                else
                {
                    evenSum += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
            }
            string odd1 = (oddMin != Int32.MaxValue) ? Convert.ToString(oddMin) : "No";
            string odd2 = (oddMax != Int32.MinValue ? Convert.ToString(oddMax) : "No");
            string even1 = (evenMin != Int32.MaxValue) ? Convert.ToString(evenMin) : "No";
            string even2 = (evenMax != Int32.MinValue) ? Convert.ToString(evenMax) : "No";
            Console.WriteLine($"OddSum={oddSum},");
            Console.WriteLine($"OddMin={odd1},");
            Console.WriteLine($"OddMax={odd2},");
            Console.WriteLine($"EvenSum={evenSum},");
            Console.WriteLine($"EvenMin={even1},");
            Console.WriteLine($"EvenMax={even2}");


        }
    }
}
