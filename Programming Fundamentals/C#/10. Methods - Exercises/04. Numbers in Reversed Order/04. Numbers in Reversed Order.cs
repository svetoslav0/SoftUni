using System;

namespace _04._Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNum(num));
        }

        static string ReverseNum(double num)
        {
            string numString = Convert.ToString(num);
            string reversedNumString = "";
            int loop = numString.Length - 1;
            for (int i = 0; i <= loop; i++)
            {
                reversedNumString += numString[loop - i];
                numString = numString.Remove(numString.Length - 1);
            }
            return reversedNumString;
        }
    }
}
