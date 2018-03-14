using System;

namespace _03._Exact_Sum_of_Real_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal num = 0m;
            decimal sum = 0m;
            for (int i = 0; i < n; i++)
            {
                num = decimal.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
