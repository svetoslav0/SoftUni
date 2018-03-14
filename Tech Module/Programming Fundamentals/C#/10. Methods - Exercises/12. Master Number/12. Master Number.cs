using System;

namespace _12._Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                if (IsSymmetric(i) && IsSumDividable(i) && HasEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsSymmetric(int num)
        {
            bool isSymmetric = false;
            string numToString = num.ToString();
            for (int i = 0, j = num.ToString().Length - 1; i < j; i++, j--) //super clever! must remmember
            {                                                               //stolen from stackoverflow :D
                if (numToString[i] == numToString[j])
                {
                    isSymmetric = true;
                }
                else
                {
                    isSymmetric = false;
                    break;
                }
            }
            return isSymmetric;
        }
        static bool HasEvenDigit(int num)
        {
            bool hasEvenDigit = false;
            int temp = 0;
            for (int i = 1; i <= num; i++)
            {
                temp = num % 10;
                if (temp % 2 == 0)
                {
                    hasEvenDigit = true;
                    break;
                }
                num /= 10;
            }

            return hasEvenDigit;
        }
        static bool IsSumDividable(int num)
        {
            bool isDividable = false;
            int sum = 0;
            while (true)
            {
                sum += num % 10;
                num /= 10;
                if (num == 0)
                {
                    break;
                }
            }
            if (sum % 7 == 0)
            {
                isDividable = true;
            }
            return isDividable;
        }
    }
}
